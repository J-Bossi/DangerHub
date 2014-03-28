using System;
using System.Collections.Generic;

namespace OpenResKit.Danger.Models
{
    public class Assessment
    {
        public virtual int Id { get; set; }
        public virtual DateTime AssessmentDate { get; set; }
        public virtual ICollection<Threat> Threats { get; set; }
        public virtual Person EvaluatingPerson { get; set; }
        public virtual int Status { get; set; }
        
        internal Status StatusEnum
        {
            get { return (Status) Status; }
            set
            {
                if ((Status != (int) value))
                {
                    Status = (int) value;
                }
            }
        }
    }
}
