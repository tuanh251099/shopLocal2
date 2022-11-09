using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace shopLocal.Data.Entities
{
   public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Account;
        public decimal Free { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus Status { set; get; }
        public string Provider { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
