﻿using System.Collections.Generic;

namespace Grupp1BankApp
{
	public class BankLogic
	{

       
        public bool AddCustomer(string name, long SSN)
		{
			return true;
			//TODO fix return statement.
		}

		public List<string> GetCustomers()
		{
			List<string> customersList = new List<string>();
			return customersList;
			//TODO fix return statement.
		}

		public List<string> GetCustomer(long SSN)
		{
			List<string> customers = new List<string>();

			return customers;
			//TODO fix return statement.
		}

		public bool ChangeCustomerName(string name, long SSN)
		{
			return true;
			//TODO fix return statement.
		}

		public List<string> RemoveCustomer(long SSN)
		{
			List<string> removedCustomers = new List<string>();
			return removedCustomers;
			//TODO fix return statement.
		}

		public int AddSavingsAccount(long SSN)
		{
			return 0;
			//TODO fix return statement.
		}

		public string GetAccount(string SSN, int accountID)
		{
         
          

			return "";
			//TODO fix return statement.
		}

		public bool Deposit(long SSN, int accountID, double amount)
		{
			return true;
			//TODO fix return statement.
		}

		public bool Withdraw(long SSN, int accountID, double amount)
		{
			return true;
			//TODO Fix return statement.
		}

		public string CloseAccount(long SSN, int accountID)
		{
			return "";
			//TODO fix return statement.
		}

		public int AddCreditAccount(long SSN)
		{
			return 0;
			//TODO fix return statement.
		}

		public List<string> GetTransactions(long SSN, int accountID)
		{
			List<string> transactionList = new List<string>();

			return transactionList;
			//TODO fix return statement.
		}
	}
}