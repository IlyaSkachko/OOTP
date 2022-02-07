using System;
using System.Collections.Generic;

namespace Lab4
{
    class Aviacompany
    {
        public static List<int> PasList = new List<int>();
        public static List<int> CList = new List<int>();
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

        public static List<int> Sort(List<int> pasengers)
        {
            pasengers.Sort();
            return pasengers;
        }



        public object Displayinfo()
        {
            Pasenger TU_124 = new();
            Pasenger TU_134 = new();
            Pasenger TU_154 = new();
            /*   Грузовые   */


            TU_134.capacity = (int)Capacity.f;
            TU_124.capacity = (int)Capacity.s;
            TU_154.capacity = (int)Capacity.th;




            PasList.Add(TU_154.capacity);
            PasList.Add(TU_124.capacity);
            PasList.Add(TU_134.capacity);

            Sort(PasList);
            foreach (object o in PasList)
            {
                Console.WriteLine(o);
            }
            return PasList;
        }
        public object CarList()
        {
            Cargo AN_124 = new();
            Cargo AN_144 = new();
            Cargo AN_174 = new();

            AN_124.capacity = (int)CargoCapacity.f;
            AN_144.capacity = (int)CargoCapacity.s;
            AN_174.capacity = (int)CargoCapacity.th;

            CList.Add(AN_124.capacity);
            CList.Add(AN_144.capacity);
            CList.Add(AN_174.capacity);

            Sort(CList);
            foreach (object o in CList)
            {
                Console.WriteLine(o);
            }
            return CList;
        }

    }
}
