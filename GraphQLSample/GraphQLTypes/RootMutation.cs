using GraphQL.Types;
using GraphQLSample.Models;
using GraphQLSample.Repositories;

namespace GraphQLSample.GraphQLTypes
{
    public class RootMutation : ObjectGraphType
    {

        public RootMutation(IPlayerRepository playerRepository)
        {
            Field<PlayerType>(
                "addPlayer",
                arguments: new QueryArguments
                {
                    new QueryArgument<InputPlayerType>(){ Name = "player" }
                },
                resolve: context =>
                {
                    var player = context.GetArgument<Player>("player");
                    return playerRepository.AddPalyer(player);
                }
                );
        }
    }
}
