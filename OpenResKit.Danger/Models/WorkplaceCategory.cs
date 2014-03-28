using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Danger.Models
{
    public class WorkplaceCategory
    {
        public virtual int Id { get; set; }
        public virtual Category Category { get; set; }
        public virtual Workplace Workplace { get; set; }

    }
}
