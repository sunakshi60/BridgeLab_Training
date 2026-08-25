using ChatApplicationMessageStore;

namespace ChatApplicationMessageStore
{
    public class EmojiList
    {
        private CircularLinkedList emojis;
        public EmojiList()
        {
            emojis = new CircularLinkedList();
        }
        public void AddEmoji(string emoji)
        {
            emojis.Add(emoji);
        }

        public string NextEmoji()
        {
            return emojis.Next();
        }

        public int Count
        {
            get { return emojis.Count; }
        }
    }
}