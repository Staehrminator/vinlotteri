using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace Experivin.Api;

public class Api(ILotteryService _service)
{
    [Function("GetWines")]
    public IActionResult GetWines([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        var wines = _service.GetWines();
        
        return new JsonResult(wines);
    }

    [Function("BuyTicket")]
    public async Task<IActionResult> BuyTicket([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        var input = await JsonSerializer.DeserializeAsync<BuyTicketInput>(req.Body);
        
        var ticket = _service.TryBuyTicket(input.Name);
        if (ticket == null)
            return new JsonResult("No ticket");
        
        return new JsonResult(ticket);
    }

}