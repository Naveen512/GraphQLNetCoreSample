using System.Linq;
using GraphQL.Types;
using GraphQLSample.Repositories;

namespace GraphQLSample.GraphQLTypes
{
    public class RootQuery:ObjectGraphType
    {
        public RootQuery(IPlayerRepository _playerRepository)
        {
            Field<ListGraphType<PlayerType>>("players", resolve: context =>
             {
                 
                 return _playerRepository.GetAll();
             });

            Field<ListGraphType<PlayerType>>("filteredPlayers",
                arguments: new QueryArguments
                {
                   new  QueryArgument<StringGraphType> { Name = "firstName"}
                },
                resolve: context =>
                {
                    string firstName = context.GetArgument<string>("firstName");
                    return _playerRepository.GetAll().Where(_ => _.FirstName.ToLower() == firstName.ToLower()).ToList();
                });
        }
    }
}
