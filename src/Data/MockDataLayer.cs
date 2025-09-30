namespace Experivin.Data;

public class MockDataLayer : IDataLayer
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
        };
    }
    
    public int CountRemainingTickets()
    {
        var rand = new Random();
        return rand.Next(0, 101);
    }
    
    public bool HasBoughtTicket(string name)
    {
        var rand = new Random();
        return rand.Next(0, 2) == 0;
    }

    public Ticket BuyTicket(string name)
    {
        return new Ticket { Name = name, Number = 69 };
    }
}