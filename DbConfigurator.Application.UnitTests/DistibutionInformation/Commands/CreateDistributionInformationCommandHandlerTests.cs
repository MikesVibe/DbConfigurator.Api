using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.UnitTests.Common;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using FluentAssertions;

namespace DbConfigurator.Application.UnitTests.DistributionInformationTests.Commands
{
    public class CreateDistributionInformationCommandHandlerTests
    {
        private readonly FakeDistributionInformationRepository _distributionInfromationRepository;
        private readonly FakeRegionRepository _regionRepository;
        private readonly FakePriorityRepository _priorityRepository;
        private readonly FakeRecipientRepository _recipientRepository;
        private readonly Mapper _mapper;
        private CreateDistributionInformationDto _distributionInformationToCreate;
        private CreateDistributionInformationCommand _createCommand;

        public CreateDistributionInformationCommandHandlerTests()
        {
            _distributionInfromationRepository = new FakeDistributionInformationRepository();
            _regionRepository = new FakeRegionRepository();
            _priorityRepository = new FakePriorityRepository();
            _recipientRepository = new FakeRecipientRepository();
            _mapper = MapperBuilder.AddDistributionInformationProfiles().Create();

            _distributionInformationToCreate = CreateDistributionInformationDto();
            _createCommand = new CreateDistributionInformationCommand()
            {
                CreateEntityDto = _distributionInformationToCreate
            };
        }

        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfRegionWithSpecifiedIdIsPresentInDatabase()
        {
            // Arrange
            _regionRepository.ExistsAsyncReturns(false);
            _priorityRepository.ExistsAsyncReturns(true);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _recipientRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of region object with specified Id is present in database.");
        }
        [Fact]
        public async Task Handle_Should_ReturnFailedResult_When_NoInstanceOfPriorityWithSpecifiedIdIsPresentInDatabase()
        {
            // Arrange
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(false);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _recipientRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsFailed.Should().BeTrue();
            result.Errors.First().Message.Should().Be("No istnace of priority object with specified Id is present in database.");
        }
        [Fact]
        public async Task Handle_Should_ReturnSuccessfulResult_When_SuccessfullyCreateDistribiutionInformation()
        {
            // Arrange
            _regionRepository.ExistsAsyncReturns(true);
            _priorityRepository.ExistsAsyncReturns(true);
            var handler = new CreateDistributionInformationCommandHandler(
                _distributionInfromationRepository,
                _priorityRepository,
                _regionRepository,
                _recipientRepository,
                _mapper);

            // Act
            var result = await handler.Handle(_createCommand, new CancellationToken());

            // Assert
            result.IsSuccess.Should().BeTrue();
        }

        private CreateDistributionInformationDto CreateDistributionInformationDto()
        {
            return new CreateDistributionInformationDto()
            {
                RegionId = 1,
                PriorityId = 1
            };
        }

    }
}
