using System;
using System.Collections.Generic;
using System.Text;

namespace RewardPointsCalulation
{
    static class CustomersEntity
    {
        public static List<CustomerRequestModel> GetCustomerTransactionalData()
        {
            List<CustomerRequestModel> customers = new List<CustomerRequestModel>();

            CustomerRequestModel firstCustomerRequest = new CustomerRequestModel();
            // Assigning values to properties
            firstCustomerRequest.CustomerName = "First Customer";

            // Creating a list of TransactionByMonthModel
            List<TransactionByMonthModel> transactionsByMonth = new List<TransactionByMonthModel>();

            // Creating instance of TransactionByMonthModel for January
            TransactionByMonthModel januaryTransactions = new TransactionByMonthModel();
            januaryTransactions.MonthName = "January";
            januaryTransactions.Transaction = new List<double> { 110, 70, 90, 120, 140 }; // Example transaction amounts
            transactionsByMonth.Add(januaryTransactions);

            TransactionByMonthModel februaryTransactions = new TransactionByMonthModel();
            februaryTransactions.MonthName = "February";
            februaryTransactions.Transaction = new List<double> { 600, 110, 90, 120, 80 }; // Example transaction amounts
            transactionsByMonth.Add(februaryTransactions);

            TransactionByMonthModel marchTransactions = new TransactionByMonthModel();
            marchTransactions.MonthName = "March";
            marchTransactions.Transaction = new List<double> { 130, 70, 90, 150, 200 }; // Example transaction amounts
            transactionsByMonth.Add(marchTransactions);
            firstCustomerRequest.TransactionByMonth = transactionsByMonth;

            customers.Add(firstCustomerRequest);

            CustomerRequestModel secondCustomerRequest = new CustomerRequestModel();
            // Assigning values to properties
            secondCustomerRequest.CustomerName = "Second Customer";

            // Creating a list of TransactionByMonthModel
            List<TransactionByMonthModel> secondTransactionsByMonth = new List<TransactionByMonthModel>();

            // Creating instance of TransactionByMonthModel for January
            TransactionByMonthModel januaryTransactionsForCust2 = new TransactionByMonthModel();
            januaryTransactionsForCust2.MonthName = "January";
            januaryTransactionsForCust2.Transaction = new List<double> { 180, 80, 100, 120, 140 }; // Example transaction amounts
            secondTransactionsByMonth.Add(januaryTransactionsForCust2);

            TransactionByMonthModel februaryTransactionsForCust2 = new TransactionByMonthModel();
            februaryTransactionsForCust2.MonthName = "February";
            februaryTransactionsForCust2.Transaction = new List<double> { 70, 100, 80, 140, 110 }; // Example transaction amounts
            secondTransactionsByMonth.Add(februaryTransactionsForCust2);

            TransactionByMonthModel marchTransactionsForCust2 = new TransactionByMonthModel();
            marchTransactionsForCust2.MonthName = "March";
            marchTransactionsForCust2.Transaction = new List<double> { 30, 80, 210, 150, 20 }; // Example transaction amounts
            secondTransactionsByMonth.Add(marchTransactionsForCust2);
            secondCustomerRequest.TransactionByMonth = secondTransactionsByMonth;

            customers.Add(secondCustomerRequest);
            return customers;
        }
    }
}
