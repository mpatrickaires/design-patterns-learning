using Adapter.Models.Interfaces;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Adapter.Services
{
    public class CurrencyExchangeDisplay
    {
        private string _currency;
        private IJsonData _currencyExchangeData;

        public CurrencyExchangeDisplay(string currency, IJsonData currencyExchangeData)
        {
            _currency = currency;
            _currencyExchangeData = currencyExchangeData;
        }

        public void DisplayData()
        {
            Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(_currencyExchangeData.GetData());

            Console.WriteLine($">> Currency Exchange for {_currency} <<");
            foreach (var item in data)
            {
                var currency = InsertWhiteSpaces(item.Key);
                var currencySymbol = GetCurrencySymbol(item.Key);
                var currencyValue = item.Value;

                Console.WriteLine($"\t{currency}: {currencySymbol} {currencyValue}");
            }
        }

        private string GetCurrencySymbol(string currency)
        {
            switch (currency)
            {
                case "BrazilianReal":
                    return "R$";
                case "CanadianDollar":
                    return "C$";
                case "JapaneseYen":
                    return "¥";
                default:
                    return String.Empty;
            }
        }

        private string InsertWhiteSpaces(string text)
        {
            return Regex.Replace
            (
                Regex.Replace
                (
                    text,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );

        }
    }
}
