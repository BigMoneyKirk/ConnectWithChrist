using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Infrastructure
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class LinkInfo : NamedEntity
    {
        protected LinkInfo() : base()
        {
        }

        [JsonProperty]
        public string Link { get; set; }
    }
}
