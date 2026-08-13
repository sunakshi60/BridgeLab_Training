using System;

namespace StackQueueQues
{
    class Program
    {
        public static void Main(string[] args)
        {
            //QueueUsingStacks queue = new QueueUsingStacks();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //Console.WriteLine("Dequeued: " + queue.Dequeue());
            //queue.Enqueue(40);
            //Console.WriteLine("Dequeued: " + queue.Dequeue());
            //Console.WriteLine("Dequeued: " + queue.Dequeue());


            //Stack<int> stack = new Stack<int>();
            //stack.Push(30);
            //stack.Push(10);
            //stack.Push(50);
            //stack.Push(20);
            //stack.Push(40);
            //Console.WriteLine("Original Stack:");
            //foreach (int item in stack)
            //{
            //    Console.Write(item + " ");
            //}
            //SortStack sorter = new SortStack();
            //sorter.Sort(stack);
            //Console.WriteLine("\n\nSorted Stack:");
            //foreach (int item in stack)
            //{
            //    Console.Write(item + " ");
            //}


            //int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            //StockSpan stockSpan = new StockSpan();
            //int[] result = stockSpan.CalculateSpan(prices);
            //Console.WriteLine("Stock Prices:");
            //foreach (int price in prices)
            //{
            //    Console.Write(price + " ");
            //}
            //Console.WriteLine("\n\nStock Span:");
            //foreach (int span in result)
            //{
            //    Console.Write(span + " ");
            //}

            //int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };
            //int k = 3;
            //SlidingWindowMaximum slidingWindow =new SlidingWindowMaximum();
            //int[] result =slidingWindow.FindMaximum(numbers, k);
            //Console.WriteLine("Array:");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine("\n\nWindow Size: " + k);
            //Console.WriteLine("\nMaximum of each window:");
            //foreach (int maximum in result)
            //{
            //    Console.Write(maximum + " ");
            //}


            //PetrolPump[] pumps =
            //{
            //new PetrolPump(6, 4),
            //new PetrolPump(3, 6),
            //new PetrolPump(7, 3)
            //};
            //CircularTour circularTour =new CircularTour();
            //int startingPoint = circularTour.FindStartingPoint(pumps);
            //if (startingPoint == -1)
            //{
            //    Console.WriteLine("Circular tour is not possible.");
            //}
            //else
            //{
            //    Console.WriteLine("Starting petrol pump index: "+ startingPoint);
            //}



            //    int[] numbers =
            //{
            //    6, -1, -3, 4, -2, 2, 4, 6, -12, -7
            //};
            //    Console.WriteLine("Array:");
            //    foreach (int number in numbers)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    Console.WriteLine("\n\nZero-Sum Subarrays:");
            //    ZeroSumSubarray zeroSum = new ZeroSumSubarray();
            //    zeroSum.FindSubarrays(numbers);



            //int[] numbers = { 2, 7, 11, 15 };
            //int target = 9;
            //Console.WriteLine("Array:");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine("\nTarget: " + target);
            //PairWithGivenSum pairFinder = new PairWithGivenSum();
            //pairFinder.FindPair(numbers, target);


            //    int[] numbers =
            //{
            //    100, 4, 200, 1, 3, 2
            //};
            //    Console.WriteLine("Array:");
            //    foreach (int number in numbers)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    LongestConsecutiveSequence sequence = new LongestConsecutiveSequence();
            //    int result = sequence.FindLongestSequence(numbers);
            //    Console.WriteLine("\n\nLongest Consecutive Sequence Length: "+ result);



            //CustomHashMap map = new CustomHashMap(5);
            //Console.WriteLine("INSERTING VALUES:");
            //map.Put(1, "Apple");
            //map.Put(2, "Banana");
            //map.Put(3, "Mango");
            //map.Put(6, "Orange");
            //map.Put(11, "Grapes");
            //map.Display();
            //Console.WriteLine("\nRETRIEVING VALUES:");
            //Console.WriteLine("Key 1: " + map.Get(1));
            //Console.WriteLine("Key 3: " + map.Get(3));
            //Console.WriteLine("Key 6: " + map.Get(6));
            //Console.WriteLine("\nUPDATING VALUE:");
            //map.Put(1, "Green Apple");
            //Console.WriteLine("Updated Key 1: " + map.Get(1));
            //Console.WriteLine("\nDELETING KEY 3:");
            //bool removed = map.Remove(3);
            //Console.WriteLine("Key 3 removed: " + removed);
            //Console.WriteLine("\nHASH MAP AFTER DELETE:");
            //map.Display();


            int[] numbers =
        {
            2, 7, 11, 15
        };
            int target = 9;
            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nTarget: " + target);
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.FindTwoSum(numbers, target);
            if (result.Length == 2)
            {
                Console.WriteLine($"\nIndices: [{result[0]}, {result[1]}]");
                Console.WriteLine($"Values: {numbers[result[0]]} + " +$"{numbers[result[1]]} = {target}");
            }
            else
            {
                Console.WriteLine("\nNo pair found.");
            }



            Console.ReadLine();
        }
    }
}