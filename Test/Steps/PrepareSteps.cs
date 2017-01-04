using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Test.Steps
{
    [Binding]
    public class PrepareSteps
    {
        [Given(@"user has following credentials")]
        public void GivenUserHasFollowingCredentials(Table userTable)
        {
            ScenarioContext.Current.Set(userTable.Rows[0]["username"], ScenarioConstants.ApiUserName);
            ScenarioContext.Current.Set(userTable.Rows[0]["password"], ScenarioConstants.ApiUserPassword);            
        }

    }
}
