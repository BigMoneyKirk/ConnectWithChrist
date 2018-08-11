using ConnectWithChrist.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Entities
{
    public class State : NamedEntity
    {
        [Key]
        public int StateID { get; set; }

        public override int GetPrimaryKey()
        {
            return this.StateID;
        }
    }
}
