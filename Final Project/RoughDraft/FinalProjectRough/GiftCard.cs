using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRough
{
    public class GiftCard
    {
        private string _giftCardNum;
        private double _giftCardBalance;
        
        public GiftCard(string giftCardNum, double giftCardBalance)
        {
            _giftCardNum = giftCardNum;
            _giftCardBalance = giftCardBalance;
        }

        public string GiftCardNum { get; set; }

        public double GiftCardBalance { get; set; }
    }
}
