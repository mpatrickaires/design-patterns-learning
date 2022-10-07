using ExcelDataReader;
using Iterator.After.IterableCollections.Interfaces;
using Iterator.After.Iterators;
using Iterator.After.Iterators.Interfaces;

namespace Iterator.After.IterableCollections
{
    public class UsersExcelCollection : IIterableUsersCollection, IAsyncDisposable
    {
        private readonly FileStream _stream;
        private readonly IList<IExcelDataReader> _createdReaders = new List<IExcelDataReader>();

        public UsersExcelCollection(string path)
        {
            _stream = File.Open(path, FileMode.Open, FileAccess.Read);
        }


        public IExcelDataReader CreateReader()
        {
            var reader = ExcelReaderFactory.CreateReader(_stream);
            _createdReaders.Add(reader);
            return reader;
        }

        public IUsersIterator CreateIterator() => new UsersExcelIterator(this);

        public async ValueTask DisposeAsync()
        {
            await _stream.DisposeAsync();
            foreach (var reader in _createdReaders)
            {
                try
                {
                    reader.Dispose();
                }
                catch (ObjectDisposedException)
                {
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
