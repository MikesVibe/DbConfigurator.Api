namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface ISeeder
    {
        public Task SeedAsync();
    }
}
