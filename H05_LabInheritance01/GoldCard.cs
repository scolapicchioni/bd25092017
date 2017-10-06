using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance01 {
    public class GoldCard : Card{
        public GoldCard(int cardId, string name, string address, string city, decimal credit, decimal discount) : base(cardId, name, address, city, credit) {
            Discount = discount;
        }
        private decimal discount;
        public decimal Discount {
            get { return discount; }
            set {
                if (value < 1 || value > 30)
                    throw new ArgumentOutOfRangeException();
                discount = value;
            }
        }
        public override bool Pay(decimal amount) {
            decimal toPay = amount - (amount * discount / 100);
            Credit -= toPay;
            return true;
        }
    }
}
