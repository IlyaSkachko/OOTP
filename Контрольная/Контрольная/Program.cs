
namespace Exercise
{

    class Exercise1
    {
        static int ArrSize(int[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main()
        {
            // Задание 1 


            int a = 9;
            // упаковка
            object obj = a;

            // распаковка
            a = (int)obj;


            int[,] arr = { { 1, 2, 3, 2 }, { 4, 6 , 6, 5}  };
            Console.WriteLine(ArrSize(arr));



            // Задание 2

            Car audi = new Car();
            Car bmw = new Car();


            
            audi.model = "audi";
            bmw.model = "bmw";

            Console.WriteLine(bmw * audi);


            // Задание 3


            SuperCar bugatti = new SuperCar();

            VipCar rolls_roys = new VipCar();

            Car[] cars = new Car[3];

            cars[0] = bmw;
            cars[1] = bugatti;
            cars[2] = rolls_roys;
            

            for (int i = 0;i < cars.Length;i++)
            {
                if (cars[i] is VipCar)
                {
                    VipCar other = new VipCar();
                    other =(VipCar)cars[i];
                    other.go();
                    
                }
            }
        }

    }

}    