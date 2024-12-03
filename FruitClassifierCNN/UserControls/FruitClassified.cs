using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitClassifierCNN.UserControls
{
    public partial class FruitClassified : UserControl
    {
        Image fruitImage = null;
        public FruitClassified()
        {
            InitializeComponent();
            //Image image = Image.FromFile("C:\\miminig(2).jpeg");
            //fruitPicture_gunaPictureBox.Image = image;
        }

        private void enterAgain_gunaGradiantButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
