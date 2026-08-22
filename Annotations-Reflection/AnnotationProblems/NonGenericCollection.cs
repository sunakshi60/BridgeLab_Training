using System.Collections;

namespace AnnotationProblems
{
    class NonGenericCollection
    {
        public void AddItems()
        {
            ArrayList list = new ArrayList();

#pragma warning disable CS0618

            list.Add(10);
            list.Add("Hello");
            list.Add(20.5);

#pragma warning restore CS0618

            Console.WriteLine("Items added successfully.");

            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}