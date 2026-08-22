using System;

namespace AnnotationProblems
{
    class LegacyAPI
    {
        [Obsolete(" Please use NewFeature() instaed.")]
        public void OldFeature()
        {
            Console.WriteLine("Old feature is running");
        }

        public void NewFeature()
        {
            Console.WriteLine("New feature is running");
        }
    }
}