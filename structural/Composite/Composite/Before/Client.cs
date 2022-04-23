using Composite.Before.Models;

/*
 * Let's suppose we have a program that displays the total size of a certain set of files and folders.
 * Doing that without Composite, we would have a main program that is tightly coupled with the concrete 
 * implementation of both files and folders (SystemFile and SystemFolder). Also, the SystemFolder can 
 * store both files and folders (as in any computer system), thus it needs to have different attributes 
 * to represent a list of both.
 * Taking a look at the code below, we suppose the SystemFolder don't have its own implementation to
 * get the total size of all the files and folders that compose it, so we implemented this in the 
 * ClientBefore so that we could more easily see the messy code that it becomes. Notice how, at the 
 * GetTotalSize method, we have to treat the SystemFile and SystemFolder with different approaches 
 * by implementing a specific foreach to each type of class; this is a problem that the Compose 
 * looks to solve.
 */

namespace Composite.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            SystemFile file1 = new SystemFile("file1.exe", 200);
            SystemFile file2 = new SystemFile("file2.exe", 500);

            SystemFolder folder1 = new SystemFolder("folder1");
            folder1.AddFiles(file1, file2);

            SystemFile file3 = new SystemFile("file3.exe", 1000);

            SystemFolder folder2 = new SystemFolder("folder2");
            folder2.AddFolders(folder1);
            folder2.AddFiles(file3);

            Console.WriteLine("--> Total Size <--");
            Console.WriteLine($"{GetTotalSize(folder2)} MB");
        }

        private static int GetTotalSize(SystemFolder folderParam)
        {
            var totalSize = 0;

            IEnumerable<SystemFile> files = folderParam.GetFiles();

            foreach (SystemFile file in files)
            {
                totalSize += file.Size;
            }

            IEnumerable<SystemFolder> folders = folderParam.GetFolders();

            foreach (SystemFolder folder in folders)
            {
                totalSize += GetTotalSize(folder);
            }

            return totalSize;
        }
    }
}
