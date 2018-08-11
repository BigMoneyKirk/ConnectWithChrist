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
    public class JournalEntry : NamedEntity
    {
        [Key]
        public int JournalEntryID { get; set; }

        [ForeignKey("Journal")]
        public int JournalID { get; set; }

        [NotMapped]
        [JsonProperty]
        public Journal Journal { get; set; }

        public override int GetPrimaryKey()
        {
            return this.JournalEntryID;
        }
    }
}
