namespace PersonRegistrerare
{
    partial class WelcomeForm
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
            buttonPersReg = new Button();
            buttonAvbryt = new Button();
            SuspendLayout();
            // 
            // buttonPersReg
            // 
            buttonPersReg.Location = new Point(12, 12);
            buttonPersReg.Name = "buttonPersReg";
            buttonPersReg.Size = new Size(381, 68);
            buttonPersReg.TabIndex = 0;
            buttonPersReg.Text = "Starta Personregistrerare";
            buttonPersReg.UseVisualStyleBackColor = true;
            buttonPersReg.Click += buttonPersReg_Click;
            // 
            // buttonAvbryt
            // 
            buttonAvbryt.Location = new Point(399, 12);
            buttonAvbryt.Name = "buttonAvbryt";
            buttonAvbryt.Size = new Size(189, 68);
            buttonAvbryt.TabIndex = 1;
            buttonAvbryt.Text = "Avbryt";
            buttonAvbryt.UseVisualStyleBackColor = true;
            buttonAvbryt.Click += buttonAvbryt_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 92);
            Controls.Add(buttonAvbryt);
            Controls.Add(buttonPersReg);
            Name = "WelcomeForm";
            Text = "Kristoffers Inlämningsuppgift 3";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPersReg;
        private Button buttonAvbryt;
    }
}