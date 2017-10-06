using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance01 {
    class Program {
        static void Main(string[] args) {
            /*
             * Lab 10: Inheritance

Chain store  MICRO

Customers of chain store “Micro” require a customer card. 
This card must be used during payment of their groceries.  
The card records the customer name, address, city, customer id and the credit 
(In the exercise the address and city may be omitted). 

Micro uses two types of cards: Regular Card and Gold Card.
When the customer pays for his groceries , 
the amount he has to pay is subtracted from his credit. 
The owner of a gold card may have a negative balance 
and he  is offered a discount.  
The owner of a regular card may not have a negative balance 
and no discount is offered. 

Build an application with the following functionality:
-	The application must display an overview of all customers.
-	A customer can be selected to perform a payment. The credit must be changed accordingly.
  
 
Exercises

1.	 Create a base class Card with the following members: 

a.	Datamembers: 
cardId	(int, readonly)
name	(string)
address	(string)		(might  be omitted)
city	(string) 		(might  be omitted)
credit	(double/ decimal)		
b.	Constructor
Create a constructor which can initialize all the data members.

c.	method
Create a method  Pay  which will be implemented in a deriving class bool Pay(int amount). 
The return type is used  to signal if the payment was successful.

2.	 Create the class RegularCard (derives from Card)

a.	Constructor
Create a constructor which can initialize all the data members. 
Make use of  the constructor of the base class

b.	Implement  the Pay method.
		
3.	Create the class  GoldCard (derives from Card)

a.	Datamember
A gold card has a data member discount (int). 
In the setter check if the discount is in the range 1..30. 
Throw an argument out of range exception if an invalid discount is assigned.

b.	Constructor
Create a constructor which can initialize all the data members. 
Make use of  the constructor of the base class.

c.	Implement  the Pay method. The discount should be taken into account.

4.	Create the user interface. Start with showing all the customers,  
a collection of customers with a gold card and customers with a regular card. 
Use one collection of type Card for all customers. 

A customer id can be chosen to perform a payment for this particular customer. 
In case a payment cannot be performed a message must be shown (and the payment is rejected).

The properties Address and City may be omitted.
*/

            Card[] cards = new Card[10];
            //cards[2] = new Card(3,"","","",123);
            cards[0] = new RegularCard(1, "", "", "", 123);
            cards[1] = new GoldCard(2, "", "", "", 123,2);

            cards[0].Pay(22);
            cards[1].Pay(22);

        }
    }
}
