namespace PersonRegistrerare
{
    partial class PersonRegistrerare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputFörnamn = new TextBox();
            inputEfternamn = new TextBox();
            inputPersonnummer = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            buttonOK = new Button();
            panel9 = new Panel();
            panel10 = new Panel();
            buttonAvbryt = new Button();
            panel11 = new Panel();
            panel12 = new Panel();
            outputTextbox = new TextBox();
            output = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // inputFörnamn
            // 
            inputFörnamn.Dock = DockStyle.Fill;
            inputFörnamn.Location = new Point(0, 0);
            inputFörnamn.Name = "inputFörnamn";
            inputFörnamn.PlaceholderText = "Namn";
            inputFörnamn.Size = new Size(310, 39);
            inputFörnamn.TabIndex = 0;
            // 
            // inputEfternamn
            // 
            inputEfternamn.Dock = DockStyle.Fill;
            inputEfternamn.Location = new Point(0, 0);
            inputEfternamn.Multiline = true;
            inputEfternamn.Name = "inputEfternamn";
            inputEfternamn.PlaceholderText = "Namnsson";
            inputEfternamn.Size = new Size(310, 44);
            inputEfternamn.TabIndex = 1;
            // 
            // inputPersonnummer
            // 
            inputPersonnummer.Dock = DockStyle.Fill;
            inputPersonnummer.Location = new Point(0, 0);
            inputPersonnummer.Multiline = true;
            inputPersonnummer.Name = "inputPersonnummer";
            inputPersonnummer.PlaceholderText = "198001011234";
            inputPersonnummer.Size = new Size(310, 44);
            inputPersonnummer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Controls.Add(panel6, 1, 2);
            tableLayoutPanel1.Controls.Add(panel7, 0, 3);
            tableLayoutPanel1.Controls.Add(panel8, 1, 3);
            tableLayoutPanel1.Controls.Add(panel9, 0, 4);
            tableLayoutPanel1.Controls.Add(panel10, 1, 4);
            tableLayoutPanel1.Controls.Add(panel11, 0, 5);
            tableLayoutPanel1.Controls.Add(panel12, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(526, 547);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(inputFörnamn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(213, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 44);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 44);
            label1.TabIndex = 0;
            label1.Text = "Förnamn";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 44);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 44);
            label2.TabIndex = 0;
            label2.Text = "Efternamn";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(inputEfternamn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(213, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(310, 44);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 44);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 44);
            label3.TabIndex = 0;
            label3.Text = "Personnummer";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(inputPersonnummer);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(213, 103);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 44);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 153);
            panel7.Name = "panel7";
            panel7.Size = new Size(204, 94);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(buttonOK);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(213, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(310, 94);
            panel8.TabIndex = 7;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.YellowGreen;
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(0, 0);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(310, 94);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 253);
            panel9.Name = "panel9";
            panel9.Size = new Size(204, 94);
            panel9.TabIndex = 8;
            // 
            // panel10
            // 
            panel10.Controls.Add(buttonAvbryt);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(213, 253);
            panel10.Name = "panel10";
            panel10.Size = new Size(310, 94);
            panel10.TabIndex = 9;
            // 
            // buttonAvbryt
            // 
            buttonAvbryt.BackColor = Color.FromArgb(255, 128, 128);
            buttonAvbryt.Dock = DockStyle.Fill;
            buttonAvbryt.Location = new Point(0, 0);
            buttonAvbryt.Name = "buttonAvbryt";
            buttonAvbryt.Size = new Size(310, 94);
            buttonAvbryt.TabIndex = 0;
            buttonAvbryt.Text = "Avbryt";
            buttonAvbryt.UseVisualStyleBackColor = false;
            buttonAvbryt.Click += buttonAvbryt_Click;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 353);
            panel11.Name = "panel11";
            panel11.Size = new Size(204, 191);
            panel11.TabIndex = 10;
            // 
            // panel12
            // 
            panel12.Controls.Add(outputTextbox);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(213, 353);
            panel12.Name = "panel12";
            panel12.Size = new Size(310, 191);
            panel12.TabIndex = 11;
            // 
            // outputTextbox
            // 
            outputTextbox.Dock = DockStyle.Fill;
            outputTextbox.Location = new Point(0, 0);
            outputTextbox.Multiline = true;
            outputTextbox.Name = "outputTextbox";
            outputTextbox.Size = new Size(310, 191);
            outputTextbox.TabIndex = 0;
            // 
            // output
            // 
            output.Dock = DockStyle.Fill;
            output.Location = new Point(0, 0);
            output.Name = "output";
            output.Size = new Size(974, 323);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // PersonRegistrerare
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 547);
            Controls.Add(tableLayoutPanel1);
            Name = "PersonRegistrerare";
            Text = "Personregistrerare";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox inputFörnamn;
        private TextBox inputEfternamn;
        private TextBox inputPersonnummer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonOK;
        private Button buttonAvbryt;
        private RichTextBox output;
        private TextBox outputTextbox;
    }
}