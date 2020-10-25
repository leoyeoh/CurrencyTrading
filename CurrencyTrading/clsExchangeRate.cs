using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyTrading
{
    public class clsExchangeRate
    {
        //public enum TradingType
        //{
        //    Sell,
        //    Buy
        //}

        public string Disclaimer { get; set; }
        public string License { get; set; }
        public int TimeStamp { get; set; }
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }

       public decimal ConvertCurrency(string FromCurrCode, string ToCurrCode,decimal TradeValue)
        {
            decimal Value =0;

            if(Rates.Count > 2)
            {
                decimal FromAmt, ToAmt;

                decimal.TryParse(Rates[FromCurrCode].ToString(), out FromAmt);
                decimal.TryParse(Rates[ToCurrCode].ToString(), out ToAmt);

                Value = TradeValue * ToAmt / FromAmt;
            }
            return Value;
        }
    }
}