﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem4 {
    public partial class Form2 : Form {
        public Form2(List<Student> students) {
            InitializeComponent();
            textBox1.Text= students.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
