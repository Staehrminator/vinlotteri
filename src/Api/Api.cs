using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;

namespace Experivin.Api;

public class Api(ILotteryService _service)
{

    [OpenApiOperation]
    [Function("GetWines")]
    public IActionResult GetWines([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        var wines = _service.GetWines();
        
        return new JsonResult(wines);
    }
    
    [OpenApiOperation]
    [OpenApiRequestBody(contentType: "application/json", bodyType: typeof(BuyTicketInput), Required = true, Description = "Provide a name for the buyer")]
    [Function("BuyTicket")]
    public async Task<IActionResult> BuyTicket([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        var input = await JsonSerializer.DeserializeAsync<BuyTicketInput>(req.Body, new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
        
        var ticket = _service.TryBuyTicket(input.Name);
        if (ticket == null)
            return new JsonResult("No ticket");
        
        return new JsonResult(ticket);
    }

}