using System.Collections.Generic;
using GraphQLSample.Models;

namespace GraphQLSample.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();
        Player AddPalyer(Player player);
    }
}
