using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class Collection<TypeOfTheItem>
    {
        private TypeOfTheItem[] items = new TypeOfTheItem[10];
        private int count = 0;
        public int Count => count;
        public void Add(TypeOfTheItem item) {
            items[count++] = item;
        }
        public TypeOfTheItem this[int index] => items[index];

        
    }
}
