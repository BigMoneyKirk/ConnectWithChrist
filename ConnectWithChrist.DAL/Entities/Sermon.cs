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
    public class Sermon : LinkInfo
    {
        public Sermon() : base()
        {
        }

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int SermonID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.SermonID;
        }
    }
}
