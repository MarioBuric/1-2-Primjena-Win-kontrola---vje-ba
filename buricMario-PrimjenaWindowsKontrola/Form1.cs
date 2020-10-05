using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricMario_PrimjenaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cmbPokreniProgram.SelectedItem == "Paint")
            Process.Start("mspaint.exe");
            else Process.Start("notepad.exe");

        }

        private void cmbShowProgAction_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOpis.Clear();

            txtIme.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select another button.", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
