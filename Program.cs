using System;
using System.Collections.Generic;

namespace RewardPointsCalulation
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Model with customer names keys and transactions list  
            // Bascially this should come from services based on some repository and on database call, just created dummy model with data   
            List<CustomerRequestModel> customers = CustomersEntity.GetCustomerTransactionalData();     
            
            // Calculate reward points for each customer
            Dictionary<string, int[]> rewardsPerCustomer = Calculation.CalculateRewards(customers);

            // Display results
            foreach (var customer in rewardsPerCustomer)
            {
                Console.WriteLine($"Customer: {customer.Key}");
                int totalPoints = 0;
                for (int i = 0; i < customer.Value.Length; i++)
                {
                    Console.WriteLine($"  Month {i + 1} Points: {customer.Value[i]}");
                    totalPoints += customer.Value[i];
                }
                Console.WriteLine($"  Total Points: {totalPoints}\n");
            }
        }  
    } 
}

