using Adapter.Models.Interfaces;

namespace Adapter.Models
{
    public class JsonData : IJsonData
    {
        private string _data;

        public JsonData(string data)
        {
            _data = data;
        }

        public string GetData()
        {
            return _data;
        }
    }
}
