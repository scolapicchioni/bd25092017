using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO03 {
    class Program {
        static void Main(string[] args) {
            /*
             * It is recommended to provide a test for each class to test the methods.

1.	BankAccount Class: Create a class BankAccount, which contains an accountnumber, and a balance. Choose appropriate data types. Also provide access member functions, if needed. A new BankAccount is created with only a given account number (in this case the initial balance is zero) or with an given account number and an initial balance. Provide the necessary constructor(s).
2.	Deposit and Withdraw: Create member methods in class BankAccount to credit the account and to debit the account. It is no problem if the balance of an account drops below zero.
3.	Bank Class: Create a class Bank, which contains an array of BankAccounts. Provide a constant value MAXACCOUNTS which determines the maximum number of accounts.
Note: do not use the account number as an array index.
4.	Add BankAccounts: Create a member method for class Bank to add a new BankAccount. The method has one parameter that represents the initial balance and returns the new account number.
5.	Total Amount in Bank: Create a member method for class Bank to calculate the total amount of all accounts.
6.	Interest for BankAccounts: Add a method to class BankAccount to add (or subtract) interest. The interest rate is not passed as a parameter, because it is the same for all accounts, but it can be changed (once in a while). There is a different rate for accounts that have a positive balance and for accounts that have a negative balance.
7.	Interest for Banks: Add a method to class Bank to deal with the interest of all accounts.
8.	Find BankAccount: Create a method in class Bank that yields the account for a given account number. Assume that such an account always exists; we deal with exceptions later.
9.	Transfer Money: Create a member method for class Bank to transfer money from one BankAccount to another. If one of the accounts doesn’t exist or if both account numbers are the same, do not transfer anything. We will deal with this situation later.
10.	Remove BankAccounts: Create two member methods for class Bank to remove an account. One of the functions only gets the account number as a parameter: it just ignores the balance. The other one gets a second account number as a parameter, it removes the account and transfers the balance (positive or negative) to the second account. If one if the account numbers does not exist or if the second account number is the same as the first account number, do not remove the account and do not transfer anything. We will deal with this situation later.
11.	Find all Negative BankAccounts: Create a member method for class Bank that returns an array of all account numbers of accounts whose balance is below zero.
12.	Find Most Average BankAccount: The bank wants to know which is their most average BankAccount, so create a method that returns the account number of the account of which the balance is closest to the average balance of all accounts. If this holds for more than one account, then return all of them.

            3.	Advanced exercises

1.	Add Exceptions: Review all methods of exercise 2: if some erroneous situation occurs (e.g. an account number does not exist, the same account number is passed in a transfer or an account is removed with a positive or negative balance and no transfer account is passed) throw an appropriate Exception.
2.	Notification of Change: When the balance of a bank account is changed, other parts of your application may be interested (for example, if you present this balance to the user, you want this presentation to adapt itself to the new balance). To facilitate this, let your account objects send out notifications to interested listeners. Your account object must therefore also enable the registration for these listeners. Listeners must also be able to un-register themselves as listener.
3.	SavingsAccount class: We introduce two types of BankAccount: the SavingsAccount and the CheckingAccount. The difference between the two account types is that there is a higher interest rate for the SavingsAccount, but it is illegal to have a negative balance for a SavingsAccount (Exceptions!). Change the existing BankAccount into an abstract class and derive two new classes from it. Implement the new functionality.
4.	Linked List of Accounts: The number of accounts is not fixed anymore. Therefore the implementation of the Bank must change: instead of an array, we will use a linked list to store the accounts. We will not use a standard collection type for this, but implement a LinkedList ourselves.  Make necessary changes to the Bank and BankAccount class.
5.	Shield the BankAccount class: Change the implementation of BankAccount and Bank in such a way that one cannot use the BankAccounts directly, but only through the class Bank. (The class BankAccount can only be used internally).
6.	User Interface: Build a user interface for the application. Through the interface a new bank account can be requested (and the account number of the new account will be shown), an amount of money can be deposited or withdrawn from an account or transferred from one account to another, and a list of all account numbers with corresponding balances can be shown. 
*/
        }
    }
}
