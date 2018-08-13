using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Infrastructure
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class NamedEntity : BaseEntity
    {
        public NamedEntity()
        {
        }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Description { get; set; }
    }
}
