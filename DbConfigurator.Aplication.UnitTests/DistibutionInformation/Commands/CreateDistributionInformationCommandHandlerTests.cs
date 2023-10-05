using AutoMapper;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Fixtures;
using DbConfigurator.Application.UnitTests.Common.Repositories;
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
        private readonly Mapper _mapper;

        public CreateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _regionRepository = new FakeRegionRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();
        }
        [Fact]
        public async Task Handle_Should_ReturnNewlyCreatedDistributionInformation_When_SuccessfullyCreateDistribiutionInformation()
        {
            // Arragne
            var distributionInformationToCreate = _distributionInfromationRepository.GetNotExistingDistributionInformationDto();
            var createCommand = new CreateDistributionInformationCommand() 
            { 
                DistributionInformation = distributionInformationToCreate
            };
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _regionRepository,
                _mapper);

            // Act
            var result = await handler.Handle(createCommand, new CancellationToken());

            // Assert
            Assert.NotNull(result);

            //Assert.Equal(distributionInformationToCreate.Region.Area.Name, first.Region.Area.Name);
            //Assert.Equal("NAO", first.Region.BuisnessUnit.Name);
            //Assert.Equal("Canada", first.Region.Country.CountryName);
            //Assert.Equal("CA", first.Region.Country.CountryCode);
            //Assert.Equal("P1", first.Priority.Name);
        }

        [Fact]
        public async Task Handle_Should_ReturnFalse_When_DataInCreateCommandAreNotValid()
        {
            // Arragne
            var createCommand = new CreateDistributionInformationCommand();
            var distributionInfromationRepository = new FakeDistributionInformationRepository();
            var regionRepository = new FakeRegionRepository();
            var mapper = MapperBuilder.AddDistributionInformationProfiles().Create();

            var handler = new CreateDistributionInformationCommandHandler(
                distributionInfromationRepository,
                regionRepository,
                mapper);

            // Act
            var result = await handler.Handle(createCommand, new CancellationToken());

            // Assert
            Assert.True(false);
        }
    }
}
