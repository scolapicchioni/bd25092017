using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance01 {
    public class RegularCard : Card {

        public RegularCard(int cardId, string name, string address, string city, decimal credit) : base(cardId, name, address, city, credit) {
        }

        public override bool Pay(decimal amount) {
            if(amount<=Credit)
                Credit -= amount;
            return amount <= Credit;
        }
    }
}
