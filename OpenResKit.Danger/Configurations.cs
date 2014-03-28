using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.Danger.Models;
using OpenResKit.DomainModel;

namespace OpenResKit.Danger
{
  [Export(typeof (IDomainEntityConfiguration))]
  public class ActionConfiguration: EntityTypeConfiguration<Action>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class AssessmentConfiguration: EntityTypeConfiguration<Assessment>, IDomainEntityConfiguration
  {
    public AssessmentConfiguration()
    {
      HasMany(m => m.Threats)
       .WithOptional()
        .WillCascadeOnDelete();

    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class CategoryConfiguration: EntityTypeConfiguration<Category>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class CompanyConfiguration: EntityTypeConfiguration<Company>, IDomainEntityConfiguration
  {
    public CompanyConfiguration()
    {
      
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class GFactorConfiguration: EntityTypeConfiguration<GFactor>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }


  [Export(typeof (IDomainEntityConfiguration))]
  public class PersonConfiguration: EntityTypeConfiguration<Person>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class PictureConfiguration: EntityTypeConfiguration<Picture>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ProtectionGoalConfiguration: EntityTypeConfiguration<ProtectionGoal>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class QuestionConfiguration: EntityTypeConfiguration<Question>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class SurveytypeConfiguration: EntityTypeConfiguration<Surveytype>, IDomainEntityConfiguration
  {
    public SurveytypeConfiguration()
    {
      HasOptional(m => m.SurveyTypeDocx)
        .WithRequired()
        .WillCascadeOnDelete();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ThreatConfiguration: EntityTypeConfiguration<Threat>, IDomainEntityConfiguration
  {
    public ThreatConfiguration()
    {
      HasMany(m => m.Actions)
        .WithOptional()
        .WillCascadeOnDelete();
      HasMany(m => m.Pictures)
       .WithOptional()
        .WillCascadeOnDelete();
      HasMany(m => m.ProtectionGoals)
       .WithOptional()
        .WillCascadeOnDelete();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class WorkplaceConfigurations: EntityTypeConfiguration<Workplace>, IDomainEntityConfiguration
  {
    public WorkplaceConfigurations()
    {
      HasMany(m => m.Activities)
        .WithOptional()
        .WillCascadeOnDelete();
      HasMany(m => m.Assessments).WithOptional().WillCascadeOnDelete();
    }

    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class WorkplaceCategoryConfiguration: EntityTypeConfiguration<WorkplaceCategory>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class DangerpointsConfiguration: EntityTypeConfiguration<Dangerpoint>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class ActivityConfiguration: EntityTypeConfiguration<Activity>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
}