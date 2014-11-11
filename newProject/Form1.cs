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
    public partial class Form1 : Form
    {

        bool hasChanged = false;
        string name;

        public Form1()
        {
            InitializeComponent();


        }

        private void nxtForm_Click(object sender, EventArgs e)
        {

            saveName();
            this.Hide();
            secondForm nextForm = new secondForm();
            nextForm.loadVariables(name);
            nextForm.ShowDialog();
            this.Close();
        }
        public void saveName()
        {
            if (nameBox.Text != "")
            {
                name = nameBox.Text;
            }
            else
            {
                name = "The Default Name";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form1Txt.Text = "Hello\nWorld";
            proBar.Value = 50;
            showEverything.Hide();
        }

        private void changeTxt_Click(object sender, EventArgs e)
        {
           

            if (hasChanged)
            {
                form1Txt.Text = "Hello\nWorld";
                changeTxt.Text = "Change Text";
                hasChanged = false;
                
            }
            else
            {
                form1Txt.Text = "GoodBye";
                changeTxt.Text = "New Text";
                hasChanged = true;

            }
        }

        private void barChange_Click(object sender, EventArgs e)
        {
            proBar.Value = 75;
            //proBar.BackColor = BackColor
        }

        private void showEverything_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void hideEverything_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void Hide()
        {
            myPanel.Hide();
            form1Txt.Hide();
            proBar.Hide();
            barChange.Hide();
            nxtForm.Hide();
            changeTxt.Hide();
            hideEverything.Hide();
            nameBox.Hide();
            label1.Hide();

            showEverything.Show();


        }

        public void Show()
        {
            myPanel.Show();
            form1Txt.Show();
            proBar.Show();
            barChange.Show();
            nxtForm.Show();
            changeTxt.Show();
            hideEverything.Show();
            nameBox.Show();
            label1.Show();

            showEverything.Hide();
        }
    }
}
