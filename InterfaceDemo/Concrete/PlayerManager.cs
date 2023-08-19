using InterfaceDemo.Abstract;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Concrete;

public class PlayerManager : IPlayerService
{
    private IVerificationService _verificationService;

    public PlayerManager(IVerificationService verificationService)
    {
        _verificationService = verificationService;
    }
    public bool Register(Player player)
    {
        if (_verificationService.Verify((player)))
        {
            Console.WriteLine($"{player.FirstName} {player.LastName} registered successfully!");
            return true;
        }
        else
        {
            Console.WriteLine("Verification failed. Registration unsuccessful.");
            return false;
        }
    }

    public void Update(Player player)
    {
        Console.WriteLine($"{player.FirstName} {player.LastName}'s information updated successfully.");
    }

    public void Delete(Player player)
    {
        Console.WriteLine($"{player.FirstName} {player.LastName}'s information deleted successfully.");
    }
}