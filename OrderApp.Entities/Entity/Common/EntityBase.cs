using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Entities.Entity.Common
{
    public class EntityBase
    {
        public int Id { get; set; }

        private DateTime _createdDate;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = DateTime.Now; }
        }

        public Boolean Status { get; set; }
    }
}
