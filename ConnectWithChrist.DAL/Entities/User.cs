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
    public class User : NamedEntity
    {
        public User() : base()
        {
            this.Name = $"{this.FirstName} {this.LastName}";
        }

        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int UserTypeEnum { get; set; }

        public string PrimaryEmail { get; set; }

        public string MobileNumber { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("State")]
        public int StateID { get; set; }

        [NotMapped]
        [JsonProperty]
        public State State { get; set; }

        public override int GetPrimaryKey()
        {
            return this.UserID;
        }

    }
}
