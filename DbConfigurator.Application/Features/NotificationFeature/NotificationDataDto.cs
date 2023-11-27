using DbConfigurator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.NotificationFeature
{
    public class NotificationDataDto
    {
        public int PriorityValue { get; set; }
        public string GBU { get; set; } = string.Empty;
    }
}
