using System;
using System.Collections;
using System.Collections.Generic;

namespace cod
{
    class FibonacciSequence : IEnumerable<long>, IEnumerator<long>
    {
        private readonly int _maxCount;
        private int _position;
        private long _previous;
        private long _current;

        public FibonacciSequence(int maxCount)
        {
            if (maxCount < 0)
                throw new ArgumentOutOfRangeException(nameof(maxCount));
            _maxCount = maxCount;

            Reset();
        }
        public IEnumerator<long> GetEnumerator()
        {
            return new FibonacciSequence(_maxCount);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public long Current
        {
            get
            {
                if (_position == 0 || _position > _maxCount)
                    throw new InvalidOperationException();
                return _current;
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_position >= _maxCount)
                return false;
            if (_position == 0)
            {
                _current = 0;
                _previous = 0;
            }
            else if (_position == 1)
            {
                _current = 1;
                _previous = 0;

            }
            else
            {
                long next = _previous + _current;

                _previous = _current;

                _current = next;
            }
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = 0;
            _current = 0;
            _previous = 0;
        }
        public void Dispose()
        {

        }
    }
    class Program
    {
        static void Main()
        {

            var fib10 = new FibonacciSequence(10);

            foreach (var f in fib10)

                System.Console.Write($"{f} ");
        }
    }
}