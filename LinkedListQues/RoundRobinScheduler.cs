using System;

namespace RoundRobinScheduling
{
    public class Process
    {
        public int ProcessId;
        public int BurstTime;
        public int Priority;
        public int RemainingTime;
        public int CompletionTime;

        public Process(int processId, int burstTime, int priority)
        {
            ProcessId = processId;
            BurstTime = burstTime;
            Priority = priority;
            RemainingTime = burstTime;
            CompletionTime = 0;
        }

        public void Display()
        {
            Console.WriteLine($"Process ID: {ProcessId}, " +$"Burst Time: {BurstTime}, " +$"Remaining Time: {RemainingTime}, " +$"Priority: {Priority}");
        }
    }

    public class ProcessNode
    {
        public Process Data;
        public ProcessNode Next;

        public ProcessNode(Process data)
        {
            Data = data;
            Next = null;
        }
    }

    public class RoundRobinScheduler
    {
        private ProcessNode head;
        private ProcessNode current;

        private int totalProcesses;
        private int completedProcesses;
        private int totalWaitingTime;
        private int totalTurnAroundTime;

        public void AddProcess(Process process)
        {
            ProcessNode newNode = new ProcessNode(process);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                totalProcesses++;
                Console.WriteLine($"Process {process.ProcessId} added.");
                return;
            }

            ProcessNode last = head;
            while (last.Next != head)
            {
                last = last.Next;
            }
            last.Next = newNode;
            newNode.Next = head;
            totalProcesses++;
            Console.WriteLine($"Process {process.ProcessId} added.");
        }

        public void RemoveProcess(int processId)
        {
            if (head == null)
            {
                Console.WriteLine("Process list is empty.");
                return;
            }
            ProcessNode currentNode = head;
            ProcessNode previous = null;

            do
            {
                if (currentNode.Data.ProcessId == processId)
                {
                    if (currentNode == head &&
                        currentNode.Next == head)
                    {
                        head = null;
                        current = null;
                        Console.WriteLine( $"Process {processId} removed.");
                        return;
                    }

                    if (currentNode == head)
                    {
                        ProcessNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }
                        head = head.Next;
                        last.Next = head;
                        if (current == currentNode)
                        {
                            current = head;
                        }
                        Console.WriteLine($"Process {processId} removed.");
                        return;
                    }
                    previous.Next = currentNode.Next;
                    if (current == currentNode)
                    {
                        current = currentNode.Next;
                    }
                    Console.WriteLine( $"Process {processId} removed.");
                    return;
                }

                previous = currentNode;
                currentNode = currentNode.Next;
            } while (currentNode != head);
            Console.WriteLine( $"Process {processId} not found."
            );
        }


        public void SimulateRoundRobin(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes available.");
                return;
            }
            if (timeQuantum <= 0)
            {
                Console.WriteLine("Time quantum must be greater than 0.");
                return;
            }
            int currentTime = 0;
            int round = 1;
            Console.WriteLine("\n================================");
            Console.WriteLine("ROUND ROBIN SCHEDULING");
            Console.WriteLine("================================");

            while (head != null)
            {
                Console.WriteLine($"\n----- Round {round} -----");
                ProcessNode roundStart = current;

                do
                {
                    ProcessNode processNode = current;
                    current = current.Next;
                    Process process = processNode.Data;
                    Console.WriteLine( $"\nExecuting Process {process.ProcessId}");
                    int executionTime = Math.Min(
                        timeQuantum,
                        process.RemainingTime
                    );
                    process.RemainingTime -= executionTime;
                    currentTime += executionTime;
                    Console.WriteLine($"Executed for: {executionTime}" );
                    Console.WriteLine($"Remaining Time: {process.RemainingTime}");
                    if (process.RemainingTime == 0)
                    {
                        process.CompletionTime = currentTime;
                        completedProcesses++;
                        Console.WriteLine( $"Process {process.ProcessId} completed.");
                        RemoveProcess(process.ProcessId);
                        if (head == null)
                        {
                            break;
                        }
                    }

                    if (head == null)
                    {
                        break;
                    }
                    if (current == roundStart)
                    {
                        break;
                    }

                } while (true);
                DisplayProcesses();
                round++;
            }
            Console.WriteLine("\nAll processes completed.");
            CalculateAverageTimes();
        }

        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("Circular queue is empty."
                );
                return;
            }

            Console.WriteLine("\n----- Processes in Circular Queue -----");

            ProcessNode currentNode = head;

            do
            {
                currentNode.Data.Display();
                currentNode = currentNode.Next;

            } while (currentNode != head);
        }
        private void CalculateAverageTimes()
        {
            if (head != null)
            {
                Console.WriteLine("All processes must be completed before calculating averages.");
                return;
            }
        }
    }
}