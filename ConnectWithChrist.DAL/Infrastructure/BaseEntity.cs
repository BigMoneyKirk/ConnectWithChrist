using ConnectWithChrist.DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Infrastructure
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.IsActive = true;
            this.CreatedAt = DateTime.Now;
        }

        [Column(Order = 2)]
        [JsonProperty]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 3)]
        [JsonProperty]
        public DateTime? UpdatedAt { get; set; }

        [Column(Order = 4)]
        [JsonProperty]
        public DateTime? DeletedAt { get; set; }

        [Column(Order = 5)]
        [JsonProperty]
        public bool IsActive { get; set; }

        [ForeignKey("CreatedBy")]
        [JsonProperty]
        public int CreatedByID { get; set; }

        [NotMapped]
        public virtual User CreatedBy { get; set; }

        [ForeignKey("UpdatedBy")]
        [JsonProperty]
        public int UpdatedByID { get; set; }

        [NotMapped]
        public virtual User UpdatedBy { get; set; }

        [ForeignKey("DeletedBy")]
        [JsonProperty]
        public int DeletedByID { get; set; }

        [NotMapped]
        public virtual User DeletedBy { get; set; }

        public abstract int GetPrimaryKey();
    }
}
