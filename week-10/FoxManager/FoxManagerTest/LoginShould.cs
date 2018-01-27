using FoxManager;
using FoxManager.Entities;
using FoxManager.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FoxManagerTest
{
    public class LoginShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public LoginShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnCreatedStatus()
        {
            var options = new DbContextOptionsBuilder<FoxContext>().UseInMemoryDatabase("database").Options;

            using (var context = new FoxContext(options))
            {
                var repository = new LoginRepository(context);
                repository.AddStudent("Laci", "fox");

                var studentCount = await context.Students.CountAsync();
                Assert.Equal(1, studentCount);
            }
        }
    }
}
