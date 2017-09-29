using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO02 {
    class Program {
        static void Main(string[] args) {
            /*
             * 1.	Read: Read the rules for Blackjack.
2.	Design: Identify the objects and classes in the game of Blackjack and think about containment and inheritance relations between them. Make a detailed list of state (data fields) and functionality (methods) for each class.
Furthermore, make a flowchart describing the scenario of the game.
3.	Discuss: Discuss the design with the instructor. Don’t start coding until your design has been approved.
4.	Start simple: Choose which rules to include and which to exclude in your version of Blackjack. A good start would be to exclude almost all player options: leave out to player abilities to ‘Split Pairs’ and ‘Double down’.
5.	Play: Test your program.
6.	Complete: If time permits, extend your program to include the options that have been left out.

5.	Rules of Blackjack

(Compiled from http://www.blackjackinfo.com/blackjack-rules.php)
The basic premise of the game is that you want to have a hand value that is closer to 21 than that of the dealer, without going over 21.

In Blackjack, the cards are valued as follows: 

   An Ace can count as either 1 or 11, as demonstrated below. 
   The cards from 2 through 9 are valued as indicated. 
   The 10, Jack, Queen, and King are all valued at 10. 

The suits of the cards do not have any meaning in the game.

The value of a hand is simply the sum of the point counts of each card in the hand.  For example, a hand containing (5, 7, 9) has the value of 21.  The Ace can be counted as either 1 or 11.  You need not specify which value the Ace has.  It's assumed to always have the value that makes the best hand.  An example will illustrate:  Suppose that you have the beginning hand (Ace, 6).  This hand can be either 7 or 17.  If you stop there, it will be 17.  Let's assume that you draw another card to the hand and now have (Ace, 6, 3).  Your total hand is now 20, counting the Ace as 11.   Let's backtrack and assume that you had instead drawn a third card which was an 8.  The hand is now (Ace, 6, 8) which totals 15.  Notice that now the Ace must be counted as only 1 to avoid going over 21. 

Once all the bets are made, the dealer will deal the cards to the players.  He'll make two passes around the table starting at his left (your right) so that the players and the dealer have two cards each.  The dealer will flip one of his cards over, exposing its value.

How the dealer plays his hand
The dealer must play his hand in a specific way, with no choices allowed.  There are two popular rule variations that determine what totals the dealer must draw to.   In any given casino, you can tell which rule is in effect by looking at the blackjack tabletop.  It should be clearly labeled with one of these rules: 
  
"Dealer stands on all 17s":  This is the most common rule.  In this case, the dealer must continue to take cards ("hit") until his total is 17 or greater.  An Ace in the dealer's hand is always counted as 11 if possible without the dealer going over 21.  For example, (Ace, 8) would be 19 and the dealer would stop drawing cards ("stand").  Also, (Ace, 6) is 17 and again the dealer will stand.  (Ace, 5) is only 16, so the dealer would hit.  He will continue to draw cards until the hand's value is 17 or more.  For example, (Ace, 5, 7) is only 13 so he hits again.  (Ace, 5, 7, 5) makes 18 so he would stop ("stand") at that point.

Again, the dealer has no choices to make in the play of his hand.  He cannot split pairs, but must instead simply hit until he reaches at least 17 or busts by going over 21. 

What is a Blackjack, or a natural?
A Blackjack, or natural, is a total of 21 in your first two cards.  A Blackjack is therefore an Ace and any ten-valued card, with the additional requirement that these be your first two cards.  If you split a pair of Aces for example, and then draw a ten-valued card on one of the Aces, this is not a blackjack, but rather a total of 21.  The distinction is important, because a winning Blackjack pays the player odds of 3 to 2.  A bet of $10 wins $15 if the player makes a Blackjack.  A player Blackjack beats any dealer total other than a dealer's Blackjack, including a dealer's regular 21.  If both a player and the dealer make Blackjack, the hand is a tie or push. 
The dealer will pay your winning Blackjack bet immediately when it is your turn to play 

The Player's Choices
Hitting/Standing
The most common decision a player must make during the game is whether to draw another card to the hand ("hit"), or stop at the current total ("stand").   If you go over 21, or "bust", the dealer will collect your bet.

Doubling Down
Among the more profitable player options available is the choice to "double down".  This can only be done with a two card hand, before another card has been drawn.  Doubling down allows you to double your bet and receive one, and only one, additional card to the hand.  A good example of a doubling opportunity is when you hold a total of 11, say a (6, 5) against a dealer's upcard of 5.  In this case, you have a good chance of winning the hand by drawing one additional card, so you might as well increase your bet in this advantageous situation.
Players are allowed to double down for any amount up to the original bet amount, so you could double down "for less" if you wanted.  Just remember that you do give up something for being allowed to increase your bet:  the ability to draw more than one additional card.

Splitting Pairs
When you are dealt a matching pair of cards (remember, ignore the suits), you have the ability to split the hand into two separate hands, and play them independently.  Let's say you are dealt a pair of eights for a total of sixteen.  Sixteen is the worst possible player hand, since it is unlikely to win as is, but is very likely to bust if you draw to it.  Here's a great chance to improve a bad situation. 
Note that you must bet the same amount on a split, unlike a double-down, where you are allowed to double for less.  The dealer will separate the two cards, and treat them as two independent hands.  Let's say you draw a 3 on the first 8, for a total of 11. You will be allowed to double down on that at this point.  When this is allowed, the rule is called "Double after Split", predictably enough.  You can play the first hand to completion, at which point the dealer will deal a second card to the second hand, and you can begin making play decisions on it. 

If you get additional pairs (in the first two cards of a hand), you are allowed to re-split, making yet another hand.  You are allowed unlimited splitting.  Another fine point is that you are allowed to split any 10-valued cards, so you could split a (Jack, Queen) hand.  However, this is usually a bad play: Keep the 20. 

The other complication for pair splits concerns splitting Aces.  Splitting Aces is a very strong player move, so the casino restricts you to drawing only one additional card on each Ace.  Also, if you draw a ten-valued card on one of your split Aces, the hand is not considered a Blackjack, but is instead treated as a normal 21, and therefore does not collect 3:2 odds.

*/
        }
    }
}
