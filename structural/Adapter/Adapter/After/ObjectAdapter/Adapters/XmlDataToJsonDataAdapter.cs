using Adapter.Models.Interfaces;
using Newtonsoft.Json;

namespace Adapter.After.ObjectAdapter.Adapters
{
    public class XmlDataToJsonDataAdapter : IJsonData
    {
        private IXmlData _xmlData;

        public XmlDataToJsonDataAdapter(IXmlData xmlData)
        {
            _xmlData = xmlData;
        }

        public string GetData()
        {
            // Converting from XML to a JSON string
            var data = JsonConvert.SerializeXNode(_xmlData.GetXmlData(), Formatting.None, true);

            return data;
        }
    }
}
