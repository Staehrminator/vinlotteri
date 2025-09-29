namespace Experivin.Service;

public class MockLotteryService : ILotteryService
{
    public IEnumerable<Wine> GetWines()
    {
        return new List<Wine>
        {
            new() { Price = 50, Name = "Testevin Rød" },
            new() { Price = 50, Name = "Testevin Hvit" },
            new() { Price = 100, Name = "Testevin Dessert" },
            new() { Price = 300, Name = "Testevin Port" },
            new() { Price = 500, Name = "Testevin Dyr" },
        }.OrderByDescending(x => x.Price);
    }
}