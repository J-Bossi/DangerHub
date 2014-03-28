using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporer.Organisation
{
	public class EmployeeTypeAmount
	{
		public virtual int Id
		{
			get;
			set;
		}

		public virtual EmployeeType EmployeeType
		{
			get;
			set;
		}

		public virtual int Amount
		{
			get;
			set;
		}
	}
}
