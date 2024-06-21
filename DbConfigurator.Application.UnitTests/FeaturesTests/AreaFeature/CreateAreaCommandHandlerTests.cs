using AutoMapper;
using DbConfigurator.Application.Features.AreaFeature.Commands.Create;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.FeaturesTests.AreaFeature
{
    public class CreateAreaCommandHandlerTests
    {
        private readonly Mapper _mapper;
        private FakeAreaRepository _repo;

        public CreateAreaCommandHandlerTests()
        {
            //_mapper = MapperBuilder.AddAreaProfiles().Create();
        }
        public void Handle_Should_ReturnFailedResult_When_AreaNameIsToLong()
        {
            _repo = new FakeAreaRepository();

            var handler = new CreateAreaCommandHandler(_repo, _mapper);
        }
    }
}
