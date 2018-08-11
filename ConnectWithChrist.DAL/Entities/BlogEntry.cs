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
        [Key]
        public int BlogEntryID { get; set; }

        [ForeignKey("Blog")]
        public int BlogID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual Blog Blog { get; set; }

        public override int GetPrimaryKey()
        {
            return this.BlogEntryID;
        }
    }
}
