using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;

namespace DbConfigurator.Application.UnitTests.DistibutionInformation.Commands
{
    public class UpdateDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly FakePriorityRepository _priorityRepository;
        private readonly FakeRegionRepository _regionRepository;

        public UpdateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _priorityRepository = new FakePriorityRepository();
            _regionRepository = new FakeRegionRepository();
        }
        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfDistributionInformationWithSpecifiedIdIsPresentInDatabase()
        {
            // Arragne
            var handler = new UpdateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository);

            var _updateCommand = new UpdateDistributionInformationCommand() { DistributionInformation = UpdateDistributionInformationDto() };

            _distributionInfromationRepository.ExistsAsyncReturns(false);
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(true);


            // Act
            var result = await handler.Handle(_updateCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of distribution information object with specified Id is present in database.");
        }

        private DistributionInformationDto UpdateDistributionInformationDto()
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
                    Id = 2,
                    Name = "P2"
                }
            };
        }
    }
}
