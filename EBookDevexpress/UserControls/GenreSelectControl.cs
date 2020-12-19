﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookDevexpress
{
    public partial class GenreSelectControl : UserControl
    {
        public GenreSelectControl()
        {
            InitializeComponent();
        }

        private void clGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = clGenre.Name;
            MessageBox.Show($"I clicked {text}");
        }
    }
}
