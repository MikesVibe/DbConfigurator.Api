using AutoMapper;
using DbConfigurator.Api.IService;
using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services.Repositories;
using DbConfigurator.Model.DTOs.Core;

namespace DbConfigurator.Api.Services
{
    public class DistributionInformationService : DataService<DistributionInformation, DistributionInformationDto>, IDistributionInformationService
    {
        private readonly IRepository<DistributionInformation> repository;
        private readonly IMapper mapper;

        public DistributionInformationService(IRepository<DistributionInformation> repository, IMapper mapper)
            : base(repository, mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

    }
}
