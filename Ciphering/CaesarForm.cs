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
    public partial class CaesarForm : Form
    {
        public CaesarForm()
        {
            InitializeComponent();
        }

        private void CaesarForm_Load(object sender, EventArgs e)
        {
            CaesarForm caesarForm = new CaesarForm();
            caesarForm.Size = new Size(1213, 109);
        }

        private void CaesarForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cipherTextBox.Text = Ciphering.CesarEncrypt(plainTextBox.Text, Convert.ToInt32(keyTextBox.Text));
                 
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
                int key = int.Parse(keyTextBox.Text);
                string plainText = Ciphering.CesarDecrypt(cipherText, key);
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
    }
}
