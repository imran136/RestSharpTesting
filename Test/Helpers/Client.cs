using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace Test.Helpers
{
    public static class Client
    {
        public static IRestResponse SetValue(string userName, string passWord)
        {
            // Arrange
            var client = new RestClient("http://localhost:9100");
            client.Authenticator = new HttpBasicAuthenticator(userName, passWord);
            var request = new RestRequest("/table/bugs", Method.POST);
            request.AddJsonBody(new TokenRequest
            {
                id = 2,
                title = "this is a bug",
                summary = "Sample Bug",
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
            return response;
        }
    }
}
