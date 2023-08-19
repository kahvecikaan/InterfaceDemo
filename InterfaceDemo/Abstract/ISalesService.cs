using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract;

public interface ISalesService
{
    void SellGame(Player player, Game game);
}