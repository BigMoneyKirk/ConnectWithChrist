using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Infrastructure
{
    public abstract class NamedEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
