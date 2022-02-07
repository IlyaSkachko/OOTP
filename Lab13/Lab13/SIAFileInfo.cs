
namespace Lab13
{ 
    public class SIAFileInfo
    { 
        public static void showFileInfo()
        {
            string path = @"D:\OOTP\Lab13\Log.txt";
            var file = new FileInfo(path);
            Console.WriteLine($"Путь к файлу: {showPathFile(file)}\nРазмер файла: {showLengthFile(file)}\n" +
                    $"Расширение файл: {showExtensionFile(file)}\nДата Создание: {showCreateTimeFile(file)}\n" +
                    $"Дата изменения: {showWriteTimeFile(file)}\n");
        }

        private static string showPathFile(FileInfo file) => file.DirectoryName;

        private static long showLengthFile(FileInfo file) => file.Length;

        private static string showExtensionFile(FileInfo file) => file.Extension;
         
        private static DateTime showCreateTimeFile(FileInfo file) =>  file.CreationTime;
        private static DateTime showWriteTimeFile(FileInfo file) =>  file.LastWriteTime;
    }
}
