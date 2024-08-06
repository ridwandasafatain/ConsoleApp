
namespace Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Silahkan masukkan angka : ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int res)){
                Console.WriteLine("Silahkan masukkan angka!");
            }
            else
            {
                if (IsPalindrome(input))
                {
                    //- true
                    Console.WriteLine(string.Format("{0} adalah bilangan Palindrome", input));
                }
                else
                {
                    //- false
                    Console.WriteLine(string.Format("{0} bukan bilangan Palindrome", input));
                }
            }            
        }

        private static bool IsPalindrome(string number)
        {
            var result = false;
            var numberChar = number.ToCharArray();
            var numberReserved = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                numberReserved += numberChar[i];
            }
            if(number == numberReserved)
            {
                result = true;
            }

            return result;
        }
    }
}
