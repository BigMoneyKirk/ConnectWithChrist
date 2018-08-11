using ConnectWithChrist.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Entities
{
    public class GodlyLink : LinkInfo
    {
        [Key]
        public int GodlyLinkID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.GodlyLinkID;
        }
    }
}
