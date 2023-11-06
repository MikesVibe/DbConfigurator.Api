using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.FeaturesTests.DistibutionInformation.Queries
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
            var resultDto = result.Value;

            // Assert
            Assert.Equal("America", resultDto.Region.Area.Name);
            Assert.Equal("NAO", resultDto.Region.BusinessUnit.Name);
            Assert.Equal("Canada", resultDto.Region.Country.CountryName);
            Assert.Equal("CA", resultDto.Region.Country.CountryCode);
            Assert.Equal("P1", resultDto.Priority.Name);
        }
    }
}
