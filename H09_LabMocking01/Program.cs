using System;

namespace H09_LabMocking01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             * 
             * A Library Member has an Id, a Name, a Date of Birth and 
             * a Maximum number of books he can borrow.
             * A Library Member has no methods.
             * 
             * A LibraryManager can Calculate the Membership Cost 
             * of a Library Member given a Member Id.
             * 
             * The membership cost is equal to
             * 10 Euros plus half of the number of books 
             * that a Member can borrow.
             * 
             * A Library Store can Create, Read, Update and Delete 
             * Library Members
             * from and to a database.
             * 
             * When a Library Manager is asked to calculate 
             * the membership cost of a Library Member,
             * the Library Manager goes to the Library Store
             * and asks it to fetch a Member from the DB,
             * then calculates and returns the cost.
             * 
             * Right now the Library Manager is not unit testable.
             * Refactor the project to be able to 
             * test the Library Manager by mocking the Library Store.
             * 
             */

            Console.ReadLine();
        }
    }
}
