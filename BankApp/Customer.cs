/*
 * Customer class 
 * Author: James Morelli
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BankApp
{
    public class Customer
    {
        private String customerID;
        private String password;
        private String firstName;
        private String lastName;
        private String address;
        private String email;
        private DBAccess db;
        private System.Data.OleDb.OleDbDataReader dr;
        public AccountList acctList;

        public Customer()
        {
            customerID = "";
            password = "";
            firstName = "";
            lastName = "";
            address = "";
            email = "";
            db = new DBAccess();
            acctList = new AccountList();
        }

        public Customer(String customerID, String password, String firstName, String lastName, String address, String email)
        {
            this.customerID = customerID;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
            db = new DBAccess();
            acctList = new AccountList();
        }

        /*
         * getters and setters for customer
         */

        public String CustomerID { get {return customerID; } set { customerID = value; } }
        public String Password { get { return password; } set { password = value; } }
        public String FirstName { get { return firstName; } set { firstName = value; } }
        public String LastName { get { return lastName; } set { lastName = value; } }
        public String Address { get { return address; } set { address = value; } }
        public String Email { get { return email; } set { email = value; } }


        /*
         * uses the db object to query the db and select the customer info based on customerid
         */
        public void selectCustomer()
        {
            String query = "SELECT * FROM Customers WHERE CustID = '" + CustomerID + "'";
            dr = db.SelectCommand(query);
            dr.Read();
            customerID = CustomerID;
            Password = (dr.GetValue(1) + "");
            FirstName = (dr.GetValue(2) + "");
            LastName = (dr.GetValue(3) + "");
            Address = (dr.GetValue(4) + "");
            Email = (dr.GetValue(5) + "");
            db.DBClose();
        }

        /*
         * uses the db object to query the db and insert the selected customer
         */
        public void insertCustomer()
        {
            String query = "INSERT INTO Customers VALUES('" + CustomerID + "','" + Password + "','" + FirstName + "','" + LastName + "','" + Address + "','" + Email + "')";
            db.InsertCommand(query);

        }

        /*
         * uses the db object to query the db and update the selected customer
         */
        public void updateCustomer()
        {
            String query = "UPDATE Customers SET FirstName = '" + FirstName + "'," + " LastName = '" + LastName + "'," + " Address = '"+ Address + "'," + " CustEmail = '" + Email + "' WHERE CustID = '" + CustomerID + "'";
            db.UpdateCommand(query);
        }

        /*
         * uses the db object to query the db and delete the selected customer and all accounts associated with the customer
         */
        public void deleteCustomer()
        {
            String query = "DELETE FROM Customers WHERE CustID = '" + CustomerID + "'";
            db.DeleteCommand(query);

            query = "DELETE FROM Accounts WHERE Cid = '" + CustomerID + "'";
            db.DeleteCommand(query);
        }

        /*
         * findAccounts creates a arraylist of all accounts connected to the current customer id
         */
        public void findAccounts()
        {
            String query = "SELECT * FROM Accounts WHERE Cid = '" + CustomerID + "'";
            Account tempAccount;
            acctList.emptylist();
            dr = db.SelectCommand(query);
            while (dr.Read())
            {
                tempAccount = new Account();
                tempAccount.AccountNumber = dr.GetValue(0) + "";
                tempAccount.CustomerID = dr.GetValue(1) + "";
                tempAccount.Type = dr.GetValue(2) + "";
                tempAccount.Balance = Double.Parse(dr.GetValue(3) + "");
                acctList.addAccount(tempAccount);
            }
            db.DBClose();
        }

        /*
         * selectAllCustomers generates an arraylist of all customer ids to use in admin page
         * @returns ArrayList
         */
        public ArrayList selectAllCustomers()
        {
            ArrayList allCustomers = new ArrayList();
            String query = "SELECT CustID FROM Customers";
            String custID;
            dr = db.SelectCommand(query);
            while (dr.Read())
            {
                custID = dr.GetString(0);
                allCustomers.Add(custID);
            }
            db.DBClose();
            return allCustomers;
        }

        /*
         * countCustomers searchs database and makes a count of Customers for new id identification
         * @returns int
         */
        public int countCustomers()
        {
            String query = "SELECT * FROM Customers";
            int count = 0;
            dr = db.SelectCommand(query);
            while (dr.Read())
            {
                count++;
            }
            db.DBClose();
            return count;
        }

        /*
         * display method for testing, displays all info stored in customer
         */
        public void display()
        {
            Console.WriteLine(CustomerID);
            Console.WriteLine(Password);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Email);
            Console.WriteLine(Address);
        }
    }
}
