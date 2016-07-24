using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace zxm.AspNetCore.WebApi.ResultExtenstion.Tests.Controllers
{
    [Route("api/[controller]")]
    [ResultActionFilterAttributer]
    public class TestController : Controller
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return await Task.FromResult("Get is ok");
        }

        [HttpPost]
        public async Task Post()
        {
            await Task.CompletedTask;
        }

        [HttpDelete]
        public void Delete()
        {
            throw new Exception("Delete failed");
        }

        [HttpPut]
        public JsonResult Put()
        {
            return new JsonResult("Put is ok");
        }
    }
}
