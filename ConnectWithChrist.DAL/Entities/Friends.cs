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
        [Key]
        public int FriendsID { get; set; }

        [ForeignKey("User")]
        public int Friend1ID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual User Friend1 { get; set; }

        [ForeignKey("User")]
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
