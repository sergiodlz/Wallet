using GraphQL;
using GraphQL.Types;
using Wallet.GraphQL.Queries;

namespace Wallet.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
        : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}