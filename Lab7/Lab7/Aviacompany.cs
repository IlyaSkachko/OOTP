using System;
using System.Collections.Generic;

namespace Lab7
{
    class Aviacompany
    {
        public List<int> PasList = new List<int>();
        public List<int> CargoList = new List<int>();

        public Pasenger TU_124 = new();
        public Pasenger TU_134 = new();
        public Pasenger TU_154 = new();
        public Cargo AN_124 = new();
        public Cargo AN_144 = new();
        public Cargo AN_174 = new();


        public void AddPas(int pasenger)
        {
            this.PasList.Add(pasenger);
        }

        public void RemovePas(int pasenger)
        {
            this.PasList.Remove(pasenger);
        }

        public void AddCargo(int cargo)
        {
            this.CargoList.Add(cargo);
        }

        public void RemoveCargo(int cargo)
        {
            this.CargoList.Remove(cargo);
        }


        enum Capacity
        {
            f = 143,
            s = 512,
            th = 321
        }

        enum CargoCapacity
        {
            f = 124,
            s = 24,
            th = 200
        }

        public int Gas(int gas)
        {
            if(TU_124.gas == gas)
            {
                Console.WriteLine($"ТУ_124: {TU_124.gas}");
            }
            else if (TU_134.gas == gas)
            {
                Console.WriteLine($"ТУ_134: {TU_134.gas}");
            }
            else if (TU_154.gas == gas)
            {
                Console.WriteLine($"ТУ_154: {TU_154.gas}");
            }
            else if (AN_124.gas == gas)
            {
                Console.WriteLine($"AN_124: {AN_124.gas}");
            }
            else if (AN_144.gas == gas)
            {
                Console.WriteLine($"AN_144: {AN_144.gas}");
            }
            else if (AN_174.gas == gas)
            {
                Console.WriteLine($"AN_174: {AN_174.gas}");
            }
            else
            {
                Console.WriteLine("Содержимого нет!");
            }
            return gas;
        }


        public static List<int> Sort(List<int> pasengers)
        {
            pasengers.Sort();
            return pasengers;
        }

        public void PasInfo()
        {
            TU_154.capacity = (int)Capacity.th;
            TU_124.capacity = (int)Capacity.s;
            TU_134.capacity = (int)Capacity.f;


            AddPas(TU_154.capacity);
            AddPas(TU_124.capacity);
            AddPas(TU_134.capacity);
            PasList.Sort();

        }

        public void CargoInfo()
        {

            AN_124.capacity = (int)CargoCapacity.f;
            AN_144.capacity = (int)CargoCapacity.s;
            AN_174.capacity = (int)CargoCapacity.th;

            AddCargo(AN_174.capacity);
            AddCargo(AN_144.capacity);
            AddCargo(AN_124.capacity);

            CargoList.Sort();
        }



    }
}
