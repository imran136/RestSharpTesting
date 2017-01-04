using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using TechTalk.SpecFlow;
using RestSharp;
using System.Net;

namespace Test.Steps
{
    [Binding]
    public class ResultSteps
    {
        [Then(@"user should be able to add data")]
        public void ThenUserShouldBeAbleToAddData()
        {
            var result = ScenarioContext.Current.Get<IRestResponse>(ScenarioConstants.ApiCallResult);
            result.StatusCode.Should().Be(HttpStatusCode.Created);
        }

    }
}
