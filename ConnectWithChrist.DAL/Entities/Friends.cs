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
    public class Friends : BaseEntity
    {
        public Friends() : base()
        {
        }

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int FriendsID { get; set; }

        [ForeignKey("Friend1")]
        [JsonProperty]
        public int Friend1ID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual User Friend1 { get; set; }

        [ForeignKey("Friend2")]
        [JsonProperty]
        public int Friend2ID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual User Friend2 { get; set; }

        public override int GetPrimaryKey()
        {
            return this.FriendsID;
        }
    }
}
