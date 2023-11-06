using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;

namespace DbConfigurator.Application.UnitTests.FeaturesTests.DistibutionInformation.Commands
{
    public class UpdateDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly FakeRecipientRepository _recipientRepository;
        private readonly FakePriorityRepository _priorityRepository;
        private readonly FakeRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public UpdateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _recipientRepository = new FakeRecipientRepository();
            _priorityRepository = new FakePriorityRepository();
            _regionRepository = new FakeRegionRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();
        }
        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfDistributionInformationWithSpecifiedIdIsPresentInDatabase()
        {
            // Arrange
            var handler = new UpdateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _recipientRepository,
                _priorityRepository,
                _regionRepository,
                _mapper);

            var _updateCommand = new UpdateDistributionInformationCommand() { UpdateEntityDto = CreateUpdateDistributionInformationDto() };

            _distributionInfromationRepository.ExistsAsyncReturns(false);
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(true);


            // Act
            var result = await handler.Handle(_updateCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of distribution information object with specified Id is present in database.");
        }

        private UpdateDistributionInformationDto CreateUpdateDistributionInformationDto()
        {
            return new UpdateDistributionInformationDto()
            {
                Id = 0,
                RegionId = 1,
                PriorityId = 2
            };
        }
    }
}
