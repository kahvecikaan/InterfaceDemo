using InterfaceDemo.Abstract;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Concrete;

public class EGovernmentVerificationService : IVerificationService
{
    public bool Verify(Player player)
    {
        return player.TcNo.Length == 11 && player.BirthYear > 1900;
    }
}