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
    public class Journal : NamedEntity
    {
        [Key]
        public int JournalID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual User User { get; set; }

        public override int GetPrimaryKey()
        {
            throw new NotImplementedException();
        }
    }
}
