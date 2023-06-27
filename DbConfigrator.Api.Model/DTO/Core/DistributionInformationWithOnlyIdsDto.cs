﻿using DbConfigurator.Api.Services;

namespace DbConfigurator.Model.DTOs.Core
{
    public class DistributionInformationWithOnlyIdsDto : IEntityDto
    {
        public int Id { get; }
        public int AreaId { get; set; }
        public int BuisnessUnitId { get; set; }
        public int CountryId { get; set; }
        public int PriorityId { get; set; }
        public int RecipientsGroupId { get; set; }
    }
}