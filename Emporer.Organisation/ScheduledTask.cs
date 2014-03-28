namespace OpenResKit.Organisation
{
  public class ScheduledTask
  {
    public virtual ResponsibleSubject AppointmentResponsibleSubject { get; set; }
    public virtual Appointment DueDate { get; set; }
    public virtual Appointment EntryDate { get; set; }
    public virtual ResponsibleSubject EntryResponsibleSubject { get; set; }
    public virtual int Id { get; set; }
    public virtual double Progress { get; set; }
  }
}