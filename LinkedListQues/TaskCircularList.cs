using System;

namespace LinkedListQues
{
    public class TaskItem
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;

        public TaskItem(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Task ID: {TaskId}, " +
                $"Task Name: {TaskName}, " +
                $"Priority: {Priority}, " +
                $"Due Date: {DueDate:dd-MM-yyyy}"
            );
        }
    }
    public class TaskNode
    {
        public TaskItem Data;
        public TaskNode Next;

        public TaskNode(TaskItem data)
        {
            Data = data;
            Next = null;
        }
    }
    public class TaskCircularList
    {
        private TaskNode head;
        private TaskNode current;
        public void AddAtBeginning(TaskItem task)
        {
            TaskNode newNode = new TaskNode(task);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;

                current = head;

                Console.WriteLine("Task added at beginning.");
                return;
            }
            TaskNode last = head;
            while (last.Next != head)
            {
                last = last.Next;
            }
            newNode.Next = head;
            head = newNode;
            last.Next = head;

            Console.WriteLine("Task added at beginning.");
        }

        public void AddAtEnd(TaskItem task)
        {
            TaskNode newNode = new TaskNode(task);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;

                current = head;

                Console.WriteLine("Task added at end.");
                return;
            }
            TaskNode last = head;
            while (last.Next != head)
            {
                last = last.Next;
            }
            last.Next = newNode;
            newNode.Next = head;
            Console.WriteLine("Task added at end.");
        }
        public void AddAtPosition(TaskItem task, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(task);
                return;
            }

            if (head == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            TaskNode currentNode = head;

            for (int i = 1; i < position - 1; i++)
            {
                currentNode = currentNode.Next;

                if (currentNode == head)
                {
                    Console.WriteLine("Position out of range.");
                    return;
                }
            }
            TaskNode newNode = new TaskNode(task);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;

            Console.WriteLine($"Task added at position {position}.");
        }

        public void RemoveByTaskId(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }

            TaskNode currentNode = head;
            TaskNode previous = null;

            do
            {
                if (currentNode.Data.TaskId == taskId)
                {
                    if (currentNode == head &&
                        currentNode.Next == head)
                    {
                        head = null;
                        current = null;

                        Console.WriteLine("Task removed successfully.");
                        return;
                    }

                    if (currentNode == head)
                    {
                        TaskNode last = head;

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

                        Console.WriteLine("Task removed successfully.");
                        return;
                    }

                    previous.Next = currentNode.Next;

                    if (current == currentNode)
                    {
                        current = currentNode.Next;
                    }

                    Console.WriteLine("Task removed successfully.");
                    return;
                }

                previous = currentNode;
                currentNode = currentNode.Next;

            } while (currentNode != head);

            Console.WriteLine("Task not found.");
        }

        public void ViewCurrentTask()
        {
            if (current == null)
            {
                Console.WriteLine("No current task.");
                return;
            }

            Console.WriteLine("\nCurrent Task:");
            current.Data.Display();
        }
        public void MoveToNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            current = current.Next;

            Console.WriteLine("\nMoved to next task:");
            current.Data.Display();
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }

            Console.WriteLine("\n----- All Tasks -----");

            TaskNode currentNode = head;

            do
            {
                currentNode.Data.Display();
                currentNode = currentNode.Next;

            } while (currentNode != head);
        }

        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }
            TaskNode currentNode = head;
            bool found = false;
            do
            {
                if (currentNode.Data.Priority == priority)
                {
                    currentNode.Data.Display();
                    found = true;
                }

            currentNode = currentNode.Next;
            } while (currentNode != head);

            if (!found)
            {
                Console.WriteLine("No task found with this priority.");
            }
        }
    }
}