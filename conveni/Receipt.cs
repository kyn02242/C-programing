using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conveni
{
    class Receipt
    {
        //public List<Goods> Merchant = new List<Goods>();
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }

        public int Paid { get; set; } // 지불된 금액
        public int Pay { get; set; } // 돈 낸 금액
        public int Change { get; set; } // 거스름돈
    }
}
