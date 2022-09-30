using ExcelDataReader;

namespace Iterator.After.IterableCollections
{
    public class UsersExcelCollection : IAsyncDisposable
    {
        private readonly FileStream _stream;

        public UsersExcelCollection(string path)
        {
            _stream = File.Open(path, FileMode.Open, FileAccess.Read);
        }

        public IExcelDataReader CreateReader()
        {
            return ExcelReaderFactory.CreateReader(_stream);
        }

        public async ValueTask DisposeAsync()
        {
            await _stream.DisposeAsync();
        }
    }
}
