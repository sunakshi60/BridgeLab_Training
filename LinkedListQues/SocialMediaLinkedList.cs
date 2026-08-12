using System;
using System.Collections.Generic;

namespace LinkedListQues
{
    public class User
    {
        public int UserId;
        public string Name;
        public int Age;
        public List<int> FriendIds;

        public User(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;

            FriendIds = new List<int>();
        }

        public void Display()
        {
            Console.WriteLine(
                $"User ID: {UserId}, Name: {Name}, Age: {Age}"
            );
        }
    }

    public class UserNode
    {
        public User Data;
        public UserNode Next;

        public UserNode(User data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SocialMediaLinkedList
    {
        private UserNode head;

        public void AddUser(User user)
        {
            UserNode newNode = new UserNode(user);

            if (head == null)
            {
                head = newNode;

                Console.WriteLine(
                    $"User {user.Name} added successfully."
                );

                return;
            }

            UserNode current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;

            Console.WriteLine(
                $"User {user.Name} added successfully."
            );
        }

        public User SearchByUserId(int userId)
        {
            UserNode current = head;

            while (current != null)
            {
                if (current.Data.UserId == userId)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }

        public User SearchByName(string name)
        {
            UserNode current = head;

            while (current != null)
            {
                if (current.Data.Name.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }

        public void AddFriendConnection(
            int userId1,
            int userId2)
        {
            User user1 = SearchByUserId(userId1);
            User user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine(
                    "One or both users not found."
                );

                return;
            }

            if (userId1 == userId2)
            {
                Console.WriteLine("A user cannot be their own friend.");
                return;
            }

            if (user1.FriendIds.Contains(userId2))
            {
                Console.WriteLine("Friend connection already exists.");
                return;
            }
            user1.FriendIds.Add(userId2);
            user2.FriendIds.Add(userId1);

            Console.WriteLine($"Friend connection added between " +$"{user1.Name} and {user2.Name}."
            );
        }

        public void RemoveFriendConnection(
            int userId1,
            int userId2)
        {
            User user1 = SearchByUserId(userId1);
            User user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            if (!user1.FriendIds.Contains(userId2))
            {
                Console.WriteLine("Friend connection does not exist.");
                return;
            }

            user1.FriendIds.Remove(userId2);
            user2.FriendIds.Remove(userId1);

            Console.WriteLine($"Friend connection removed between " +$"{user1.Name} and {user2.Name}.");
        }

        public void DisplayFriends(int userId)
        {
            User user = SearchByUserId(userId);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine($"\nFriends of {user.Name}:");

            if (user.FriendIds.Count == 0)
            {
                Console.WriteLine("No friends.");
                return;
            }

            foreach (int friendId in user.FriendIds)
            {
                User friend = SearchByUserId(friendId);

                if (friend != null)
                {
                    Console.WriteLine($"ID: {friend.UserId}, " +$"Name: {friend.Name}");
                }
            }
        }

        public void FindMutualFriends(
            int userId1,
            int userId2)
        {
            User user1 = SearchByUserId(userId1);
            User user2 = SearchByUserId(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            Console.WriteLine( $"\nMutual friends of " +$"{user1.Name} and {user2.Name}:");

            bool found = false;

            foreach (int friendId in user1.FriendIds)
            {
                if (user2.FriendIds.Contains(friendId))
                {
                    User mutualFriend = SearchByUserId(friendId);

                    if (mutualFriend != null)
                    {
                        Console.WriteLine($"ID: {mutualFriend.UserId}, " + $"Name: {mutualFriend.Name}"
                        );

                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No mutual friends." );
            }
        }

        public int CountFriends(int userId)
        {
            User user = SearchByUserId(userId);

            if (user == null)
            {
                return -1;
            }

            return user.FriendIds.Count;
        }


        public void DisplayFriendCounts()
        {
            if (head == null)
            {
                Console.WriteLine("No users available.");
                return;
            }

            UserNode current = head;
            Console.WriteLine( "\n----- Friend Count -----");

            while (current != null)
            {
                Console.WriteLine($"{current.Data.Name} " +$"-> {current.Data.FriendIds.Count} friends");
                current = current.Next;
            }
        }

        public void DisplayAllUsers()
        {
            if (head == null)
            {
                Console.WriteLine("No users available.");
                return;
            }

            UserNode current = head;

            Console.WriteLine("\n----- All Users -----");

            while (current != null)
            {
                current.Data.Display();
                current = current.Next;
            }
        }
    }
}