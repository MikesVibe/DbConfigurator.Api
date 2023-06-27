﻿using DbConfigurator.Api.Models;

namespace DbConfigurator.Model.Entities.Core
{
    public class RecipientGroupCc
    {
        public int RecipientId { get; set; }
        public Recipient Recipient { get; set; }
        public int DistributionInformationId { get; set; }
        public DistributionInformation RecipientGroup { get; set; }
    }
}
