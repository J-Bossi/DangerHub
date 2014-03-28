using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml.Drawing;
using OpenResKit.DomainModel;
using OpenResKit.Danger.Models;
using Picture = OpenResKit.Danger.Models.Picture;

namespace OpenResKit.Danger
{
    [Export(typeof(IInitialSeed))]
    public class InitialSeed : IInitialSeed
    {
        public readonly ModelFactory m_ModelFactory;

        [ImportingConstructor]
        public InitialSeed([Import] ModelFactory modelFactory)
        {
            m_ModelFactory = modelFactory;
        }

        public void Seed(DbContext dbContext)
        {

            var assembly = Assembly.GetExecutingAssembly();

            var stream = assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild1.jpg");
            var pictest = ModelFactory.CreatePicture(stream);

            var pic1 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild1.jpg"));
            var pic2 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild2.jpg"));
            var pic3 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild3.jpg"));
            var pic4 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild4.jpg"));
            var pic5 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild1.jpg"));
            var pic6 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild2.jpg"));
            var pic7 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild3.jpg"));
            var pic8 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild4.jpg"));
            var pic9 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild1.jpg"));
            var pic10 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild2.jpg"));
            var pic11 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild3.jpg"));
            var pic12 = ModelFactory.CreatePicture(assembly.GetManifestResourceStream("OpenResKit.Danger.Resources.bild4.jpg"));

            SurveyParser sp = new SurveyParser();
            Surveytype st = sp.GenerateSurvey(dbContext);

            var a1 = new Activity() { Name = "Wartung" };
            var a2 = new Activity() { Name = "Drehen" };
            var a3 = new Activity() { Name = "Wartung" };
            var a4 = new Activity() { Name = "Fräsen" };
            var a5 = new Activity() { Name = "Wartung" };
            var a6 = new Activity() { Name = "Schweißen" };

            var person1 = m_ModelFactory.CreatePerson("Hans Jürger Otto");
            var person2 = m_ModelFactory.CreatePerson("Felix Johann Micha von Peterson");
            var person3 = m_ModelFactory.CreatePerson("Herr Prof. Dr. v. Müller");

            List<Person> personlist1 = new List<Person>();
            List<Person> personlist2 = new List<Person>();
            List<Person> personlist3 = new List<Person>();

            personlist1.Add(person1);

            personlist2.Add(person2);

            personlist3.Add(person3);

            dbContext.Set<Activity>().Add(a1);
            dbContext.Set<Activity>().Add(a2);
            dbContext.Set<Activity>().Add(a3);
            dbContext.Set<Activity>().Add(a4);
            dbContext.Set<Activity>().Add(a5);
            dbContext.Set<Activity>().Add(a6);

            var w1Activities = new Collection<Activity>();
            w1Activities.Add(a1);
            w1Activities.Add(a2);
            var w2Activities = new Collection<Activity>();
            w2Activities.Add(a3);
            w2Activities.Add(a4);
            var w3Activities = new Collection<Activity>();
            w3Activities.Add(a5);
            w3Activities.Add(a6);

            var pg1 = new ProtectionGoal() { Description = "Verhinderung von Körperschäden" };
            var pg2 = new ProtectionGoal() { Description = "Verhinderung von Stürzen" };
            var pg3 = new ProtectionGoal() { Description = "Verhinderung von Explosionen" };

            dbContext.Set<ProtectionGoal>().Add(pg1);
            dbContext.Set<ProtectionGoal>().Add(pg2);
            dbContext.Set<ProtectionGoal>().Add(pg3);

            List<ProtectionGoal> progoallist = new List<ProtectionGoal>();
            progoallist.Add(pg1);
            progoallist.Add(pg2);
            progoallist.Add(pg3);

            var pg4 = new ProtectionGoal() { Description = "Sicherstellung der erfordelichen Kenntnisse" };
            var pg5 = new ProtectionGoal() { Description = "Arbeitsmedizinische Vorsorge" };
            var pg6 = new ProtectionGoal() { Description = "Verhinderung von Beschädigungen" };

            dbContext.Set<ProtectionGoal>().Add(pg4);
            dbContext.Set<ProtectionGoal>().Add(pg5);
            dbContext.Set<ProtectionGoal>().Add(pg6);

            List<ProtectionGoal> progoallist2 = new List<ProtectionGoal>();
            progoallist.Add(pg4);
            progoallist.Add(pg5);
            progoallist.Add(pg6);

            var pg7 = new ProtectionGoal() { Description = "Vermeidung von Verletzungen und Fehlbedienung" };
            var pg8 = new ProtectionGoal() { Description = "Vermeidung von Verletzungs- und Stolperquellen" };
            var pg9 = new ProtectionGoal() { Description = "Vermeidung von Sturzunfällen" };

            dbContext.Set<ProtectionGoal>().Add(pg7);
            dbContext.Set<ProtectionGoal>().Add(pg8);
            dbContext.Set<ProtectionGoal>().Add(pg9);


            List<ProtectionGoal> progoallist3 = new List<ProtectionGoal>();
            progoallist.Add(pg7);
            progoallist.Add(pg8);
            progoallist.Add(pg9);


            OpenResKit.Danger.Models.Action action1 = new OpenResKit.Danger.Models.Action() { Description = "Versetzen des Handhebels aus Bediengang", Person = person1, DueDate = DateTime.Now, Execution = "Fortlaufend",Effect = true};
            OpenResKit.Danger.Models.Action action2 = new OpenResKit.Danger.Models.Action() { Description = "Vergießen der Anker mit Beton ggf. Einkürzen", Person = person1, DueDate = DateTime.Now, Effect = false, Execution = "Fortlaufend" };
            OpenResKit.Danger.Models.Action action3 = new OpenResKit.Danger.Models.Action() { Description = "statischer Nachweis für den Behälter im Ruhe- und Belastungsfall", Person = person1, DueDate = DateTime.Now, Effect = true, Execution = "Fortlaufend" };

            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action1);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action2);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action3);

            List<OpenResKit.Danger.Models.Action> actionlist = new List<OpenResKit.Danger.Models.Action>();
            actionlist.Add(action1);
            actionlist.Add(action2);
            actionlist.Add(action3);


            OpenResKit.Danger.Models.Action action4 = new OpenResKit.Danger.Models.Action() { Description = "Herstellung eines Gefälles zur Sammelrinne", Person = person1, DueDate = DateTime.Now, Effect = true, Execution = "Fortlaufend" };
            OpenResKit.Danger.Models.Action action5 = new OpenResKit.Danger.Models.Action() { Description = "Kennzeichung möglicher Stolperkanten,geeignete Verlegung betriebsnotwendiger Schlauchverbindungen", Person = person1, DueDate = DateTime.Now, Effect = true, Execution = "Fortlaufend" };
            OpenResKit.Danger.Models.Action action6 = new OpenResKit.Danger.Models.Action() { Description = "Installation geeigneter Bedienpodeste", Person = person1, DueDate = DateTime.Now, Effect = false, Execution = "Fortlaufend" };

            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action4);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action5);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action6);

            List<OpenResKit.Danger.Models.Action> actionlist2 = new List<OpenResKit.Danger.Models.Action>();
            actionlist.Add(action4);
            actionlist.Add(action5);
            actionlist.Add(action6);


            OpenResKit.Danger.Models.Action action7 = new OpenResKit.Danger.Models.Action() { Description = "Umrüstung von der mobilen Befüllanlage auf eine fest installierte Befüllanlage vom NaOH-Vorratsbehälter", Person = person1, DueDate = DateTime.Now, Effect = false, Execution = "Fortlaufend" };
            OpenResKit.Danger.Models.Action action8 = new OpenResKit.Danger.Models.Action() { Description = "Gewährleistung aller Anforderungen nach WHG und VAwS (Ausführung, Anzeige, Eignungsfeststellung", Person = person1, DueDate = DateTime.Now, Effect = true, Execution = "Fortlaufend" };
            OpenResKit.Danger.Models.Action action9 = new OpenResKit.Danger.Models.Action() { Description = "Kennzeichnung, Betriebsanweisung nach VAwS", Person = person1, DueDate = DateTime.Now, Effect = true, Execution = "Fortlaufend" };

            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action7);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action8);
            dbContext.Set<OpenResKit.Danger.Models.Action>().Add(action9);

            List<OpenResKit.Danger.Models.Action> actionlist3 = new List<OpenResKit.Danger.Models.Action>();
            actionlist.Add(action7);
            actionlist.Add(action8);
            actionlist.Add(action9);

            List<Picture> piclist = new List<Picture>();
            piclist.Add(pic1);
            piclist.Add(pic2);
            piclist.Add(pic3);
            piclist.Add(pic4);

            List<Picture> piclist2 = new List<Picture>();
            piclist2.Add(pic5);
            piclist2.Add(pic6);
            piclist2.Add(pic7);
            piclist2.Add(pic8);

            List<Picture> piclist3 = new List<Picture>();
            piclist3.Add(pic9);
            piclist3.Add(pic10);
            piclist3.Add(pic11);
            piclist3.Add(pic12);

           

            Threat threat1 = new Threat() { GFactor = st.Categories.First().GFactors.ElementAt(0), Dangerpoint = st.Categories.First().GFactors.ElementAt(0).Dangerpoints.First(), Description = "Quetschstellen", RiskDimension = 1, RiskPossibility = 1, Status = "0" ,Actionneed = false, Pictures = piclist, Activity = a1, ProtectionGoals = progoallist, Actions = actionlist};

            Threat threat2 = new Threat() { Description = "Ecken, Kanten", RiskDimension = 2, RiskPossibility = 3,Dangerpoint = st.Categories.First().GFactors.ElementAt(2).Dangerpoints.First(), GFactor = st.Categories.First().GFactors.ElementAt(2), Status = "0", Actionneed = true, Pictures = piclist2, Activity = a2, ProtectionGoals = progoallist2, Actions = actionlist2 };

            Threat threat3 = new Threat() { Description = "Anfahren, Aufprallen", RiskDimension = 2, RiskPossibility = 1, GFactor = st.Categories.First().GFactors.ElementAt(1),Dangerpoint = st.Categories.First().GFactors.ElementAt(1).Dangerpoints.First(), Status = "0", Actionneed = true, Pictures = piclist3, Activity = a2, ProtectionGoals = progoallist3, Actions = actionlist3 };

            //Threat threat4 = new Threat() { Description = "Desc UZ", RiskDimension = 2, RiskPossibility = 1, GFactor = st.Categories.First().GFactors.ElementAt(1), Status = "0", Actionneed = true, Pictures = piclist3 };

            //Threat threat5 = new Threat() { Description = "Desc UZ", RiskDimension = 2, RiskPossibility = 1, GFactor = st.Categories.First().GFactors.ElementAt(1), Status = "0", Actionneed = true, Pictures = piclist3 };


            List<Threat> threatlist = new List<Threat>();
            threatlist.Add(threat1);
            threatlist.Add(threat2);

            List<Threat> threatlist2 = new List<Threat>();
            threatlist.Add(threat3);
            //threatlist.Add(threat4);

            //List<Threat> threatlist3 = new List<Threat>();
            //threatlist.Add(threat5);

            //List<Threat> threatlist2 = new List<Threat>();
            //threatlist2.Add(threat1);
            //threatlist2.Add(threat2);
            //threatlist2.Add(threat3);

            //List<Threat> threatlist3 = new List<Threat>();
            //threatlist3.Add(threat1);
            //threatlist3.Add(threat2);
            //threatlist3.Add(threat3);

            //List<Threat> threatlist4 = new List<Threat>();
            //threatlist4.Add(threat1);
            //threatlist4.Add(threat2);
            //threatlist4.Add(threat3);

            //List<Threat> threatlist5 = new List<Threat>();
            //threatlist5.Add(threat1);
            //threatlist5.Add(threat2);
            //threatlist5.Add(threat3);
         
