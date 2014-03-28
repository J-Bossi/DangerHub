using System.Collections.Generic;

namespace OpenResKit.Danger.Models
{
  public class Company
  {
    public virtual string Adress { get; set; }
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual ICollection<Person> Persons { get; set; }
    public virtual string Telephone { get; set; }
    public virtual string TypeOfBusiness { get; set; }
    public virtual ICollection<Workplace> Workplaces { get; set; }
  }
}