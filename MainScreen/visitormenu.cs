using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class visitormenu : Form
    {
        public visitormenu()
        {
            InitializeComponent();
            HistoryNBA.getHowoldNBA(labelInfo);

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
