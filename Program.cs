namespace PracticeGround
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int enteredNumber = int.Parse(Console.ReadLine());

            int squared = SqureMethod(enteredNumber);
            Console.WriteLine("The Square root of {0} is {1}", enteredNumber, squared);

            int cubed = CubeMethod(enteredNumber);
            Console.WriteLine("The Cube of {0} is {1}", enteredNumber, cubed);

        }
        public static int SqureMethod(int enteredNumber)
        {
            int answer = enteredNumber * enteredNumber;
            return answer;
            
        }
        public static int CubeMethod(int enteredNumber)
        {
            int answer = SqureMethod(enteredNumber) * enteredNumber;
            return answer; 
            
        }
     
    }
}