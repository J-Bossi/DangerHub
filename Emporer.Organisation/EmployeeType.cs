using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporer.Organisation
{
	public class EmployeeType
	{
		public virtual int Id
		{
			get;
			set;
		}
		public virtual string Name
		{
			get;
			set;
		}
		public virtual double Wage
		{
			get;
			set;
		}
		public virtual Emporer.Unit.Unit TimeUnit
		{
			get;
			set;
		}
		public virtual string Currency
		{
			get;
			set;
		}
	}
}
