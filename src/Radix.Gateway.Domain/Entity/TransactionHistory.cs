using System;

namespace Radix.Gateway.Domain.Entity
{
    public class TransactionHistory
    {
        public Guid Id { get; set; }
        public string IdTransaction { get; set; }
        public string MerchantKey { get; set; }
        public DateTime CreateDate { get; set; }
        public string OrderReference { get; set; }
        public string DataTransactionAcquirer { get; set; }
    }
}
