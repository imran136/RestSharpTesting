using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using FluentAssertions;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class TestNG
    {
        [Test]
        public void SetValue()
        {
            // Arrange
            var client = new RestClient("http://localhost:9100");
            client.Authenticator = new HttpBasicAuthenticator("shantonu", "123456");            
            var request = new RestRequest("/table/bugs", Method.POST);
            request.AddJsonBody(new TokenRequest
            {
                id = 2,
                title = "this is a bug",
                summary = "Sample Bug" ,
                exceptions = "Exception Is not present",
                comments = "Comments ",
                foundDateTime = "1st december",
                tags = "New, On production",
                priority = "High",
                servility = "Blockered",
                attachmentPath = "http://",
                description = "Sampel Data "
            });


            // Act
            var response = client.Execute<TokenRequest>(request);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);            
        }

        [Test]
        public void GetValue()
        {
            // Arrange
            var client = new RestClient("http://localhost:9100");
            client.Authenticator = new HttpBasicAuthenticator("shantonu", "123456");
            var request = new RestRequest("/table/bugs", Method.GET);
            
            // Act
            var response = client.Execute<List<TokenRequest>>(request);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }

    
}
