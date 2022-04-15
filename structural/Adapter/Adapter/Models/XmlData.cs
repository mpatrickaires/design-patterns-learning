using Adapter.Models.Interfaces;
using System.Xml.Linq;

namespace Adapter.Models
{
    public class XmlData : IXmlData
    {
        private XDocument _data;

        public XmlData(XDocument data)
        {
            _data = data;
        }

        public XDocument GetXmlData()
        {
            return _data;
        }
    }
}
