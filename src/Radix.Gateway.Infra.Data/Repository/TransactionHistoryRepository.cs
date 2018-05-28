using Microsoft.Extensions.Configuration;
using Radix.Gateway.Domain.Entity;
using Radix.Gateway.Domain.Repository;

namespace Radix.Gateway.Infra.Data.Repository
{
    public class TransactionHistoryRepository : BaseRepository<TransactionHistory>, ITransactionHistoryRepository
    {
        public TransactionHistoryRepository(IConfiguration configuration)
            : base(configuration) { }
    }
}
