using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpounderCalculator
{
    public partial class AnswerEventView : Form
    {
        public AnswerEventView()
        {
            InitializeComponent();
        }

        private void btnAllEvent_Click(object sender, EventArgs e)
        {
            CalcForm.AllEventResult = true;
            this.Close();
        }

        private void btnSavedEvent_Click(object sender, EventArgs e)
        {
            CalcForm.AllEventResult = false;
            this.Close();
        }
    }
}
