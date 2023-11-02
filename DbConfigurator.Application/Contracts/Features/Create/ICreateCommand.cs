using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Features.Create
{
    public interface ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
