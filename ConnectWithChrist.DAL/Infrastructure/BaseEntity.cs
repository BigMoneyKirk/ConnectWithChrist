using System;
using System.Collections.Generic;
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

        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public int DeletedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public abstract int GetPrimaryKey();
    }
}
