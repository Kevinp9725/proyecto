using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteleSys
{
    public partial class FormHome : Form
    {
        private bool clickMemReport;
        public FormHome()
        {
            InitializeComponent();
            clickMemReport = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }


        private void buttonReportes_Click(object sender, EventArgs e)
        {
            
            if (clickMemReport)
            {
                panelCategoriaReportes.Enabled = false;
                panelCategoriaReportes.Visible = false;
                clickMemReport = false;
            }
            else
            {
                panelCategoriaReportes.Enabled = true;
                panelCategoriaReportes.Visible = true;
                clickMemReport = true;
            }

        }

       
    }
}
