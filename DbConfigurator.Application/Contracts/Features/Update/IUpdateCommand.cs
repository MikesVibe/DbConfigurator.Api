namespace DbConfigurator.Application.Contracts.Features.Update
{
    public interface IUpdateCommand
    {
        public IUpdateEntityDto UpdateEntityDto { get; set; }
    }
}
