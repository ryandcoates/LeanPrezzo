using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using libLeanPrezzo;

namespace LeanPrezzo.Api
{
  public static class GetServerStatus
  {
    [FunctionName("GetServerStatus")]
    public static ActionResult<ServerStatus> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "server-status")] HttpRequest req,
        ILogger log)
    {
      try
      {
        ServerStatus responseMessage = new ServerStatus()
        {
          State = "Up",
          Code = 200
        };
        return new OkObjectResult(responseMessage);
      }
      catch (System.Exception error)
      {
        return new BadRequestObjectResult(error.Message);
      }
    }
  }
}
