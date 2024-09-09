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
    public partial class DesForm : Form
    {
        public DesForm()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cipherTextBox.Text = Ciphering.DesEncryption(plainTextBox.Text, keyTextBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherText = cipherTextBox.Text;
                string key = keyTextBox.Text;
                string plainText = Ciphering.DesDecryption(cipherText, key);
                plainTextBox.Text = plainText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
