using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.data
{
    class Date { 


        public bool Check { get; set; }
        public string Text { get; set; }
        public string Text1;
        private string ready;
        public string Ready
        {
            get
            {
                if (Check) { return "готово"; }
                else { return ready; }
            }
            set
            {
                ready = value;
            }
        }
        public int Number { get; set; }
    }
}
