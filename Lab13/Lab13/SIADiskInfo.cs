using System.Text;

namespace Lab13
{
    public class SIADiskInfo
    {
        public static void showDriveInfo()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Имя Диска: {drive.Name}\nВсего места на диске: {showAllSpace(drive)} ГБ\n" +
                    $"Свободно места на диске: {showFreeSpace(drive)} ГБ\nМетка диска: {showMarkDrive(drive)}\n" +
                    $"Файловая система: {showFileFormat(drive)}\n");
            }

        }

        private static long showFreeSpace(DriveInfo drive)
        {
            return drive.AvailableFreeSpace / 1073741824;
        }

        private static long showAllSpace(DriveInfo drive)
        {
            return drive.TotalSize / 1073741824;
        }

        private static string showMarkDrive(DriveInfo drive)
        {
            return drive.VolumeLabel;
        }

        private static string showFileFormat(DriveInfo drive)
        {
            return drive.DriveFormat;
        }


    }
}
