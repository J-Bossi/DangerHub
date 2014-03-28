using System;

namespace OpenResKit.Organisation
{
  public class Appointment
  {
    public virtual DateTime Begin { get; set; }
    public virtual DateTime End { get; set; }
		public virtual bool IsAllDay
		{
			get;
			set;
		}
    public virtual int Id { get; set; }
  }
}