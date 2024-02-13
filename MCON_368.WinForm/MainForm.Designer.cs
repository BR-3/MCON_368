namespace MCON_368.WinForm
{
    partial class MainForm
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
            resultsLabel = new Label();
            firstNumberTextBox = new TextBox();
            secondNumberTextBox = new TextBox();
            calculate_Button = new Button();
            SuspendLayout();
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(364, 195);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(50, 20);
            resultsLabel.TabIndex = 2;
            resultsLabel.Text = "label1";
            // 
            // firstNumberTextBox
            // 
            firstNumberTextBox.Location = new Point(327, 146);
            firstNumberTextBox.Name = "firstNumberTextBox";
            firstNumberTextBox.Size = new Size(125, 27);
            firstNumberTextBox.TabIndex = 1;
            firstNumberTextBox.Text = "4";
            firstNumberTextBox.TextChanged += firstNumberTextBox_TextChanged_1;
            // 
            // secondNumberTextBox
            // 
            secondNumberTextBox.Location = new Point(327, 92);
            secondNumberTextBox.Name = "secondNumberTextBox";
            secondNumberTextBox.Size = new Size(125, 27);
            secondNumberTextBox.TabIndex = 0;
            secondNumberTextBox.Text = "3";
            // 
            // calculate_Button
            // 
            calculate_Button.Location = new Point(327, 228);
            calculate_Button.Name = "calculate_Button";
            calculate_Button.Size = new Size(125, 29);
            calculate_Button.TabIndex = 3;
            calculate_Button.Text = "Calculate";
            calculate_Button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculate_Button);
            Controls.Add(resultsLabel);
            Controls.Add(firstNumberTextBox);
            Controls.Add(secondNumberTextBox);
            Name = "MainForm";
            Text = "3";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultsLabel;
        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private Button calculate_Button;
    }
}
