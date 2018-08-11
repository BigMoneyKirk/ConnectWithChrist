using ConnectWithChrist.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Entities
{
    public class Friends : BaseEntity
    {
        [Key]
        public int FriendsID { get; set; }

        [ForeignKey("User")]
        public int Friend1 { get; set; }

        [ForeignKey("User")]
        public int Friend2 { get; set; }

        public override int GetPrimaryKey()
        {
            return this.FriendsID;
        }
    }
}
