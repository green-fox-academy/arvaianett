using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using PallidaRetake;
using PallidaRetake.Entities;
using PallidaRetake.Repositories;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ClothesTest
{
    public class WebshopShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public WebshopShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnWareHouseOk()
        {
            var response = await client.GetAsync("/warehouse");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnSummaryOk()
        {
            var response = await client.GetAsync("/warehouse/summary");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
