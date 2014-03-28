using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Danger.Models
{
    public class GFactor
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Number { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Dangerpoint> Dangerpoints { get; set; }
    }


}
