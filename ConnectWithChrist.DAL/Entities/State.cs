using ConnectWithChrist.DAL.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Entities
{
    public class State : NamedEntity
    {
        [Key, Column(Order = 1)]
        [JsonProperty]
        public int StateID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.StateID;
        }
    }
}
