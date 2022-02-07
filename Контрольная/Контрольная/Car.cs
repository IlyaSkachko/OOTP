
namespace Exercise
{
    public class Car : ICloneable
    {
        public string volume;
        public string color;
        public string model;
        public string number;



        public object Clone()
        {
            return number;
        }

    
    
        // перегрузка
        public static string operator *(Car car1, Car car2)
        {
            return $"{car1.model} and {car2.model}";
        }
    
    }

    public class SuperCar:Car
    {
        public virtual void go()
        {
            Console.WriteLine("Поехали");
        }
    }

    public class VipCar : SuperCar
    {
        public override void go()
        {
            Console.WriteLine("Сели в машину");
            Console.WriteLine("Завели");
            Console.WriteLine("Поехали"); 
        }
    }

}
