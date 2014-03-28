using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenResKit.Organisation;

namespace OpenResKit.Danger.Models
{
    public class Surveytype
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Document SurveyTypeDocx { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
