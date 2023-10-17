using AutoMapper;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.DistributionInformationTests
{
    public class GetDistributionInformationItemListQueryHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly Mapper _mapper;

        public GetDistributionInformationItemListQueryHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();
        }
        [Fact]
        public async void Handle_Should_ReturnDistribiutionInformationItemList()
        {
            // Arragne
            var getCommand = new GetDistributionInformationItemListQuery();

            var handler = new GetDistributionInformationItemListQueryHandler(
                _distributionInfromationRepository,
                _mapper);

            // Act
            var result = await handler.Handle(getCommand, new CancellationToken());
            var first = result.First();

            // Assert
            Assert.Equal(3, result.Count());
            Assert.Equal("America", first.Region.Area.Name);
            Assert.Equal("NAO", first.Region.BusinessUnit.Name);
            Assert.Equal("Canada", first.Region.Country.CountryName);
            Assert.Equal("CA", first.Region.Country.CountryCode);
            Assert.Equal("P1", first.Priority.Name);
        }
    }
}
