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
    public partial class PlayFairForm : Form
    {
        public PlayFairForm()
        {
            InitializeComponent();
        }

        private void PlayFairForm_Load(object sender, EventArgs e)
        {

        }
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ciphering.playfairKey.Clear();
                if (!Ciphering.GenerateMatrix(keyTextBox.Text))
                {
                    MessageBox.Show("Enter new key with no duplicates");
                }
                else
                {
                    matrixRichTextBox.Text = "";
                    for (int i = 0; i < 25; i++)
                    {
                        matrixRichTextBox.Text += (Ciphering.playfairKey[i].ToString() + ' ');
                        if (i % 5 == 4)
                        {
                            matrixRichTextBox.Text += '\n';
                        }
                    }
                    cipherTextBox.Text = Ciphering.PlayFairEncrypt(plainTextBox.Text);
                }

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
                Ciphering.playfairKey.Clear();
                if (!Ciphering.GenerateMatrix(keyTextBox.Text))
                {
                    MessageBox.Show("Enter new key with no duplicates");
                }
                else
                {
                    matrixRichTextBox.Text = "";
                    for (int i = 0; i < 25; i++)
                    {
                        matrixRichTextBox.Text += (Ciphering.playfairKey[i].ToString() + ' ');
                        if (i%5 == 4)
                        {
                            matrixRichTextBox.Text += '\n';
                        }
                    }
                    plainTextBox.Text = Ciphering.PlayFairDecrypt(cipherTextBox.Text);
                }

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
