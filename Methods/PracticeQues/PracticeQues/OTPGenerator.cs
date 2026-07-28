using System;

namespace PracticeQues
{
    internal static class OTPGenerator
    {
        public static void Run()
        {
            int[] otpArray = GenerateOTPArray(10);
            Console.WriteLine("Generated OTPs:");
            foreach (int otp in otpArray)
            {
                Console.WriteLine(otp);
            }
            if (AreOTPsUnique(otpArray))
            {
                Console.WriteLine("\nAll OTPs are Unique.");
            }
            else
            {
                Console.WriteLine("\nDuplicate OTPs Found.");
            }
        }

        public static int GenerateOTP()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(100000, 1000000);
        }

        public static int[] GenerateOTPArray(int size)
        {
            int[] otpArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                otpArray[i] = GenerateOTP();
            }
            return otpArray;
        }

        public static bool AreOTPsUnique(int[] otpArray)
        {
            for (int i = 0; i < otpArray.Length - 1; i++)
            {
                for (int j = i + 1; j < otpArray.Length; j++)
                {
                    if (otpArray[i] == otpArray[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}