//_________________________________________________________

            List<Threat> threatsTest = new List<Threat>();

            foreach (var category in st.Categories)
            {
                foreach (var gfactor in category.GFactors)
                {
                    threatsTest.Add(m_ModelFactory.CreateThreat("Test", 1, 2, true, "1", gfactor, null, null, null, a4));
                }
            }


            //foreach (var gfactorHelper in st.)
            //{
            //    threatsTest.Add(m_ModelFactory.CreateThreat("0", new GFactor(){Name = gfactorHelper.Name}, "resr"));
            //}


            var w1Assessment1 = m_ModelFactory.CreateAssessment(new DateTime(2010, 5, 3), 0, person1, threatlist);
            var w1Assessment2 = m_ModelFactory.CreateAssessment(new DateTime(2008, 3, 5), 1, person1, threatlist2);
            var w2Assessment1 = m_ModelFactory.CreateAssessment(new DateTime(2012, 3, 1), 2, person1, threatsTest);
            var w3Assessment1 = m_ModelFactory.CreateAssessment(new DateTime(2013, 4, 9), 0, person2, null);
            var w4Assessment1 = m_ModelFactory.CreateAssessment(new DateTime(2009, 5, 12), 1, person2, null);


            var w1AssessmentCollection = new Collection<Assessment>();
            w1AssessmentCollection.Add(w1Assessment1);
            w1AssessmentCollection.Add(w1Assessment2);
            var w2AssessmentCollection = new Collection<Assessment>();
            w2AssessmentCollection.Add(w2Assessment1);
            var w3AssessmentCollection = new Collection<Assessment>();
            w3AssessmentCollection.Add(w3Assessment1);
            var w4AssessmentCollection = new Collection<Assessment>();
            w4AssessmentCollection.Add(w4Assessment1);

            var workplace1 = m_ModelFactory.CreateWorkplace("Drehmaschine", "DM1", "detaillierte Beschreibung", w1Activities, st, person1, w1AssessmentCollection);
            var workplace2 = m_ModelFactory.CreateWorkplace("Fräsmaschine", "FM7", "Fräsmaschine FM3000", w2Activities, st, person1, w2AssessmentCollection);
            var workplace3 = m_ModelFactory.CreateWorkplace("Schweißgerät", "MAG", "MAG-Schweißer", w3Activities, st, person2, w3AssessmentCollection);
            var workplace4 = m_ModelFactory.CreateWorkplace("Drehmaschine", "DM2", "Die spezifische Beschreibung", null, st, person2, w4AssessmentCollection);
            var workplace5 = m_ModelFactory.CreateWorkplace("Fräsmaschine", "FM8", "Schweißverfahren 37", null, st, person3, null);
            var workplace6 = m_ModelFactory.CreateWorkplace("Schweißgerät", "MAG2", "MAG-Schweißer", null, st, person3, null);
                
            List<Workplace> listeworkplaces1 = new List<Workplace>();
            List<Workplace> listeworkplaces2 = new List<Workplace>();
            List<Workplace> listeworkplaces3 = new List<Workplace>();

            listeworkplaces1.Add(workplace1);
            listeworkplaces1.Add(workplace2);
            listeworkplaces2.Add(workplace3);
            listeworkplaces2.Add(workplace4);
            listeworkplaces3.Add(workplace5);
            listeworkplaces3.Add(workplace6);




            var company1 = m_ModelFactory.CreateCompany("Metal-Unternehmen", "Musteradresse", "01", "Metalindustrie", listeworkplaces1, personlist1);
            var company2 = m_ModelFactory.CreateCompany("Chemie-Unternehmen", "Testadresse", "02", "Chemieindustrie", listeworkplaces2, personlist2);
            var company3 = m_ModelFactory.CreateCompany( "Pharma-Unternehmen", "ProbierAdresse", "03", "Pharmeindustrie", listeworkplaces3, personlist3);
           
            dbContext.Set<Workplace>().Add(workplace1);
            dbContext.Set<Workplace>().Add(workplace2);
            dbContext.Set<Workplace>().Add(workplace3);
            dbContext.Set<Workplace>().Add(workplace4);
            dbContext.Set<Workplace>().Add(workplace5);
            dbContext.Set<Workplace>().Add(workplace6);

            dbContext.Set<Company>().Add(company1);
            dbContext.Set<Company>().Add(company2);
            dbContext.Set<Company>().Add(company3);

            dbContext.Set<Assessment>()
                .Add(w1Assessment1);
            dbContext.Set<Assessment>()
                .Add(w1Assessment2);
            dbContext.Set<Assessment>()
                .Add(w2Assessment1);
            dbContext.Set<Assessment>()
                .Add(w3Assessment1);
            dbContext.Set<Assessment>()
                .Add(w4Assessment1);

            dbContext.Set<Person>().Add(person1);
            dbContext.Set<Person>().Add(person2);
            dbContext.Set<Person>().Add(person3);

            dbContext.SaveChanges();
        }
    }
}
