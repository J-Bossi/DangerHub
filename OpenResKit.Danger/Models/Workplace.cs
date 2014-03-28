using System;
using System.Collections.Generic;
using OpenResKit.Danger.Models;
namespace OpenResKit.Danger.Models
{
    public class Workplace
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameCompany { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual Surveytype SurveyType { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
