using GraphQL;
using GraphQL.Types;

namespace GraphQLSample.GraphQLTypes
{
    public class RootSchema:Schema, ISchema
    {
        public RootSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<RootQuery>();
            Mutation = resolver.Resolve<RootMutation>();
        }
    }
}
