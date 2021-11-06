using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LeanPrezzo.Api
{
    public static class GetServerStatus
    {
        [FunctionName("GetServerStatus")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "server-status")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            ServerStatus responseMessage = new ServerStatus()
            {
                State = "Up",
                Code = 200
            };

            return new OkObjectResult(responseMessage);
        }

        public class ServerStatus
        {
            public string State { get; set; }
            public int Code { get; set; }
        }
    }
}
