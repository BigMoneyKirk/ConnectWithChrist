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
    [JsonObject(MemberSerialization.OptIn)]
    public class FavoriteVerse : NamedEntity
    {
        public FavoriteVerse() : base()
        {
        }

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int FavoriteVerseID { get; set; }

        [ForeignKey("User")]
        [JsonProperty]
        public int UserID { get; set; }

        //[NotMapped]
        [JsonProperty]
        public virtual User User { get; set; }

        [JsonProperty]
        public string Comments { get; set; }

        public override int GetPrimaryKey()
        {
            return this.FavoriteVerseID;
        }
    }
}
