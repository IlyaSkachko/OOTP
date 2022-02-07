

namespace Lab9
{

    public class StrProcessing
    {

        string str = "Dafergrgr    erger, g ergreg erg, ergeg- er   erge        erger";


        public string Upper()
        {
            Console.WriteLine("Верхний регистр: \n"+str.ToUpper());
            Console.WriteLine();
            return str;
        }

        public string DeleteSpace()
        {
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            Console.WriteLine("Удаление лишних пробелов: \n" + str);
            Console.WriteLine();
            return str;
        }
        public string DeleteMarks()
        {
            while (str.Contains(','))
            {
                str = str.Replace(',', ' ');
                while(str.Contains('-'))
                {
                    str = str.Replace('-', ' ');
                }
            }
            Console.WriteLine("Удаление знаков припинания: \n" + str);
            Console.WriteLine();
            return str;
        }

        public string AddSymb()
        {

            str = String.Concat(str, " tkytkty tyk trjhd gfv vbtyj ");
            Console.WriteLine("Добавление в конец строки символов: \n" + str);
            Console.WriteLine();
            return str;
        }

        public string Sub()
        {
            str = str.Substring(40);
            Console.WriteLine("Удаление 40 символов в строке: \n" + str);
            Console.WriteLine();
            return str;
        }
    }
}
