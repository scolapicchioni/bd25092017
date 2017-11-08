using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO02.Logic {
    public class AppsCollection
    {
        private App[] items = new App[10];
        private int count = 0;
        public int Count => count;
        public void Add(App item) {
            items[count++] = item;
        }
        public App this[int index] => items[index];

        //FIrst<int>
        public TypeToFind First<TypeToFind>()
            where TypeToFind : App {
            for (int i = 0; i < count; i++) {
                App app = items[i];
                if (app is TypeToFind) {
                    return (TypeToFind)app;
                }
            }
            return null;
        }

        
    }
}
