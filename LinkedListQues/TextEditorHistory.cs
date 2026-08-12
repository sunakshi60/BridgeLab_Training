using System;

namespace LinkedListQues
{
    public class TextState
    {
        public string Content;

        public TextState(string content)
        {
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine($"Current Text: {Content}");
        }
    }

    public class TextNode
    {
        public TextState Data;
        public TextNode Next;
        public TextNode Previous;

        public TextNode(TextState data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class TextEditorHistory
    {
        private TextNode head;
        private TextNode tail;
        private TextNode current;

        private int historySize;
        private int maxHistorySize;


        public TextEditorHistory(int maxHistorySize)
        {
            this.maxHistorySize = maxHistorySize;
            historySize = 0;
        }

        public void AddState(string content)
        {
            TextState newState = new TextState(content);

            TextNode newNode = new TextNode(newState);


            if (head == null)
            {
                head = newNode;
                tail = newNode;
                current = newNode;

                historySize++;

                Console.WriteLine(
                    "New text state added."
                );

                return;
            }

            if (current != tail)
            {
                TextNode nodeToRemove =
                    current.Next;

                while (nodeToRemove != null)
                {
                    historySize--;

                    nodeToRemove =
                        nodeToRemove.Next;
                }
                current.Next = null;
                tail = current;
            }

            newNode.Previous = tail;
            tail.Next = newNode;

            tail = newNode;
            current = newNode;
            historySize++;
            while (historySize > maxHistorySize)
            {
                RemoveOldestState();
            }
            Console.WriteLine("New text state added.");
        }

        private void RemoveOldestState()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
                current = null;
                historySize = 0;
                return;
            }
            head = head.Next;
            head.Previous = null;
            historySize--;
        }

        public void Undo()
        {
            if (current == null)
            {
                Console.WriteLine("No text state available.");
                return;
            }
            if (current.Previous == null)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }
            current = current.Previous;
            Console.WriteLine("Undo performed.");
            current.Data.Display();
        }

        public void Redo()
        {
            if (current == null)
            {
                Console.WriteLine("No text state available.");
                return;
            }
            if (current.Next == null)
            {
                Console.WriteLine("Nothing to redo.");
                return;
            }
            current = current.Next;
            Console.WriteLine("Redo performed.");
            current.Data.Display();
        }

        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("No text available.");
                return;
            }
            current.Data.Display();
        }

        public void DisplayHistory()
        {
            if (head == null)
            {
                Console.WriteLine("History is empty.");
               return;
            }

            Console.WriteLine("\n----- Text History -----");
            TextNode node = head;
            while (node != null)
            {
                string marker = node == current? " <-- CURRENT": "";
                Console.WriteLine(node.Data.Content + marker);
                node = node.Next;
            }
        }


        public void DisplayHistorySize()
        {
            Console.WriteLine($"History Size: {historySize}/{maxHistorySize}");
        }
    }
}