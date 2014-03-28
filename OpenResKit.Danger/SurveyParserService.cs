using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenResKit.Danger.Models;
using OpenResKit.ODataHost;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ServiceModel;
using OpenResKit.DomainModel;

namespace OpenResKit.Danger
{
  [ExportMetadata("Name", "SurveyParserService")]
  [Export(typeof(IWCFService))]
  [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single)]
  [ServiceContract]
  internal class SurveyParserService : IWCFService
  {
    private readonly Func<DomainModelContext> m_CreateContext;
    private readonly DomainModelContext m_Context;

    [ImportingConstructor]
    public SurveyParserService([Import] Func<DomainModelContext> createContext)
    {
      m_CreateContext = createContext;
      m_Context = m_CreateContext();
    }

    [OperationContract]
    public void GenerateSurvey(int surveyTypeId)
    {
      using (var context = m_CreateContext())
      {
        var surveyType = context.Set<Surveytype>()
          .Single(cf => cf.Id == surveyTypeId);
        var surveyParser = new SurveyParser();
        surveyParser.GenerateSurvey(m_Context, surveyType);
          
        context.SaveChanges();
      }
    }
  }
}
