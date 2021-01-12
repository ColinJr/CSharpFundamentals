using System

namespace CSharpFundamentals
{
	public class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
            john.FirstName = "John";
            john.LastName = "Smith";
        }
    }
}