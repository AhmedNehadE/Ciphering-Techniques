using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciphering
{
    public partial class Form1 : Form
    {
        public static Form1 form1 = new Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            cesarbtn.BackColor = Color.Transparent;
            playfairbtn.BackColor = Color.Transparent;
            vigenerebtn.BackColor = Color.Transparent;
            desbtn.BackColor = Color.Transparent;

        }

        private void cesarbtn_Click(object sender, EventArgs e)
        {
            form1.Hide();
            CaesarForm caesarForm = new CaesarForm();
            caesarForm.Show();

        }

        private void vigenerebtn_Click(object sender, EventArgs e)
        {
            form1.Hide();
            VigenereForm vigenereForm = new VigenereForm();
            vigenereForm.Show();
        }

        private void playfairbtn_Click(object sender, EventArgs e)
        {
            form1.Hide();
            PlayFairForm playfairForm = new PlayFairForm();
            playfairForm.Show();
        }

        private void desbtn_Click(object sender, EventArgs e)
        {
            form1.Hide();
            DesForm desForm = new DesForm();
            desForm.Show();
        }
    }
}
