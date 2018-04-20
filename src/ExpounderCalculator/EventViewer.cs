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
    public partial class EventViewer : Form
    {
        public EventViewer()
        {
            InitializeComponent();
        }

        private void EventViewer_Load(object sender, EventArgs e)
        {
            if (CalcForm.AllEventResult)
            {
                rtxtEventViewer.Text = CalcForm.AllEvent;
            }
            else
            {
                bool NotFoundAny = true;
                for (int i = 0; i < CalcForm.indexOfVar; i++)
                {
                    NotFoundAny = false;
                    rtxtEventViewer.AppendText(CalcForm.VarName[i].ToString() + " = "
                        + CalcForm.VarValue[i].ToString() + "\n");
                }
                if (NotFoundAny) rtxtEventViewer.Text = "You have not any variable!";
            }
        }
    }
}
