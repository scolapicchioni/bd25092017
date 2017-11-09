using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO02.Logic {
    public delegate bool Inspector<T>(T element);
    public class Collection<TypeOfTheItem>
    {
        private TypeOfTheItem[] items = new TypeOfTheItem[10];
        private int count = 0;
        public int Count => count;
        public void Add(TypeOfTheItem item) {
            items[count++] = item;
        }
        public TypeOfTheItem this[int index] => items[index];

        public TypeToFind FirstOrDefault<TypeToFind>()
            where TypeToFind : TypeOfTheItem {
            for (int i = 0; i < count; i++) {
                TypeOfTheItem item = items[i];
                if (item is TypeToFind) {
                    return (TypeToFind)item;
                }
            }
            return default(TypeToFind);
        }

        public Collection<TypeOfTheItem> Filter(Inspector<TypeOfTheItem> dude) {
            Collection<TypeOfTheItem> result = new Collection<TypeOfTheItem>();

            for (int i = 0; i < count; i++) {
                if (dude(items[i])) {
                    result.Add(items[i]);
                }
            }

            return result;
        }
    }
}
