using AutoMapper;
using DbConfigurator.Api.IService;
using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services.Repositories;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Model.DTOs.Core;

namespace DbConfigurator.Api.Services
{
    public class DistributionInformationService : DataService<DistributionInformationRepository, DistributionInformation, DistributionInformationDto>, IDistributionInformationService
    {
        private readonly IRepository<DistributionInformation> repository;
        private readonly IMapper mapper;

        public DistributionInformationService(DistributionInformationRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

    }
}
