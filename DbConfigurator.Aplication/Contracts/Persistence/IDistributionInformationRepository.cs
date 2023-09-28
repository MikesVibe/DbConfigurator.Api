using DbConfigurator.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IDistributionInformationRepository : IRepository<DistributionInformation>
    {
        Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds);
    }
}
