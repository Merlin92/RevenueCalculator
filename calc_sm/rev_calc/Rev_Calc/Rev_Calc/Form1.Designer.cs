namespace Rev_Calc
{
    partial class Form1
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
            this.TickGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassCTickTextBox = new System.Windows.Forms.TextBox();
            this.ClassBTickTextBox = new System.Windows.Forms.TextBox();
            this.ClassATickTextBox = new System.Windows.Forms.TextBox();
            this.ClassCTickLabel = new System.Windows.Forms.Label();
            this.ClassBTickLabel = new System.Windows.Forms.Label();
            this.ClassATickLabel = new System.Windows.Forms.Label();
            this.InstTickLabel = new System.Windows.Forms.Label();
            this.RevGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalOutputLabel = new System.Windows.Forms.Label();
            this.COutputLabel = new System.Windows.Forms.Label();
            this.BOutputLabel = new System.Windows.Forms.Label();
            this.AOutputLabel = new System.Windows.Forms.Label();
            this.TotalRevLabel = new System.Windows.Forms.Label();
            this.ClassCRevLabel = new System.Windows.Forms.Label();
            this.ClassBRevLabel = new System.Windows.Forms.Label();
            this.ClassARevLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TickGroupBox.SuspendLayout();
            this.RevGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TickGroupBox
            // 
            this.TickGroupBox.Controls.Add(this.ClassCTickTextBox);
            this.TickGroupBox.Controls.Add(this.ClassBTickTextBox);
            this.TickGroupBox.Controls.Add(this.ClassATickTextBox);
            this.TickGroupBox.Controls.Add(this.ClassCTickLabel);
            this.TickGroupBox.Controls.Add(this.ClassBTickLabel);
            this.TickGroupBox.Controls.Add(this.ClassATickLabel);
            this.TickGroupBox.Controls.Add(this.InstTickLabel);
            this.TickGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickGroupBox.Location = new System.Drawing.Point(12, 60);
            this.TickGroupBox.Name = "TickGroupBox";
            this.TickGroupBox.Size = new System.Drawing.Size(246, 177);
            this.TickGroupBox.TabIndex = 0;
            this.TickGroupBox.TabStop = false;
            this.TickGroupBox.Text = "Tickets Sold";
            // 
            // ClassCTickTextBox
            // 
            this.ClassCTickTextBox.Location = new System.Drawing.Point(93, 129);
            this.ClassCTickTextBox.Name = "ClassCTickTextBox";
            this.ClassCTickTextBox.Size = new System.Drawing.Size(100, 23);
            this.ClassCTickTextBox.TabIndex = 6;
            // 
            // ClassBTickTextBox
            // 
            this.ClassBTickTextBox.Location = new System.Drawing.Point(93, 100);
            this.ClassBTickTextBox.Name = "ClassBTickTextBox";
            this.ClassBTickTextBox.Size = new System.Drawing.Size(100, 23);
            this.ClassBTickTextBox.TabIndex = 5;
            // 
            // ClassATickTextBox
            // 
            this.ClassATickTextBox.Location = new System.Drawing.Point(93, 71);
            this.ClassATickTextBox.Name = "ClassATickTextBox";
            this.ClassATickTextBox.Size = new System.Drawing.Size(100, 23);
            this.ClassATickTextBox.TabIndex = 4;
            // 
            // ClassCTickLabel
            // 
            this.ClassCTickLabel.AutoSize = true;
            this.ClassCTickLabel.Location = new System.Drawing.Point(44, 132);
            this.ClassCTickLabel.Name = "ClassCTickLabel";
            this.ClassCTickLabel.Size = new System.Drawing.Size(43, 15);
            this.ClassCTickLabel.TabIndex = 3;
            this.ClassCTickLabel.Text = "Class C";
            // 
            // ClassBTickLabel
            // 
            this.ClassBTickLabel.AutoSize = true;
            this.ClassBTickLabel.Location = new System.Drawing.Point(44, 103);
            this.ClassBTickLabel.Name = "ClassBTickLabel";
            this.ClassBTickLabel.Size = new System.Drawing.Size(43, 15);
            this.ClassBTickLabel.TabIndex = 2;
            this.ClassBTickLabel.Text = "Class B";
            // 
            // ClassATickLabel
            // 
            this.ClassATickLabel.AutoSize = true;
            this.ClassATickLabel.Location = new System.Drawing.Point(43, 74);
            this.ClassATickLabel.Name = "ClassATickLabel";
            this.ClassATickLabel.Size = new System.Drawing.Size(44, 15);
            this.ClassATickLabel.TabIndex = 1;
            this.ClassATickLabel.Text = "Class A";
            // 
            // InstTickLabel
            // 
            this.InstTickLabel.Location = new System.Drawing.Point(22, 19);
            this.InstTickLabel.Name = "InstTickLabel";
            this.InstTickLabel.Size = new System.Drawing.Size(171, 42);
            this.InstTickLabel.TabIndex = 0;
            this.InstTickLabel.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // RevGroupBox
            // 
            this.RevGroupBox.Controls.Add(this.TotalOutputLabel);
            this.RevGroupBox.Controls.Add(this.COutputLabel);
            this.RevGroupBox.Controls.Add(this.BOutputLabel);
            this.RevGroupBox.Controls.Add(this.AOutputLabel);
            this.RevGroupBox.Controls.Add(this.TotalRevLabel);
            this.RevGroupBox.Controls.Add(this.ClassCRevLabel);
            this.RevGroupBox.Controls.Add(this.ClassBRevLabel);
            this.RevGroupBox.Controls.Add(this.ClassARevLabel);
            this.RevGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevGroupBox.Location = new System.Drawing.Point(271, 60);
            this.RevGroupBox.Name = "RevGroupBox";
            this.RevGroupBox.Size = new System.Drawing.Size(246, 177);
            this.RevGroupBox.TabIndex = 1;
            this.RevGroupBox.TabStop = false;
            this.RevGroupBox.Text = "Revenue Generated";
            // 
            // TotalOutputLabel
            // 
            this.TotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalOutputLabel.Location = new System.Drawing.Point(95, 129);
            this.TotalOutputLabel.Name = "TotalOutputLabel";
            this.TotalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalOutputLabel.TabIndex = 7;
            // 
            // COutputLabel
            // 
            this.COutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.COutputLabel.Location = new System.Drawing.Point(95, 100);
            this.COutputLabel.Name = "COutputLabel";
            this.COutputLabel.Size = new System.Drawing.Size(100, 23);
            this.COutputLabel.TabIndex = 6;
            // 
            // BOutputLabel
            // 
            this.BOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BOutputLabel.Location = new System.Drawing.Point(95, 71);
            this.BOutputLabel.Name = "BOutputLabel";
            this.BOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.BOutputLabel.TabIndex = 5;
            // 
            // AOutputLabel
            // 
            this.AOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AOutputLabel.Location = new System.Drawing.Point(95, 42);
            this.AOutputLabel.Name = "AOutputLabel";
            this.AOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.AOutputLabel.TabIndex = 4;
            // 
            // TotalRevLabel
            // 
            this.TotalRevLabel.AutoSize = true;
            this.TotalRevLabel.Location = new System.Drawing.Point(46, 132);
            this.TotalRevLabel.Name = "TotalRevLabel";
            this.TotalRevLabel.Size = new System.Drawing.Size(32, 15);
            this.TotalRevLabel.TabIndex = 3;
            this.TotalRevLabel.Text = "Total";
            // 
            // ClassCRevLabel
            // 
            this.ClassCRevLabel.AutoSize = true;
            this.ClassCRevLabel.Location = new System.Drawing.Point(46, 103);
            this.ClassCRevLabel.Name = "ClassCRevLabel";
            this.ClassCRevLabel.Size = new System.Drawing.Size(43, 15);
            this.ClassCRevLabel.TabIndex = 2;
            this.ClassCRevLabel.Text = "Class C";
            // 
            // ClassBRevLabel
            // 
            this.ClassBRevLabel.AutoSize = true;
            this.ClassBRevLabel.Location = new System.Drawing.Point(46, 74);
            this.ClassBRevLabel.Name = "ClassBRevLabel";
            this.ClassBRevLabel.Size = new System.Drawing.Size(43, 15);
            this.ClassBRevLabel.TabIndex = 1;
            this.ClassBRevLabel.Text = "Class B";
            // 
            // ClassARevLabel
            // 
            this.ClassARevLabel.AutoSize = true;
            this.ClassARevLabel.Location = new System.Drawing.Point(45, 46);
            this.ClassARevLabel.Name = "ClassARevLabel";
            this.ClassARevLabel.Size = new System.Drawing.Size(44, 15);
            this.ClassARevLabel.TabIndex = 0;
            this.ClassARevLabel.Text = "Class A";
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Calibri Light", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(385, 331);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(132, 11);
            this.ProgrammerLabel.TabIndex = 2;
            this.ProgrammerLabel.Text = "Programmed by Merlin Bierekofen";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(115, 261);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(92, 35);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "Calculate total &Revenue";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(224, 261);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(78, 35);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(319, 261);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 35);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.RevGroupBox);
            this.Controls.Add(this.TickGroupBox);
            this.Name = "Form1";
            this.Text = "Allianz Arena Seating";
            this.TickGroupBox.ResumeLayout(false);
            this.TickGroupBox.PerformLayout();
            this.RevGroupBox.ResumeLayout(false);
            this.RevGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TickGroupBox;
        private System.Windows.Forms.TextBox ClassCTickTextBox;
        private System.Windows.Forms.TextBox ClassBTickTextBox;
        private System.Windows.Forms.TextBox ClassATickTextBox;
        private System.Windows.Forms.Label ClassCTickLabel;
        private System.Windows.Forms.Label ClassBTickLabel;
        private System.Windows.Forms.Label ClassATickLabel;
        private System.Windows.Forms.Label InstTickLabel;
        private System.Windows.Forms.GroupBox RevGroupBox;
        private System.Windows.Forms.Label TotalOutputLabel;
        private System.Windows.Forms.Label COutputLabel;
        private System.Windows.Forms.Label BOutputLabel;
        private System.Windows.Forms.Label AOutputLabel;
        private System.Windows.Forms.Label TotalRevLabel;
        private System.Windows.Forms.Label ClassCRevLabel;
        private System.Windows.Forms.Label ClassBRevLabel;
        private System.Windows.Forms.Label ClassARevLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

