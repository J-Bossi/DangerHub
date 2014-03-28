using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Danger.Models
{
    public class Threat
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual int RiskDimension { get; set; }
        public virtual int RiskPossibility { get; set; }
        public virtual bool Actionneed { get; set; }
        public virtual string Status { get; set; }
        public virtual GFactor GFactor { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<ProtectionGoal> ProtectionGoals { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual Dangerpoint Dangerpoint { get; set; }

    }
}
