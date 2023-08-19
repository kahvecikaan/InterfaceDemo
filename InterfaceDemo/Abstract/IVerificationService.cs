using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract;

public interface IVerificationService
{
    bool Verify(Player player);
}