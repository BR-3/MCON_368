namespace MCON_368.WinForm.UserControls
{
    partial class DateTimeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DateTimeLabel = new Label();
            SuspendLayout();
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.Font = new Font("Segoe UI", 14F);
            DateTimeLabel.Location = new Point(37, 68);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(78, 32);
            DateTimeLabel.TabIndex = 0;
            DateTimeLabel.Text = "label1";
            // 
            // DateTimeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DateTimeLabel);
            Name = "DateTimeUserControl";
            Load += DateTimeUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateTimeLabel;
    }
}
