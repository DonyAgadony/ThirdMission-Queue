using System.Collections;

class Program
{
    public static void Main()
    {
        Queue queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(1);
    }

    public static Queue ReversedQueue(Queue Q1)
    {
        Queue Reversed = new();
        Stack temp = new();
        while (Q1.Count > 0)
        {
            temp.Push(Q1.Dequeue());
        }
        while (temp.Count > 0)
        {
            Reversed.Enqueue(temp.Pop());
        }
        return Reversed;
    }

    public static bool IsPalindrome(Queue Q1)
    {
        Queue Reversed = ReversedQueue(Q1);
        while (Q1.Count > 0)
        {
            if (Q1.Dequeue() != Reversed.Dequeue()) { return false; }
        }
        return true;
    }
}