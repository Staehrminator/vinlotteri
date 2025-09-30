namespace Experivin;

public interface ILotteryService
{
    public IEnumerable<Wine> GetWines();
    public Ticket? TryBuyTicket(string name);
}