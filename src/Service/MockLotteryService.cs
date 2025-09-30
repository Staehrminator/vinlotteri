using Experivin.Data;

namespace Experivin.Service;

public class MockLotteryService(IDataLayer _data) : ILotteryService
{
    public IEnumerable<Wine> GetWines()
    {
        var wines = _data.GetWines()
            .OrderByDescending(x => x.Price);
        
        return wines;
    }

    public Ticket? TryBuyTicket(string name)
    {
        if (_data.CountRemainingTickets() == 0)
            return null;
        
        if (_data.HasBoughtTicket(name))
            return null;
        
        return _data.BuyTicket(name);
    }
}