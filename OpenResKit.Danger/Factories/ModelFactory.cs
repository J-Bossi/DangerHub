using System.IO;
using OpenResKit.Danger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Collections.ObjectModel;

namespace OpenResKit.Danger
{
    [Export]
    public class ModelFactory
    {
        public ModelFactory()
        {
            
        }

        public Company CreateCompany( string companyName, string companyAdress, string companyTelephone, string companyTypeOfBusiness, List <Workplace> companyWorkplace, List<Person> companyPerson)
        {
            return new Company { 
                                 Name = companyName,
                                 Adress = companyAdress,
                                 Telephone = companyTelephone,
                                 TypeOfBusiness = companyTypeOfBusiness,
                                 Workplaces=companyWorkplace,
                                 Persons=companyPerson
                               };
        }

        public Workplace CreateWorkplace(string name, string companyname, string description,  Collection<Activity> activities, Surveytype surveytype, Person evaluatingPerson, Collection<Assessment> assessments )
        {
            return new Workplace { 
                                    Name=name,
                                    NameCompany=companyname,
                                    Description=description,
                               
                                    Activities = activities,
                                    SurveyType = surveytype,
                                    Assessments = assessments
                                };
        }

        public Person CreatePerson(string name) 
        {
            return new Person
            {
                Name = name
            };
        }

        public Question CreateQuestion( string questionName) 
        {
            return new Question {  QuestionName = questionName };
        }

        public Dangerpoint CreateDpoint(string dpointName)
        {
            return new Dangerpoint { Name = dpointName };
        }

        public Category CreateCategory( string categoryName, List<GFactor> gfactors)
        {
            return new Category { Name = categoryName, GFactors = gfactors };
        }

        public GFactor CreateGFactor(string name, string number, List<Question> questions, List<Dangerpoint> dpoints)
        {
            return new GFactor {Name = name, Number = number, Questions = questions, Dangerpoints = dpoints};
        }

        public Surveytype CreateSurveytype(string name, List<Category> categories)
        {
            return new Surveytype {Name = name, Categories = categories};
        }

        public Picture CreatePicture(byte[] pic)
        {
            return new Picture { Pic = pic};
        }

        public Threat CreateThreat(string description, int riskdimension, int riskpos, bool actionneed, string status, GFactor gfactors, List<Picture> pics, List<ProtectionGoal> progoals, List<OpenResKit.Danger.Models.Action> actions, Activity activity)
        {
            return new Threat { Description = description, RiskDimension = riskdimension, RiskPossibility = riskpos, Actionneed = actionneed, Status = status, GFactor = gfactors, Pictures = pics, ProtectionGoals = progoals, Actions = actions, Activity = activity};
        }

        public Assessment CreateAssessment(DateTime date, int status, Person person, List<Threat> threat)
        {
            return new Assessment {AssessmentDate = date, Status = status, EvaluatingPerson = person, Threats = threat};
        }

        public static Picture CreatePicture( Stream imageStream)
        {
            byte[] byteArray;
            using (var br = new BinaryReader(imageStream))
            {
                byteArray = br.ReadBytes((int)imageStream.Length);
            }

            return new Picture
            {Pic = byteArray};
        }
    }
}
