using ConnectWithChrist.DAL.Enums;
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

        [Key, Column(Order = 1)]
        [JsonProperty]
        public int UserID { get; set; }

        [Required]
        [MaxLength(20)]
        [JsonProperty]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(40)]
        [JsonProperty]
        public string LastName { get; set; }

        [Required]
        [JsonProperty]
        public virtual UserType UserTypeEnum { get; set; }

        [Required]
        [JsonProperty]
        public string PrimaryEmail { get; set; }

        [JsonProperty]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(20)]
        [JsonProperty]
        public string Username { get; set; }

        [Required]
        [JsonProperty]
        public string Password { get; set; }

        [JsonProperty]
        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("State")]
        [JsonProperty]
        public int StateID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual State State { get; set; }

        [ForeignKey("Job")]
        [JsonProperty]
        public int? FavortieJobID { get; set; }

        [NotMapped]
        [JsonProperty]
        public virtual Job FavoriteJob { get; set; }

        public override int GetPrimaryKey()
        {
            return this.UserID;
        }

    }
}
