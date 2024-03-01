using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 31; i++)
            {
                DayBox.Items.Add(i);    
            }
            for (int i = 1; i <= 12; i++)
            {
                MonthBox.Items.Add(i);
            }
         int crYear = DateTime.Now.Year;
            for (int i = 1900; i <= crYear; i++)
            {
                YearBox.Items.Add(i);
            }
        }
    }
}
