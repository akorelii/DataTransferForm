using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransferForm
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Name = txtName.Text;
           string Surname = txtSurname.Text;
           string nameSurname = Name + " " + Surname;
           frmShowData frmShow = new frmShowData();
           frmShow.lblNameSurname.Text = nameSurname;
           frmShow.Show();
        }
    }
}
