using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    static class HistoryNBA
    {
        public static object Date { get; private set; }
        public static void getHowoldNBA(Label p)
        {
            DateTime d = DateTime.Now;
            int year = d.Year;
            int old = 1946;
            p.Text = "The current season is "+(year-1)+"–"+(year)+", and the NBA already has a history of "+(year-old)+" years";
        }
    }
}
