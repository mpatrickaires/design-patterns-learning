using Composite.After.Models;
using Composite.After.Models.Interfaces;

namespace Composite.After
{
    public static class Factory
    {
        public static ISystemObject GetPopulatedSystemObject()
        {
            SystemFile file1 = new SystemFile("file1.exe", 200);
            SystemFile file2 = new SystemFile("file2.exe", 500);

            SystemFolder folder1 = new SystemFolder("folder1");
            folder1.Add(file1, file2);

            SystemFile file3 = new SystemFile("file3.exe", 1000);

            SystemFolder folder2 = new SystemFolder("folder2");
            folder2.Add(folder1);
            folder2.Add(file3);

            return folder2;
        }
    }
}
