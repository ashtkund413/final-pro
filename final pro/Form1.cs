using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainmenu mainmenu = new mainmenu();
            this.Controls.Add(mainmenu);
        }

        
    }
}
