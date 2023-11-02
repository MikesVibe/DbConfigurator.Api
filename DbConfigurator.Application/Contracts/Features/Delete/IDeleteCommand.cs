using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Features.Delete
{
    public interface IDeleteCommand
    {
        public int Id { get; set; }
    }
}
