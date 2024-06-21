using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;
using NSubstitute;

namespace DbConfigurator.Application.UnitTests.FeaturesTests.DistibutionInformation.Commands
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
            var handler = Substitute.For<DeleteDistributionInfomationCommandHandler>(_distributionInfromationRepository);

            var deleteCommand = Substitute.For<DeleteDistributionInfomationCommand>();
            deleteCommand.Id = 90;

            // Act
            var result = await handler.Handle(deleteCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No instance of object with specified Id is present in database.");
        }
    }
}
