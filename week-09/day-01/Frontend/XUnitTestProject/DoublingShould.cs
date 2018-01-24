using Frontend;
using Frontend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class DoublingShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public DoublingShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnDoublingWithError()
        {
            var response = await client.GetAsync("api/doubling");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", json);
        }

        [Fact]
        public async Task ReturnDoublingWithNumber()
        {
            var response = await client.GetAsync("api/doubling?input=3");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":3,\"result\":6}", json);
        }

        [Fact]
        public async Task ReturnGreeterWithOutInput()
        {
            var response = await client.GetAsync("api/greeter");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a name!\"}", json);
        }

        [Fact]
        public async Task ReturnGreeterWithOutNameInput()
        {
            var response = await client.GetAsync("api/greeter?title=student");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a name!\"}", json);
        }

        [Fact]
        public async Task ReturnGreeterWithoutTitleInput()
        {
            var response = await client.GetAsync("api/greeter?name=Laci");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a title!\"}", json);
        }

        [Fact]
        public async Task ReturnWithInputs()
        {
            var response = await client.GetAsync("api/greeter?name=Laci&&title=student");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"welcome_message\":\"Oh, hi there Laci, my dear student!\"}", json);
        }

        [Fact]
        public async Task ReturnAppendableA()
        {
            var response = await client.GetAsync("api/appenda/kuty");
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"appended\":\"kutya\"}", json);
        }

        [Fact]
        public async Task ReturnAppendNotFound()
        {
            var response = await client.GetAsync("api/appenda");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task DoUntilNull()
        {
            var dountil = new DoUntil();            
            dountil.Until = null;

            var stringcontent = new StringContent(JsonConvert.SerializeObject(dountil),Encoding.UTF8, "application/json");

            var response = await client.PostAsync("api/dountil", stringcontent);
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a number!\"}", json);
        }

        [Fact]
        public async Task DoUntilSum()
        {
            var dountil = new DoUntil();
            dountil.Until = 2;

            var stringcontent = new StringContent(JsonConvert.SerializeObject(dountil), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/dountil/sum", stringcontent);
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"until\":2,\"result\":3}", json);
        }

        [Fact]
        public async Task DoUntilFactor()
        {
            var dountil = new DoUntil();
            dountil.Until = 2;

            var stringcontent = new StringContent(JsonConvert.SerializeObject(dountil), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/dountil/factor", stringcontent);
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"until\":2,\"result\":2}", json);
        }

        [Fact]
        public async Task DoUntilUnrelevantInput()
        {
            var dountil = new DoUntil();
            dountil.Until = 2;

            var stringcontent = new StringContent(JsonConvert.SerializeObject(dountil), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/dountil/something", stringcontent);
            string json = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
