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
    public class JournalEntry : NamedEntity
    {
        public JournalEntry() : base()
        {
        }

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int JournalEntryID { get; set; }

        [ForeignKey("Journal")]
        [JsonProperty]
        public int JournalID { get; set; }

        //[NotMapped]
        [JsonProperty]
        public virtual Journal Journal { get; set; }

        public override int GetPrimaryKey()
        {
            return this.JournalEntryID;
        }
    }
}
