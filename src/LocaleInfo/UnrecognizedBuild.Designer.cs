namespace BadBuild
{
    partial class UnrecognizedBuild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeltext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.overrideLabel = new System.Windows.Forms.Label();
            this.loadH3BButton = new System.Windows.Forms.Button();
            this.loadH3Button = new System.Windows.Forms.Button();
            this.loadODSTButton = new System.Windows.Forms.Button();
            this.loadReachBetaButton = new System.Windows.Forms.Button();
            this.loadReachButton = new System.Windows.Forms.Button();
            this.loadH4Button = new System.Windows.Forms.Button();
            this.loadH4NoRawButton = new System.Windows.Forms.Button();
            this.loadNoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(12, 9);
            this.labeltext.MaximumSize = new System.Drawing.Size(376, 39);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(53, 13);
            this.labeltext.TabIndex = 0;
            this.labeltext.Text = "Error Text";
            this.labeltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "  ______________________________________________  ";
            // 
            // overrideLabel
            // 
            this.overrideLabel.AutoSize = true;
            this.overrideLabel.Location = new System.Drawing.Point(105, 68);
            this.overrideLabel.Name = "overrideLabel";
            this.overrideLabel.Size = new System.Drawing.Size(190, 13);
            this.overrideLabel.TabIndex = 0;
            this.overrideLabel.Text = "Would you like to try loading anyways?";
            // 
            // loadH3BButton
            // 
            this.loadH3BButton.AutoSize = true;
            this.loadH3BButton.Location = new System.Drawing.Point(128, 92);
            this.loadH3BButton.Name = "loadH3BButton";
            this.loadH3BButton.Size = new System.Drawing.Size(144, 23);
            this.loadH3BButton.TabIndex = 2;
            this.loadH3BButton.Text = "Load as Halo 3 Beta";
            this.loadH3BButton.UseVisualStyleBackColor = true;
            this.loadH3BButton.Click += new System.EventHandler(this.loadH3BButton_Click);
            // 
            // loadH3Button
            // 
            this.loadH3Button.Location = new System.Drawing.Point(35, 123);
            this.loadH3Button.Name = "loadH3Button";
            this.loadH3Button.Size = new System.Drawing.Size(144, 23);
            this.loadH3Button.TabIndex = 3;
            this.loadH3Button.Text = "Load as Halo 3";
            this.loadH3Button.UseVisualStyleBackColor = true;
            this.loadH3Button.Click += new System.EventHandler(this.loadH3Button_Click);
            // 
            // loadODSTButton
            // 
            this.loadODSTButton.AutoSize = true;
            this.loadODSTButton.Location = new System.Drawing.Point(221, 123);
            this.loadODSTButton.Name = "loadODSTButton";
            this.loadODSTButton.Size = new System.Drawing.Size(144, 23);
            this.loadODSTButton.TabIndex = 4;
            this.loadODSTButton.Text = "Load as Halo 3: ODST";
            this.loadODSTButton.UseVisualStyleBackColor = true;
            this.loadODSTButton.Click += new System.EventHandler(this.loadODSTButton_Click);
            // 
            // loadReachBetaButton
            // 
            this.loadReachBetaButton.AutoSize = true;
            this.loadReachBetaButton.Location = new System.Drawing.Point(35, 154);
            this.loadReachBetaButton.Name = "loadReachBetaButton";
            this.loadReachBetaButton.Size = new System.Drawing.Size(144, 23);
            this.loadReachBetaButton.TabIndex = 5;
            this.loadReachBetaButton.Text = "Load as Halo: Reach Beta";
            this.loadReachBetaButton.UseVisualStyleBackColor = true;
            this.loadReachBetaButton.Click += new System.EventHandler(this.loadReachBetaButton_Click);
            // 
            // loadReachButton
            // 
            this.loadReachButton.Location = new System.Drawing.Point(221, 154);
            this.loadReachButton.Name = "loadReachButton";
            this.loadReachButton.Size = new System.Drawing.Size(144, 23);
            this.loadReachButton.TabIndex = 6;
            this.loadReachButton.Text = "Load as Halo: Reach";
            this.loadReachButton.UseVisualStyleBackColor = true;
            this.loadReachButton.Click += new System.EventHandler(this.loadReachButton_Click);
            // 
            // loadH4Button
            // 
            this.loadH4Button.Location = new System.Drawing.Point(35, 185);
            this.loadH4Button.Name = "loadH4Button";
            this.loadH4Button.Size = new System.Drawing.Size(144, 23);
            this.loadH4Button.TabIndex = 7;
            this.loadH4Button.Text = "Load as Halo 4";
            this.loadH4Button.UseVisualStyleBackColor = true;
            this.loadH4Button.Click += new System.EventHandler(this.loadH4Button_Click);
            // 
            // loadH4NoRawButton
            // 
            this.loadH4NoRawButton.Location = new System.Drawing.Point(221, 185);
            this.loadH4NoRawButton.Name = "loadH4NoRawButton";
            this.loadH4NoRawButton.Size = new System.Drawing.Size(144, 23);
            this.loadH4NoRawButton.TabIndex = 8;
            this.loadH4NoRawButton.Text = "Load as Halo 4 (No Raw)";
            this.loadH4NoRawButton.UseVisualStyleBackColor = true;
            this.loadH4NoRawButton.Click += new System.EventHandler(this.loadH4NoRawButton_Click);
            // 
            // loadNoneButton
            // 
            this.loadNoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loadNoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loadNoneButton.Location = new System.Drawing.Point(128, 234);
            this.loadNoneButton.Name = "loadNoneButton";
            this.loadNoneButton.Size = new System.Drawing.Size(144, 23);
            this.loadNoneButton.TabIndex = 1;
            this.loadNoneButton.Text = "No Thanks";
            this.loadNoneButton.UseVisualStyleBackColor = true;
            this.loadNoneButton.Click += new System.EventHandler(this.loadNoneButton_Click);
            // 
            // UnrecognizedBuild
            // 
            this.AcceptButton = this.loadNoneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.loadNoneButton;
            this.ClientSize = new System.Drawing.Size(394, 269);
            this.Controls.Add(this.loadH4NoRawButton);
            this.Controls.Add(this.loadH4Button);
            this.Controls.Add(this.loadReachButton);
            this.Controls.Add(this.loadReachBetaButton);
            this.Controls.Add(this.loadNoneButton);
            this.Controls.Add(this.loadODSTButton);
            this.Controls.Add(this.loadH3Button);
            this.Controls.Add(this.loadH3BButton);
            this.Controls.Add(this.overrideLabel);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 150);
            this.Name = "UnrecognizedBuild";
            this.ShowIcon = false;
            this.Text = "Error: Unrecognized Build";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label overrideLabel;
        private System.Windows.Forms.Button loadH3BButton;
        private System.Windows.Forms.Button loadH3Button;
        private System.Windows.Forms.Button loadODSTButton;
        private System.Windows.Forms.Button loadReachBetaButton;
        private System.Windows.Forms.Button loadReachButton;
        private System.Windows.Forms.Button loadH4Button;
        private System.Windows.Forms.Button loadH4NoRawButton;
        private System.Windows.Forms.Button loadNoneButton;
    }
}