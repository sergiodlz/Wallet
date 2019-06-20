using GraphQL;
using GraphQL.Types;
using Wallet.Services.GraphQL.Queries;

namespace Wallet.Services.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
        : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
            Mutation = resolver.Resolve<AppMutation>();
        }
    }
}