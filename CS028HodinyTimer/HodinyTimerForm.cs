using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS028HodinyTimer
{
    public partial class HodinyTimerForm : Form
    {
        public HodinyTimerForm()
        {
            InitializeComponent();
        }

        private void aktualizaceTimer_Tick(object sender, EventArgs e)
        {
            hodinyLabel.Text = string.Format("aktuální datum a čas: {0}.{1}", DateTime.Now, DateTime.Now.Millisecond.ToString("D3"));
        }

        private void rizeniAktualizaceButton_Click(object sender, EventArgs e)
        {
            //aktualizaceTimer.Enabled = !aktualizaceTimer.Enabled;

            if (aktualizaceTimer.Enabled) 
            {
                rizeniAktualizaceButton.Text = "spustit aktualizaci";
                aktualizaceTimer.Stop();
            }
            else 
            {
                rizeniAktualizaceButton.Text = "zastavit aktualizaci";
                aktualizaceTimer.Start();
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            aktualizaceTimer.Interval = intervalScrollBar.Value;
            label1.Text = intervalScrollBar.Value.ToString();
        }

        
    }
}
