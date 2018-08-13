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
    public class VerseOfDay : NamedEntity
    {
        public VerseOfDay() : base()
        {
        }

        [Key, Column(Order = 1)]
        public int VerseOfDayID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.VerseOfDayID;
        }
    }
}
