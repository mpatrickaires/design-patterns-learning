namespace Composite.Before.Models
{
    public class SystemFolder
    {
        public string Name { get; set; }
        private List<SystemFile> _files = new List<SystemFile>();
        private List<SystemFolder> _folders = new List<SystemFolder>();

        public SystemFolder(string name)
        {
            Name = name;
        }

        public void AddFiles(params SystemFile[] file)
        {
            _files.AddRange(file);
        }

        public IEnumerable<SystemFile> GetFiles()
        {
            return _files;
        }

        public IEnumerable<SystemFolder> GetFolders()
        {
            return _folders;
        }

        public void AddFolders(params SystemFolder[] folder)
        {
            _folders.AddRange(folder);
        }
        //public int GetTotalSize()
        //{
        //    var totalSize = 0;

        //    foreach (var file in _files)
        //    {
        //        totalSize += file.Size;
        //    }

        //    foreach (var folder in _folders)
        //    {
        //        totalSize += folder.GetTotalSize();
        //    }

        //    return totalSize;
        //}
    }
}
