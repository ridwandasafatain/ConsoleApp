
namespace ValueTypeAndReferenceType
{
    class Program
    {
        public static void Main(string[] args)
        {
            ValueType();
            ReferenceType();
            Explanation();
        }

        //-- Value Type
        private static void ValueType()
        {
            int number1 = 10;
            int number2 = number1;
            number2 += 10;

            Console.WriteLine("Ini adalah Value Type :");
            Console.WriteLine(string.Format("number1 adalah {0}, number2 adalah {1}", number1, number2));
            Console.WriteLine("-----------------------");
        }

        //-- Reference Type
        private static void ReferenceType()
        {
            var car1 = new Car() 
            { 
                Name = "Toyota" 
            };
            var car2 = car1;
            car2.Name = "Daihatsu";

            Console.WriteLine("Ini adalah Reference Type :");
            Console.WriteLine(string.Format("car1 adalah {0}, car2 adalah {1}", car1.Name, car2.Name));
            Console.WriteLine("-----------------------");
        }

        //-- Explanation
        private static void Explanation()
        {
            Console.WriteLine("Penjelasan:");
            Console.WriteLine("Value type menyimpan data sebenarnya, sedangkan reference type menyimpan referensi ke data tersebut." +
                "\nDalam contoh ini, mengubah nilai 'number2' tidak mempengaruhi 'number1' karena mereka adalah salinan independen. " +
                "\nNamun, mengubah nama 'car2' mempengaruhi 'car1' karena mereka merujuk ke objek yang sama.");
        }
    }

    class Car
    {
        public string Name { get; set; } = string.Empty;
    }
}
