using System;

namespace LinkedListQues
{
    public class Song
    {
        public string SongName;
        public string Artist;
        public double Duration;

        public Song(string songName, string artist, double duration)
        {
            SongName = songName;
            Artist = artist;
            Duration = duration;
        }

        public void Display()
        {
            Console.WriteLine($"Song: {SongName}, Artist: {Artist}, Duration: {Duration} min");
        }
    }

    public class SongNode
    {
        public Song Data;
        public SongNode Next;

        public SongNode(Song song)
        {
            Data = song;
            Next = this;
        }
    }

    public class Playlist
    {
        private SongNode head;

        private SongNode current;

        public Playlist()
        {
            head = null;
            current = null;
        }

        public void AddAtBeginning(Song song)
        {
            SongNode newNode = new SongNode(song);

            if (head == null)
            {
                head = newNode;
                current = head;
                Console.WriteLine("Song added at beginning.");
                return;
            }

            SongNode last = head;

            while (last.Next != head)
            {
                last = last.Next;
            }

            newNode.Next = head;
            last.Next = newNode;
            head = newNode;

            Console.WriteLine("Song added at beginning.");
        }

        public void AddAtEnd(Song song)
        {
            SongNode newNode = new SongNode(song);

            if (head == null)
            {
                head = newNode;
                current = head;

                Console.WriteLine("Song added at end.");

                return;
            }

            SongNode last = head;

            while (last.Next != head)
            {
                last = last.Next;
            }

            last.Next = newNode;

            newNode.Next = head;

            Console.WriteLine("Song added at end.");
        }

        public void AddAtPosition(Song song, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            if (position == 1)
            {
                AddAtBeginning(song);
                return;
            }

            if (head == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            SongNode newNode = new SongNode(song);

            SongNode currentNode = head;

            for (
                int i = 1;
                i < position - 1 && currentNode.Next != head;
                i++
            )
            {
                currentNode = currentNode.Next;
            }

            if (currentNode.Next == head && position > 2)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            newNode.Next = currentNode.Next;

            currentNode.Next = newNode;

            Console.WriteLine($"Song added at position {position}.");
        }

        public void DeleteSong(string songName)
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            if (
                head.Next == head &&
                head.Data.SongName.Equals(
                    songName,
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                head = null;
                current = null;

                Console.WriteLine("Song deleted successfully.");

                return;
            }

            if (
                head.Data.SongName.Equals(
                    songName,
                    StringComparison.OrdinalIgnoreCase
                )
            )
            {
                SongNode last = head;

                while (last.Next != head)
                {
                    last = last.Next;
                }

                head = head.Next;

                last.Next = head;

                if (current.Data.SongName.Equals(
                    songName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current = head;
                }

                Console.WriteLine("Song deleted successfully.");

                return;
            }

            SongNode previous = head;
            SongNode node = head.Next;

            while (node != head)
            {
                if (
                    node.Data.SongName.Equals(
                        songName,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                {
                    previous.Next = node.Next;

                    if (current == node)
                    {
                        current = node.Next;
                    }

                    Console.WriteLine(
                        "Song deleted successfully."
                    );

                    return;
                }

                previous = node;
                node = node.Next;
            }

            Console.WriteLine("Song not found.");
        }

        public void PlayNextSong()
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            current = current.Next;

            Console.WriteLine("\nNow Playing:");

            current.Data.Display();
        }

        public void DisplayPlaylist()
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            SongNode node = head;

            Console.WriteLine("\n========== PLAYLIST ==========");

            do
            {
                node.Data.Display();

                node = node.Next;

            } while (node != head);
        }
    }
}