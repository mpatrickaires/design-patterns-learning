using Adapter.Models;
using Adapter.Models.Interfaces;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Adapter.After.ClassAdapter.Adapters
{
    public class XmlDataToJsonDataAdapter : XmlData, IXmlData, IJsonData
    {
        public XmlDataToJsonDataAdapter(XDocument data) : base(data)
        {
        }

        public string GetData()
        {
            var data = JsonConvert.SerializeXNode(GetXmlData(), Formatting.None, true);

            return data;
        }
    }
}
