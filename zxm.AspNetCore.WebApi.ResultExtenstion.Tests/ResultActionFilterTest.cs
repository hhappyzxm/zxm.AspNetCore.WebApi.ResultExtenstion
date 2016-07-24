﻿using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using zxm.AspNetCore.WebApi.ResultExtenstion.Tests.Fixture;

namespace zxm.AspNetCore.WebApi.ResultExtenstion.Tests
{
    public class ResultActionFilterTest : IClassFixture<TestServerFixture>
    {
        private readonly TestServer _server;

        public ResultActionFilterTest(TestServerFixture fixture)
        {
            _server = fixture.Server;
        }

        [Fact]
        public async Task TestActionSuccessed()
        {
            var response = await _server.CreateRequest("api/test").SendAsync("GET");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WebApiResult>(content);

            // Assert
            Assert.IsType<WebApiResult>(result);
            Assert.Equal(result.Successed, true);
            Assert.Equal(result.Value.ToString(), "Get is ok");
        }

        [Fact]
        public async Task TestActionSuccessedNoResult()
        {
            var response = await _server.CreateRequest("api/test").SendAsync("POST");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WebApiResult>(content);

            // Assert
            Assert.IsType<WebApiResult>(result);
            Assert.Equal(result.Successed, true);
            Assert.Null(result.Value);
        }

        [Fact]
        public async Task TestActionNotSuccessed()
        {
            var response = await _server.CreateRequest("api/test").SendAsync("DELETE");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WebApiResult>(content);

            // Assert
            Assert.IsType<WebApiResult>(result);
            Assert.Equal(result.Successed, false);
            Assert.Null(result.Value);
            Assert.Equal(result.Message, "Delete failed");
        }

        [Fact]
        public async Task TestActionSuccessedReturnJsonResult()
        {
            var response = await _server.CreateRequest("api/test").SendAsync("PUT");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WebApiResult>(content);

            // Assert
            Assert.IsType<WebApiResult>(result);
            Assert.Equal(result.Successed, true);
            Assert.Equal(result.Value.ToString(), "Put is ok");
        }
    }
}
