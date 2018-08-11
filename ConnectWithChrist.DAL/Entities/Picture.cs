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
    public class Picture : NamedEntity
    {
        [Key]
        public int PictureID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [NotMapped]
        [JsonProperty]
        public User User { get; set; }

        public string File { get; set; }

        public override int GetPrimaryKey()
        {
            return this.PictureID;
        }
    }
}
