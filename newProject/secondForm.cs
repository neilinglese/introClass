using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newProject
{
    public partial class secondForm : Form
    {
        string Name;
        public secondForm()
        {
            InitializeComponent();
        }

        public void loadVariables(string nameFromForm1)
        {
            Name = nameFromForm1;
            //nameFromForm1 = Name;
        }
        private void preForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 prevForm = new Form1();
            prevForm.ShowDialog();
            this.Close();
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            nameTxt.Text = Name;
        }
    }
}
