namespace DbConfigurator.Application.Contracts.Features.Create
{
    public interface ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
