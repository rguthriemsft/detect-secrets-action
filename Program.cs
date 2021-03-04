using System;

namespace detect_secrets_action
{
    class Program
    {
        static void Main(string[] args)
        {
            secret="My super secret key"
            Console.WriteLine(String.Format("My secret value is {0}", secret));
        }
    }
}
