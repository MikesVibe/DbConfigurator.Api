using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;

namespace DbConfigurator.Application.UnitTests.DistributionInformationTests.Commands
{
    public class CreateDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly FakeRegionRepository _regionRepository;
        private readonly FakePriorityRepository _priorityRepository;
        private readonly Mapper _mapper;
        private DistributionInformationDto _distributionInformationToCreate;
        private CreateDistributionInformationCommand _createCommand;

        public CreateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _regionRepository = new FakeRegionRepository();
            _priorityRepository = new FakePriorityRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();

            _distributionInformationToCreate = CreateDistributionInformationDto();
            _createCommand = new CreateDistributionInformationCommand()
            {
                DistributionInformation = _distributionInformationToCreate
            };
        }

        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfRegionWithSpecifiedIdIsPresentInDatabase()
        {
            // Arragne
            _regionRepository.ExistsAsyncReturns(false);
            _priorityRepository.ExistsAsyncReturns(true);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of region object with specified Id is present in database.");
        }
        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfPriorityWithSpecifiedIdIsPresentInDatabase()
        {
            // Arragne
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(false);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of priority object with specified Id is present in database.");
        }
        [Fact]
        public async Task Handle_Should_ReturnNewlyCreatedDistributionInformation_When_SuccessfullyCreateDistribiutionInformation()
        {
            // Arragne
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(true);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsSuccess.Should().BeTrue();
            var resultValue = result.Value;

            Assert.Equal(_distributionInformationToCreate.Region.Area.Name, resultValue.Region.Area.Name);
            Assert.Equal(_distributionInformationToCreate.Region.BusinessUnit.Name, resultValue.Region.BusinessUnit.Name);
            Assert.Equal(_distributionInformationToCreate.Region.Country.CountryName, resultValue.Region.Country.CountryName);
            Assert.Equal(_distributionInformationToCreate.Region.Country.CountryCode, resultValue.Region.Country.CountryCode);
            Assert.Equal(_distributionInformationToCreate.Priority.Name, resultValue.Priority.Name);
        }

        private DistributionInformationDto CreateDistributionInformationDto()
        {
            return new DistributionInformationDto()
            {
                Id = 0,
                Region = new RegionDto()
                {
                    Id = 1,
                    Area = new AreaDto()
                    {
                        Id = 1,
                        Name = "America"
                    },
                    BusinessUnit = new BusinessUnitDto()
                    {
                        Id = 1,
                        Name = "NAO"
                    },
                    Country = new CountryDto()
                    {
                        Id = 1,
                        CountryName = "Canada",
                        CountryCode = "CA"
                    }
                },
                Priority = new PriorityDto()
                {
                    Id = 1,
                    Name = "P1"
                }
            };
        }

    }
}
