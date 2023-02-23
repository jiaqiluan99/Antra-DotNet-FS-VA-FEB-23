using System;
using System.Drawing;
using System.Reflection;

namespace Assignment04
{
    public class MyList<T>
    {
        T[] list;
        int count;
        int size;

        public MyList(int s) {
            size = s;
            list = new T[size];
            count = 0;
        }

        public MyList() : this(10) { }

        private bool CheckIndex(int idx) {
            return (idx > count || idx < 0);
        }

        private void NewList(int idx) {
            T[] nl = new T[count * 2];
            for (int i = 0; i < idx; i++) {
                nl[i] = list[i];
            }
            for (int j = idx; j < count; j++) {
                nl[j + 1] = list[j];
            }
            list = nl;
        }

        private void ShiftRight(int idx) {
            for (int i = count - 1; i >= idx; i--) {
                list[i + 1] = list[i];
            }
        }

        public void InsertAt(T element, int index) {
            if (CheckIndex(index)) {
                Console.WriteLine("Invalid Index!");
                return;
            }
            if (size == index) NewList(index);
            else ShiftRight(index);
            list[index] = element;
            count++;
        }

        public void Add(T element)
        {
            InsertAt(element, count);
        }

        public T Remove(int index) {
            if (CheckIndex(index) || index == count)
            {
                Console.WriteLine("Invalid Index!");
                return default(T);
            }
            T result = list[index];
            for (int i = index; i < count - 1; i++) {
                list[i] = list[i + 1];
            }
            count--;
            return result;
        }

        public void DeleteAt(int index) {
            Remove(index);
        }

        public void Clear() {
            list = new T[size];
            count = 0;
        }

        public bool Contains(T element) {
            for (int i = 0; i < count; i++) {
                if (list[i].Equals(element)) return true;
            }
            return false;
        }

        public T Find(int index) {
            if (CheckIndex(index) || index == count)
            {
                Console.WriteLine("Invalid Index!");
                return default(T);
            }
            return list[index];
        }

        public int Count() {
            return count;
        }


    }
}

