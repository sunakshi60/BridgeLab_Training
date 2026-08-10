using System;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            //ReverseList.Solve();


            //List<string> fruits = new List<string>
            //{
            //    "apple","banana","apple","orange"
            //};
            //Dictionary<string, int> result = FindFrequency.Solve(fruits);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}


            //List<int> numbers = new List<int>
            //{
            //    10,20,30,40,50
            //};
            //int pos = 2;
            //List<int> rotated = RotateList.Solve(numbers, pos);
            //Console.WriteLine("Rotated List:");
            //foreach(int number in rotated)
            //{
            //    Console.Write(number + " ");
            //}


            //List<int> numbers = new List<int>
            //{
            //    3,1,2,2,3,4
            //};
            //List<int> uniqueNumbers = RemoveDupliactes.Solve(numbers);
            //Console.WriteLine("List after removing duplicates:");
            //foreach(int number in uniqueNumbers)
            //{
            //    Console.Write(number + " ");
            //}


            //LinkedList<string> letters = new LinkedList<string>();
            //letters.AddLast("A");
            //letters.AddLast("B");
            //letters.AddLast("C");
            //letters.AddLast("D");
            //letters.AddLast("E");
            //string result = NthElementFromEnd.Solve(letters, 2);
            //Console.WriteLine("Nth element from end: " + result);


            //HashSet<int> set1 = new HashSet<int>
            //{
            // 3,4,5 
            //};
            //HashSet<int> set2 = new HashSet<int>
            //{
            //    3, 2, 1
            //};
            //bool result = CheckSetsEqual.Solve(set1, set2);
            //Console.WriteLine(result);


            //HashSet<int> union= new HashSet<int>
            //{ 1, 2, 3 };
            //HashSet<int> intersection = new HashSet<int>
            //{
            //    3, 4, 5
            //};
            //Console.Write("Union: ");
            //foreach(int item in union)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.Write("Intersection: ");
            //foreach (int item in intersection)
            //{
            //    Console.Write(item + " ");
            //}


            //HashSet<int> set1 = new HashSet<int>
            //{
            //    1, 2, 3
            //};
            //HashSet<int> set2 = new HashSet<int>
            //{
            //    3, 4, 5
            //};
            //HashSet<int> result =
            //    SymmetricDifference.Solve(set1, set2);
            //Console.Write("Symmetric Difference: ");


            //foreach (int item in result)
            //{
            //    Console.Write(item + " ");
            //}


            //HashSet<int> numbers = new HashSet<int>
            //{
            //    5, 3, 9, 1
            //};
            //List<int> sortedList =SetToSortedList.Solve(numbers);
            //Console.Write("Sorted List: ");
            //foreach (int number in sortedList)
            //{
            //    Console.Write(number + " ");
            //}


            //HashSet<int> set1 = new HashSet<int>
            //{
            //    2, 3
            //};
            //HashSet<int> set2 = new HashSet<int>
            //{
            //    1, 2, 3, 4
            //};
            //bool result = CheckSubset.Solve(set1, set2);
            //Console.WriteLine("Is Set1 a subset of Set2? " + result);


            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //ReverseQueue.Solve(queue);
            //Console.Write("Reversed Queue: ");
            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}


            //int n = 5;
            //List<string> binaryNumbers = GenerateBinaryNumbers.Solve(n);
            //Console.Write("Binary Numbers: ");
            //foreach (string number in binaryNumbers)
            //{
            //    Console.Write(number + " ");
            //}

            //HospitalTriage.Solve();


            //string filePath = "input.txt";
            //Dictionary<string, int> frequency =WordFrequencyCounter.Solve(filePath);
            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}


            //Dictionary<string, int> map = new Dictionary<string, int>
            //{
            //    { "A", 1 },
            //    { "B", 2 },
            //    { "C", 1 }
            //};
            //Dictionary<int, List<string>> inverted = InvertMap.Solve(map);
            //foreach (var item in inverted)
            //{
            //    Console.Write(item.Key + " = [");
            //    foreach (string key in item.Value)
            //    {
            //        Console.Write(key + " ");
            //    }
            //    Console.WriteLine("]");
            //}


            //InsurancePolicyManagement insurance = new InsurancePolicyManagement();
            //Policy p1 = new Policy("P101","John","Health",DateTime.Today.AddDays(10));
            //Policy p2 = new Policy( "P102","Alice","Life", DateTime.Today.AddDays(60));
            //Policy p3 = new Policy("P103","Bob","Health",DateTime.Today.AddDays(20));
            //insurance.AddPolicy(p1);
            //insurance.AddPolicy(p2);
            //insurance.AddPolicy(p3);
            //insurance.AddPolicy(p1);
            //insurance.DisplayAllPolicies();
            //insurance.DisplayInsertionOrder();
            //insurance.DisplayExpiringSoon();


            //VotingSystem voting = new VotingSystem();
            //voting.CastVote("Alice");
            //voting.CastVote("Bob");
            //voting.CastVote("Alice");
            //voting.CastVote("Charlie");
            //voting.CastVote("Bob");
            //voting.CastVote("Alice");
            //voting.DisplayResults();
            //voting.DisplaySortedResults();
            //voting.DisplayVoteOrder();


            //ShoppingCart cart = new ShoppingCart();
            //cart.AddProduct("Laptop", 50000);
            //cart.AddProduct("Mouse", 1000);
            //cart.AddProduct("Keyboard", 2000);
            //cart.DisplayCart();
            //cart.DisplaySortedByPrice();


            BankingSystem bank = new BankingSystem();
            bank.AddAccount(101, 50000);
            bank.AddAccount(102, 20000);
            bank.AddAccount(103, 80000);
            bank.AddWithdrawalRequest(101, 5000);
            bank.AddWithdrawalRequest(103, 10000);
            bank.AddWithdrawalRequest(102, 25000);
            bank.ProcessWithdrawals();
            bank.DisplayAccountsByBalance();


            Console.ReadLine();
        }
    }
}