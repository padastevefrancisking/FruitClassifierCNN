﻿using System;
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
    public partial class RipeCucumberClassified : UserControl
    {
        public RipeCucumberClassified()
        {
            InitializeComponent();
        }

        private void enterAgain_gunaGradiantButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
