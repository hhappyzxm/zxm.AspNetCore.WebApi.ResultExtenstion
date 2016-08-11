using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace zxm.AspNetCore.WebApi.ResultExtenstion.Tests.Fixture
{
    public class TestServerFixture : IDisposable
    {
        public TestServer Server { get; }

        public TestServerFixture()
        {
            var hostBuilder = new WebHostBuilder()
                .ConfigureServices(services => services.AddMvc())
                .Configure(app =>
                {
                    app.UseMvc();
                });

            Server = new TestServer(hostBuilder);
        }

        public void Dispose()
        {
            Server.Dispose();
        }
    }
}
