/*
 * Data Base Access Object
 * Author James Morelli
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class DBAccess
    {
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public System.Data.OleDb.OleDbDataReader dr;


        //Initializes all the Commands and objects necessary to connect to the database 
        public DBAccess()
        {
                OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
                OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbConnection2 = new System.Data.OleDb.OleDbConnection();


                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

                OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Reg" + "istry Path =; Jet OLEDB:Database L" +
                    "ocking Mode=1;Data Source=C:/Users/morel/Desktop/Chat Tech/Fall 19/C# Prog/ChattBankMDB.mdb;J" +
                    "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
                    "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
                    "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
                    "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
                    "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
                Console.WriteLine("Connection Successful");
        }

        /*
         * DBClose closes the connection with the database
         */
        public void DBClose()
        {
            OleDbConnection2.Close();
        }

        /*
         * SelectCommand queries the database with a selectcommand using the string query provided
         */
        public System.Data.OleDb.OleDbDataReader SelectCommand(String query)
        {
            OleDbDataAdapter2.SelectCommand.CommandText = query;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            try
            {
                OleDbConnection2.Open();
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error selecting customer" + e);
            }
            return dr;
        }

        /*
         * InsertCommand queries the database using the InsertCommand from the string query provided
         */
        public void InsertCommand(String query)
        {
            OleDbDataAdapter2.InsertCommand.CommandText = query;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Customer Data Inserted");
                }
                else
                {
                    Console.WriteLine("Error Inserting Customer Data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                DBClose();
            }
        }

        /*
         * UpdateCommand queries the database using the updatecommand from the string query provided
         */
        public void UpdateCommand(String query)
        {

            OleDbDataAdapter2.UpdateCommand.CommandText = query;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Customer Data Updated");
                }
                else
                {
                    Console.WriteLine("Error Updating Customer Data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                DBClose();
            }
        }

        /*DeleteCommand queries the database using the deletecommand from the string query provided
         */
        public void DeleteCommand(String query)
        {
            OleDbDataAdapter2.DeleteCommand.CommandText = query;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;

            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Customer Data Deleted");
                }
                else
                {
                    Console.WriteLine("Error Deleting Customer Data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                OleDbConnection2.Close();
            }

        }
    }
}
