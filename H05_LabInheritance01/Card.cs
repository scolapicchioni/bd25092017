using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_LabInheritance01 {
    public abstract class Card {
        public Card(int cardId, string name, string address, string city, decimal credit) {
            Id = cardId;
            CustomerName = name;
            CustomerAddress = address;
            CustomerCity = city;
            Credit = credit;
        }
        public int Id { get; private set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public decimal Credit { get; protected set; }

        public abstract bool Pay(decimal amount);
    }
}
