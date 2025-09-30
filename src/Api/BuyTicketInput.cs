using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;

namespace Experivin.Api;

public class BuyTicketInput
{
    [OpenApiProperty]
    public string Name { get; set; }
}