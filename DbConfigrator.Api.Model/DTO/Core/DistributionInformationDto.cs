﻿using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;

namespace DbConfigurator.Model.DTOs.Core
{
    public class DistributionInformationDto : IEntityDto
    {
        public int Id { get; init; }

        public RegionDto Region { get; set; }
        public PriorityDto Priority { get; set; }
        public ObservableCollection<RecipientDto> RecipientsTo { get; set; } = new ObservableCollection<RecipientDto>();
        public ObservableCollection<RecipientDto> RecipientsCc { get; set; } = new ObservableCollection<RecipientDto>();
    }
}
