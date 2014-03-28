using System;
using System.Collections.Generic;

namespace OpenResKit.Organisation
{
	public class Series
	{
		public virtual DateTime Begin { get; set; }
		public virtual int Cycle { get; set; }
		public virtual DateTime End { get; set; }
		public virtual bool EndsWithDate { get; set; }
		public virtual int Id { get; set; }
		public virtual bool IsAllDay { get; set; }
		public virtual bool IsWeekdayRecurrence { get; set; }
		public virtual string Name { get; set; }
		public virtual int NumberOfRecurrences { get; set; }
		public virtual int RecurrenceInterval { get; set; }
		public virtual bool Repeat { get; set; }
		public virtual DateTime RepeatUntilDate { get; set; }
		public virtual SeriesColor SeriesColor { get; set; }
		public virtual ICollection<DayOfWeek> WeekDays { get; set; }

		internal CyclePeriod CycleEnum
		{
			get
			{
				return (CyclePeriod) Cycle;
			}
			set
			{
				if ((Cycle != (int) value))
				{
					Cycle = (int) value;
				}
			}
		}
	}
}