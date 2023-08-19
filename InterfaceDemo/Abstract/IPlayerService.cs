using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract;

public interface IPlayerService
{
    bool Register(Player player);
    void Update(Player player);
    void Delete(Player player);
}