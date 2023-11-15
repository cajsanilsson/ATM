using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning3Grafik
{
    public partial class MenuChoice : Form
    {
        public InsertControl GetInsCon1()
        {
            return InsCon1;
        }
        public MenuChoice()
        {
            InitializeComponent();
            InsCon1.Visible = false;
           
        }

         
        
    }
}
