using System;
using System.Collections.Generic;
using System.Text;

namespace RewardPointsCalulation
{
    public static class Calculation
    {
        internal static Dictionary<string, int[]> CalculateRewards(List<CustomerRequestModel> customersTransactionalData)
        {
            Dictionary<string, int[]> rewardsPerCustomer = new Dictionary<string, int[]>();

            foreach (var customer in customersTransactionalData)
            {
                int[] rewardsPerMonth = new int[customer.TransactionByMonth.Count];
                double totalPoints = 0;
                int i = 0;

                foreach (var transaction in customer.TransactionByMonth)
                {
                    foreach (var item in transaction.Transaction)
                    {
                        if (item > 100)
                        {
                            totalPoints += 2 * (item - 100);
                        }
                        if (item > 50)
                        {
                            totalPoints += Math.Min(item, 100) - 50;
                        }
                    }
                    rewardsPerMonth[i] = (int)totalPoints;
                    totalPoints = 0;
                    i++;
                }
                rewardsPerCustomer.Add(customer.CustomerName, rewardsPerMonth);
            }
            return rewardsPerCustomer;
        }
    }



}
