using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostenKostenCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Start()
        {
            return Convert.ToInt32(UD_Start.Value);
        }

        private int End()
        {
            return Convert.ToInt32(UD_end.Value);
        }

        private void UD_Start_ValueChanged(object sender, EventArgs e)
        {
            if (End() < Start())
            {
                UD_end.Value = Start();
            }
            Calculate();
        }

        private void UD_end_ValueChanged(object sender, EventArgs e)
        {
            if (End() < Start())
            {
                UD_Start.Value = End();
            }
            Calculate();
        }

        private void Calculate()
        {
            int result = 0;
            for (int i = Start(); i <= End(); i++)
            {
                if (i < 25)
                {
                    result += 100000;
                }
                else
                {
                    double bij = Math.Round(100000 + 200000 * Math.Log(i - 23, 2));
                    result += Convert.ToInt32(bij);
                }
            }

            if (result < 0)
            {
                UitslagValue.Text = "Bereik te groot!";
            }
            else
            {
                string uitslag = result.ToString("#,##0");
                UitslagValue.Text = Convert.ToString(uitslag);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
