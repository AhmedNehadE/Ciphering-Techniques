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
    public partial class VigenereForm : Form
    {
        public VigenereForm()
        {
            InitializeComponent();
        }

        private void VigenereForm_Load(object sender, EventArgs e)
        {

        }
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherText = cipherTextBox.Text;
                string key = keyTextBox.Text;
                string plainText = Ciphering.VigenereDecrypt(cipherText, key);
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

        private void encryptBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                cipherTextBox.Text = Ciphering.VigenereEncrypt(plainTextBox.Text, keyTextBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
