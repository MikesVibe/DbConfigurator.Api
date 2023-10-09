using AutoMapper;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.DistibutionInformation.Commands
{
    public class DeleteDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;

        public DeleteDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
        }

        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfDistributionInformationWithSpecifiedIdIsPresentInDatabase()
        {
            // Arragne
            var handler = new DeleteDistributionInfomationCommandHandler(
                _distributionInfromationRepository);

            var _deleteCommand = new DeleteDistributionInfomationCommand() { DistributionInformationId = 90 };

            // Act
            var result = await handler.Handle(_deleteCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of distribution information object with specified Id is present in database.");
        }
    }
}
