namespace Data.Structures
{
    using System;

    public class Stack<T>
    {
        private readonly T[] _stack;
        private readonly int _size;
        private int _topMostItemIndex = -1;

        public Stack(int size = 16)
        {
            _size = size;
            _stack = new T[size];
        }

        public bool IsEmpty => _topMostItemIndex == -1;
        private bool IsFull => _size == _topMostItemIndex + 1;

        public void Push(T value)
        {
            if (IsFull)
            {
                throw new Exception("Stack is full");
            }

            _stack[++_topMostItemIndex] = value;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            return _stack[_topMostItemIndex--];
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            return _stack[_topMostItemIndex];
        }
    }
}
