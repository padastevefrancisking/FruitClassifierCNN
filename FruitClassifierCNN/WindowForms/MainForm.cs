using FruitClassifierCNN.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitClassifierCNN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fruitClassified1.Visible = false;
            fruitPicture_gunaPictureBox.Visible = false;
            fruitImage_gunaPanel.Visible = true;
        }

        private void esc_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enterImage_button_Click(object sender, EventArgs e)
        {          
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                try
                {
                    fruitPicture_gunaPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            fruitImage_gunaPanel.Visible = false;
            fruitPicture_gunaPictureBox.Visible = true;
        }

        private void gunaGradiantButton1_Click(object sender, EventArgs e)
        {
            fruitClassified1.Visible = true;
        }
    }
}
