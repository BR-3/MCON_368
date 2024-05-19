
namespace MCON_368.WinForm
{
    partial class ChatForm
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
            exportButton = new Button();
            ChatPanel = new Panel();
            SuspendLayout();
            // 
            // exportButton
            // 
            exportButton.Location = new Point(476, 412);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(94, 29);
            exportButton.TabIndex = 1;
            exportButton.Text = "&Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // ChatPanel
            // 
            ChatPanel.AutoScroll = true;
            ChatPanel.Dock = DockStyle.Top;
            ChatPanel.Location = new Point(0, 0);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new Size(582, 406);
            ChatPanel.TabIndex = 2;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(ChatPanel);
            Controls.Add(exportButton);
            Name = "ChatForm";
            Text = "Chat Window";
            Load += ChatForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button exportButton;
        private Panel ChatPanel;
        private Label chatNameLabel;
    }
}