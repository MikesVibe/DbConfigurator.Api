using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Api.Profiles;
using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList;
using DbConfigurator.Aplication.Profiles;
using DbConfigurator.Aplication.UnitTests.Common;
using DbConfigurator.Model.Entities.Core;
using FluentResults;
using NSubstitute;
using NSubstitute.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.UnitTests.DistibutionInformation.Queries
{
    public class GetDistributionInformationItemListQueryHandlerTests
    {
        [Fact]
        public async void Handle_Should_ReturnDistribiutionInformationItemList()
        {
            // Arragne
            var getCommand = new GetDistributionInformationItemListQuery();
            var fakeRepository = new FakeDistributionInformationRepository();

            var mapperConfiguration = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<DistributionInformationProfile>();
                    cfg.AddProfile<RegionProfile>();
                    cfg.AddProfile<PriorityProfile>();
                    cfg.AddProfile<AreaProfile>();
                    cfg.AddProfile<BuisnessUnitProfile>();
                    cfg.AddProfile<CountryProfile>();
                });
            var mapper = new Mapper(mapperConfiguration);

            var handler = new GetDistributionInformationItemListQueryHandler(
                fakeRepository,
                mapper);

            // Act
            var result = await handler.Handle(getCommand, new CancellationToken());
            var first = result.First();
            
            // Assert
            Assert.Equal(3, result.Count());
            Assert.Equal("America", first.Region.Area.Name);
            Assert.Equal("NAO", first.Region.BuisnessUnit.Name);
            Assert.Equal("Canada", first.Region.Country.CountryName);
            Assert.Equal("CA", first.Region.Country.CountryCode);
            Assert.Equal("P1", first.Priority.Name);
        }


    }
}
