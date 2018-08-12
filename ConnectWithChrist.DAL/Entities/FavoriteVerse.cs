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
    public class FavoriteVerse : NamedEntity
    {
        [Key]
        [JsonProperty]
        public int FavoriteVerseID { get; set; }

        [ForeignKey("User")]
        [JsonProperty]
        public int UserID { get; set; }

        public string Comments { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual User User { get; set; }

        public override int GetPrimaryKey()
        {
            return this.FavoriteVerseID;
        }
    }
}
