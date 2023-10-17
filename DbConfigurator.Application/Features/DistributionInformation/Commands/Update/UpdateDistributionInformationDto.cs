using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update
{
    public class UpdateDistributionInformationDto
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int PriorityId { get; set; }
        public ICollection<Recipient> RecipientsTo { get; set; } = new Collection<Recipient>();
        public ICollection<Recipient> RecipientsCc { get; set; } = new Collection<Recipient>();
    }
}
