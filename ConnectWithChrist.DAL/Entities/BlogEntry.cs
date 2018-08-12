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
    public class BlogEntry : LinkInfo
    {
        public BlogEntry() : base()
        {
        }

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int BlogEntryID { get; set; }

        [JsonProperty]
        [ForeignKey("Blog")]
        public int BlogID { get; set; }

        [JsonProperty]
        [NotMapped]
        public virtual Blog Blog { get; set; }

        public override int GetPrimaryKey()
        {
            return this.BlogEntryID;
        }
    }
}
