using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThirdGenLocales;

namespace BadBuild
{
    public partial class UnrecognizedBuild : Form
    {
        ThirdGenLocales.LocaleInfo LI;


        public UnrecognizedBuild(string _build, ThirdGenLocales.LocaleInfo info)
        {
            InitializeComponent();
            LI = info;
            ChangeLabelText(_build);
        }

        public void ChangeLabelText(string _build)
        {
            labeltext.Text = "The build " + _build + " is not recognized, but the map appears to be third generation. You can add support in the source code.";
        }

        private void loadNoneButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void loadH3BButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.H3BFLLocales();
        }

        private void loadH3Button_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.H3FLLocales();
        }

        private void loadODSTButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.ODSTFLLocales();
        }

        private void loadReachBetaButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.ReachBetaFLLocales();
        }

        private void loadReachButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.ReachFLLocales();
        }

        private void loadH4Button_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.H4FLLocales();
        }

        private void loadH4NoRawButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            LI.H4NoRawFLLocales();
        }

    }
}
