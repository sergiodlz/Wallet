using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.GraphQL.Types
{
    public class UserGQL : ObjectGraphType<User>
    {
        public UserGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.Email);
            Field(x => x.Name);
            Field(x => x.Password);
        }
    }
}