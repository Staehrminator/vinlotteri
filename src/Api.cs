using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace Experivin;

public class Api(ILotteryService _service)
{
    [Function("GetWines")]
    public IActionResult GetWines([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        return new JsonResult(_service.GetWines());
    }

}