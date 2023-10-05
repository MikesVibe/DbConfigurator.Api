using AutoMapper;
using DbConfigurator.Application.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using DbConfigurator.Application.Features.DistributionInformation;

namespace DbConfigurator.Application.UnitTests.DistributionInformation.Queries
{
    public class GetDistributionInformationDetailsQueryHandlerTests
    {
        [Fact]
        public async void Handle_Should_ReturnDistribiutionInformationDetails()
        {
            // Arragne
            var getCommand = new GetDistributionInformationDetailsQuery() 
            {
                Id = 1
            };
            var fakeRepository = new FakeDistributionInformationRepository();
            var mapper = MapperBuilder.AddDistributionInformationProfiles().Create();

            var handler = new GetDistributionInformationDetailsQueryHandler(
                fakeRepository,
                mapper);

            // Act
            var result = await handler.Handle(getCommand, new CancellationToken());

            // Assert
            Assert.Equal("America", result.Region.Area.Name);
            Assert.Equal("NAO", result.Region.BuisnessUnit.Name);
            Assert.Equal("Canada", result.Region.Country.CountryName);
            Assert.Equal("CA", result.Region.Country.CountryCode);
            Assert.Equal("P1", result.Priority.Name);
        }
    }
}
