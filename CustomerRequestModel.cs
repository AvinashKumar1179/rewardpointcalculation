
using System;
using System.Collections.Generic;
using System.Text;

namespace RewardPointsCalulation
{
    public class CustomerRequestModel
    {
        public string CustomerName { get; set; }
        public List<TransactionByMonthModel> TransactionByMonth { get; set; }

}
    public class TransactionByMonthModel
    {
        public string MonthName { get; set; }
        public List<double> Transaction { get; set; } 
    }
}
