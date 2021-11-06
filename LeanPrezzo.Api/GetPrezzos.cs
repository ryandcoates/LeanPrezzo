using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using libLeanPrezzo;

namespace LeanPrezzo.Api
{
  public static class GetPrezzos
  {
    [FunctionName("GetPrezzos")]
    public static async Task<ActionResult<List<Presentation>>> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "prezzos")] HttpRequest req)
    {
      try
      {
        var presentations = new List<Presentation>();
        return new OkObjectResult(presentations);
      }
      catch (System.Exception error)
      {
        return new BadRequestObjectResult(new { message = error.Message });
      }
    }
  }
}
