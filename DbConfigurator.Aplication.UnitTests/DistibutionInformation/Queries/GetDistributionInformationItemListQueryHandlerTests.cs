using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Application.Profiles;
using DbConfigurator.Application.Features.DistributionInformation.Queries.GetDistributionInformationList;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Model.Entities.Core;
using FluentResults;
using NSubstitute;
using NSubstitute.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.DistibutionInformation.Queries
{
    public class GetDistributionInformationItemListQueryHandlerTests
    {
        [Fact]
        public async void Handle_Should_ReturnDistribiutionInformationItemList()
        {
            // Arragne
            var getCommand = new GetDistributionInformationItemListQuery();
            var fakeRepository = new FakeDistributionInformationRepository();
            var mapper = MapperBuilder.AddDistributionInformationProfiles().Create();

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
