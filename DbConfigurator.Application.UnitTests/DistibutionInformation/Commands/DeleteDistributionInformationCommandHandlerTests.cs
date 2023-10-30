using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;

namespace DbConfigurator.Application.UnitTests.DistibutionInformationTests.Commands
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
            // Arrange
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
