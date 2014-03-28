using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenResKit.Danger.Models
{
    public class Picture
    {
        public virtual int Id { get; set; }
        public virtual byte[] Pic { get; set; }
    }
}
