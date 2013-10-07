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
        ThirdGenLocales.LocaleInfo LI = new ThirdGenLocales.LocaleInfo();

        public UnrecognizedBuild(string _build)
        {
            InitializeComponent();
            ChangeLabelText(_build);

            // Temporary "fix" until I can figure out force-loading as a different engine.
            overrideLabel.Hide();
            loadH3BButton.Hide();
            loadH3Button.Hide();
            loadODSTButton.Hide();
            loadReachBetaButton.Hide();
            loadReachButton.Hide();
            loadH4Button.Hide();
            loadH4NoRawButton.Hide();
            loadNoneButton.Location = new System.Drawing.Point(128, 75);
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
            MessageBox.Show("Coming soon");
        }

        private void loadH3Button_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

        private void loadODSTButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

        private void loadReachBetaButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

        private void loadReachButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

        private void loadH4Button_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

        private void loadH4NoRawButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MessageBox.Show("Coming soon");
        }

    }
}
