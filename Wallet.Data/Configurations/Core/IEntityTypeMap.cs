using Microsoft.EntityFrameworkCore;

namespace Wallet.Data.Configurations.Core
{
    public interface IEntityTypeMap
    {
        void Map(ModelBuilder builder);
    }
}