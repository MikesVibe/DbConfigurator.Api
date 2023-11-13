using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.NotificationFeature.GetList
{
    public class GetDistributionListQuery : IRequest<DistributionList>
    {
        public NotificationDataDto NotificationData { get; set; } = new NotificationDataDto();
    }
}
