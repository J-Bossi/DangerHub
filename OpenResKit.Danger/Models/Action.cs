using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Danger.Models
{
    public class Action
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual string Execution { get; set; }
        public virtual bool Effect { get; set; }
    }
}
