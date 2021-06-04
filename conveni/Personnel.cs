using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conveni
{
    class Personnel
    {
        public int Id { get; set; }
        public string Name { get; set; } // 직원 이름
        public string Date { get; set; } // 직원 일하는 시간
        public string WorkingTime { get; set; } 
        // 낮 저녁 새벽 3파트로 나뉨 , 각각 8시간
        public string Gender { get; set; } // 성별
        public int WorkedTime { get; set; } // 일한 시간
    }
}
