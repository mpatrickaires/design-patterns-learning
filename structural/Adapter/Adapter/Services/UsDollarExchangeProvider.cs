using Adapter.Models.Interfaces;
using System.Xml.Linq;

namespace Adapter.Models
{
    public static class UsDollarExchangeProvider
    {
        public static IXmlData GetDollarExchange()
        {
            return new XmlData(XDocument.Parse
            (
                "<root>" +
                    "<BrazilianReal>4.70</BrazilianReal>" +
                    "<CanadianDollar>1.26</CanadianDollar>" +
                    "<JapaneseYen>126.37</JapaneseYen>" +
                "</root>"
            ));
        }
    }
}
