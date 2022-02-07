
namespace Lab13
{
    public class SIALog
    {
        public static void WriteInTXT(string message)
        {

            using (var stream = new StreamWriter(@"D:\OOTP\Lab13\Log.txt", true))
            {
                stream.WriteLine($"{DateTime.Now.ToString()}\n{message}\n------------------------------");
            }
        }
    }
}
