using System;

namespace StackQueueQues
{
    class SortStack
    {
        public void Sort(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;

            int top = stack.Pop();
            Sort(stack);
            InsertSorted(stack, top);
        }

        private void InsertSorted(Stack<int> stack,int value)
        {
            if(stack.Count==0 || value <= stack.Peek())
            {
                stack.Push(value);
                return;
            }
            int top = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(top);
        }
    }
}