/*
 * AccountList class 
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
    public class AccountList
    {
        public ArrayList accountList = new ArrayList();


        //getSize returns arraylist size
        public int getSize()
        {
            return accountList.Count;
        }

        //addAccount adds an account to the arraylist
        public void addAccount(Account newAccount)
        {
            accountList.Add(newAccount);
        }

        //getAccount returns an account from the list of the sent index value
        public Account getAccount(int location)
        {
            return (Account)accountList[location];
        }
        
        //emptylist clears the arraylist of contents
        public void emptylist()
        {
            accountList.Clear();
        }
    }
}
