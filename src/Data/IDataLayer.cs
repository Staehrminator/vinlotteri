namespace Experivin.Data;

public interface IDataLayer
{
    public IEnumerable<Wine> GetWines();
    int CountRemainingTickets();
    bool HasBoughtTicket(string name);
    Ticket BuyTicket(string name);
}