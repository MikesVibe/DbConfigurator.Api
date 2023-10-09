using AutoMapper;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Fixtures;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using DbConfigurator.Model.Entities.Core;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.DistributionInformation
{
    public class CreateDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly FakeRegionRepository _regionRepository;
        private readonly FakePriorityRepository _priorityRepository;
        private readonly Mapper _mapper;

        public CreateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _regionRepository = new FakeRegionRepository();
            _priorityRepository = new FakePriorityRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();
        }

        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfRegionWithSpecifiedIdIsPresentInDatabase()
        {
            // Arragne
            var distributionInformationToCreate = CreateNotExistingDistributionInformationDto();
            var createCommand = new CreateDistributionInformationCommand()
            {
                DistributionInformation = distributionInformationToCreate
            };
            _regionRepository.ExistsAsyncReturns(false);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(createCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of region object with specified Id is present in database.");
        }
        //[Fact]
        //public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfPriorityWithSpecifiedIdIsPresentInDatabase()
        //{
        //    // Arragne
        //    var distributionInformationToCreate = CreateNotExistingDistributionInformationDto();
        //    var createCommand = new CreateDistributionInformationCommand()
        //    {
        //        DistributionInformation = distributionInformationToCreate
        //    };
        //    _regionRepository.ExistsAsyncReturns(false);
        //    var handler = new CreateDistributionInformationCommandHandler(
        //        _distributionInfromationRepository,
        //        _regionRepository,
        //        _mapper);

        //    // Act
        //    var result = await handler.Handle(createCommand, new CancellationToken());

        //    // Assert
        //    result.IsFailed.Should().BeTrue();
        //    result.Errors.First().Message.Should().Be("No istnace of priority object with specified Id is present in database.");
        //}
        [Fact]
        public async Task Handle_Should_ReturnNewlyCreatedDistributionInformation_When_SuccessfullyCreateDistribiutionInformation()
        {
            // Arragne
            var distributionInformationToCreate = CreateNotExistingDistributionInformationDto();
            var createCommand = new CreateDistributionInformationCommand()
            {
                DistributionInformation = distributionInformationToCreate
            };
            _regionRepository.ExistsAsyncReturns(true);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(createCommand, new CancellationToken());

            // Assert
            result.IsSuccess.Should().BeTrue();
            var resultValue = result.Value;

            Assert.Equal(distributionInformationToCreate.Region.Area.Name, resultValue.Region.Area.Name);
            Assert.Equal(distributionInformationToCreate.Region.BuisnessUnit.Name, resultValue.Region.BuisnessUnit.Name);
            Assert.Equal(distributionInformationToCreate.Region.Country.CountryName, resultValue.Region.Country.CountryName);
            Assert.Equal(distributionInformationToCreate.Region.Country.CountryCode, resultValue.Region.Country.CountryCode);
            Assert.Equal(distributionInformationToCreate.Priority.Name, resultValue.Priority.Name);
        }

        private DistributionInformationDto CreateNotExistingDistributionInformationDto()
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
                    BuisnessUnit = new BuisnessUnitDto()
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
