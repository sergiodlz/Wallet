using GraphQL.Types;

namespace Wallet.Services.GraphQL.MutationsTypes
{
    public class UserMGQL : InputObjectGraphType
    {
        public UserMGQL()
        {
            Name = "user";
            Field<IdGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("email");
            Field<NonNullGraphType<StringGraphType>>("password");
        }
    }
}