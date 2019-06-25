using GraphQL.Types;

namespace Wallet.Services.GraphQL.MutationsTypes
{
    public class RecordMGQL : InputObjectGraphType
    {
        public RecordMGQL()
        {
            Name = "record";
            Field<IdGraphType>("id");
            Field<StringGraphType>("description");
            Field<NonNullGraphType<DateTimeGraphType>>("date");
            Field<NonNullGraphType<FloatGraphType>>("amount");
            Field<NonNullGraphType<IdGraphType>>("typeId");
            Field<NonNullGraphType<IdGraphType>>("SubCategoryId");
            Field<NonNullGraphType<IdGraphType>>("AccountId");
        }
    }
}