using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ChatApplicationMessageStore
{
    public class Sorting
    {
        public static void SortConversations(List<Conversation> conversations)
        {
            for (int i = 0; i < conversations.Count - 1; i++)
            {
                int largestIndex = i;
                for (int j = i + 1; j < conversations.Count; j++)
                {
                    if (conversations[j].LastActivity > conversations[largestIndex].LastActivity)
                    {
                        largestIndex = j;
                    }
                }

                Conversation temp = conversations[i];
                conversations[i] = conversations[largestIndex];
                conversations[largestIndex] = temp;
            }
        }
    }
}
