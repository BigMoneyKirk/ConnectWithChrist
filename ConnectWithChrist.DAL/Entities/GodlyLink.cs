using ConnectWithChrist.DAL.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Entities
{
    public class GodlyLink : LinkInfo
    {
        [Key]
        [JsonProperty]
        public int GodlyLinkID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.GodlyLinkID;
        }
    }
}
