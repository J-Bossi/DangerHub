#region Licence

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0.html
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// Copyright (c) 2013, HTW Berlin

#endregion

using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using OpenResKit.DomainModel;

namespace OpenResKit.Organisation

{
  [Export(typeof (IInitialSeed))]
  public class InitialSeed: IInitialSeed
  {
    public void Seed(DbContext dbContext)
    {
      var employeegroup = new EmployeeGroup();
      employeegroup.Name = "Servicemitarbeiter";

      var employeeGroups = new List<EmployeeGroup>();
      employeeGroups.Add(employeegroup);

      var employee = new Employee();
      employee.FirstName = "Max";
      employee.LastName = "Mustermann";
      employee.Number = "Ab1234";
      employee.Groups = employeeGroups;

      dbContext.Set<ResponsibleSubject>()
               .Add(employee);
      dbContext.Set<ResponsibleSubject>()
               .Add(employeegroup);
      dbContext.SaveChanges();
    }
  }
}