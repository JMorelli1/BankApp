/*
 * Account class 
 * Author: James Morelli
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        private String accountNumber;
        private String customerID;
        private String type;
        private double balance;
        private DBAccess db;
        private System.Data.OleDb.OleDbDataReader dr;

        public Account()
        {
            accountNumber = "";
            customerID = "";
            type = "";
            balance = 0.0;
            db = new DBAccess();
        }
        
        public Account(String accountNumber, String customerID, String type, double balance)
        {
            this.accountNumber = accountNumber;
            this.customerID = customerID;
            this.type = type;
            this.balance = balance;
            db = new DBAccess();
        }

        /*
         * Getters and Setters for the Account class
         */
        public String AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public String CustomerID { get { return customerID; } set { customerID = value; } }
        public String Type { get { return type; } set { type = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        /*
         * selectAccount selects the account from the database using the current object accountnumber
         */
        public void selectAccount()
        {
            String query = "SELECT * FROM Accounts WHERE AcctNo = '" + AccountNumber + "'";
            dr = db.SelectCommand(query);
            dr.Read();
            accountNumber = AccountNumber;
            CustomerID = (dr.GetValue(1) + "");
            Type = (dr.GetValue(2) + "");
            Balance = (Double.Parse(dr.GetValue(3) + ""));
            db.DBClose();
        }

        /*
         * insertAccount queries the database using the db object to insert a new account
         */
        public void insertAccount()
        {
            String query = "INSERT INTO Accounts VALUES('" + AccountNumber + "','" + CustomerID + "','" + Type + "'," + Balance + ")";
            db.InsertCommand(query);
        }

        /*
         * updateAccount queries the database using the db object to update the current account
         */
        public void updateAccount()
        {
            String query = "UPDATE Accounts SET Cid = '" + CustomerID + "'," + " Type = '" + Type + "'," + " Balance = " + Balance + " WHERE AcctNo = '" + AccountNumber + "'";
            db.UpdateCommand(query);
        }

        /*
         * deleteAccount queries the database using the db object to delete the selected Account
         */
        public void deleteAccount()
        {
            String query = "DELETE FROM Accounts WHERE AcctNo = '" + AccountNumber + "'";
            db.DeleteCommand(query);
        }

        /*
         * countAccounts queries the database using the db object to count all accounts 
         */
        public int countAccounts()
        {
            String query = "SELECT * FROM Accounts";
            dr = db.SelectCommand(query);
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            db.DBClose();
            return count;
        }

        /*
         * display for testing, dispays all info in the account object
         */
        public void display()
        {
            Console.WriteLine(AccountNumber);
            Console.WriteLine(CustomerID);
            Console.WriteLine(Type);
            Console.WriteLine(Balance);
        }
    }
}
