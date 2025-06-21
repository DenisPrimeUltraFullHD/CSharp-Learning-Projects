using System;

namespace cod
{
    class Program
    {
        public class MyStack<T>
        {
            private List<T> _items = new List<T>();

            public void Push(T item)
            {
                _items.Add(item);
            }

            public T Pop()
            {
                if (_items.Count == 0)
                    throw new InvalidOperationException("Стек Пуст");

                var last = _items[_items.Count - 1];
                _items.RemoveAt(_items.Count - 1);
                return last;
            }
            public int Count => _items.Count;
        }
        static void Main()
        {
            var stack = new MyStack<string>();
            stack.Push("Hello");
            stack.Push("Word");

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
        }
    }
}