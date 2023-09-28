using DbConfigurator.Application.Features.DistributionInformation.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformation.Queries.GetDistributionInformationList;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.DistibutionInformation.Commands
{
    public class CreateDistributionInformationCommandHandlerTests
    {
        [Fact]
        public async Task Handle_Should_ReturnTrue_When_SuccessfullyCreateDistribiutionInformation()
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
            Assert.True(result);

            //Assert.Equal("America", first.Region.Area.Name);
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
