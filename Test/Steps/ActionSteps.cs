using TechTalk.SpecFlow;
using Test.Helpers;

namespace Test.Steps
{
    [Binding]
    public class ActionSteps
    {
        [When(@"user makes an add query")]
        public void WhenUserMakesAnAddQuery()
        {
            var userName = ScenarioContext.Current.Get<string>(ScenarioConstants.ApiUserName);
            var userPassword = ScenarioContext.Current.Get<string>(ScenarioConstants.ApiUserPassword);

            var result = Client.SetValue(userName, userPassword);
            ScenarioContext.Current.Set(result, ScenarioConstants.ApiCallResult);
        }

    }
}
