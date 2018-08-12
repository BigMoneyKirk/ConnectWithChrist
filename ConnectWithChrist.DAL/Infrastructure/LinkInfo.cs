using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Infrastructure
{
    public abstract class LinkInfo : NamedEntity
    {
        [JsonProperty]
        public string Link { get; set; }
    }
}
