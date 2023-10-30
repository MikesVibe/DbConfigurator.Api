using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.DistributionInformationTests.Queries
{
    public class GetDistributionInformationDetailsQueryHandlerTests
    {
        [Fact]
        public async void Handle_Should_ReturnDistribiutionInformationDetails()
        {
            // Arrange
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
            Assert.Equal("NAO", result.Region.BusinessUnit.Name);
            Assert.Equal("Canada", result.Region.Country.CountryName);
            Assert.Equal("CA", result.Region.Country.CountryCode);
            Assert.Equal("P1", result.Priority.Name);
        }
    }
}
