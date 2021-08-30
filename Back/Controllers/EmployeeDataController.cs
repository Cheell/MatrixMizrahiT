using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Managers;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeDataController : ControllerBase
    {
        private static readonly string SECRET_TOKEN = "4723c269-57aa-4a4f-9439-439b695de6d1";
        private static readonly string VERIFICATION_FAIL = "Token Verification Fail!";
        [HttpGet]
        public async Task<IActionResult> GetEmployee2018Data() => Checktoken(Request) ? Ok(await YearManager.GetEmpData()) : StatusCode(401, VERIFICATION_FAIL);
        [HttpGet]
        public async Task<IActionResult> GetEmployee2019Data() => Checktoken(Request) ? Ok(await YearManager.GetEmpData()) : StatusCode(401, VERIFICATION_FAIL);
        [HttpGet]
        public async Task<IActionResult> GetEmployee2020Data() => Checktoken(Request) ? Ok(await YearManager.GetEmpData()) : StatusCode(401, VERIFICATION_FAIL);

        private bool Checktoken(HttpRequest request)
        {
            request.Headers.TryGetValue("AuthSecretToken", out var result);
            return result == SECRET_TOKEN;
        }


    }
}
