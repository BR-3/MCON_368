namespace MCON_368.WinForm.UserControls
{
    partial class GroupChatControl
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
            chatNameLabel = new Label();
            memberCountLabel = new Label();
            chatCountLabel = new Label();
            memberCount = new Label();
            chatCount = new Label();
            SuspendLayout();
            // 
            // chatNameLabel
            // 
            chatNameLabel.AutoSize = true;
            chatNameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chatNameLabel.ForeColor = SystemColors.ButtonHighlight;
            chatNameLabel.Location = new Point(20, 0);
            chatNameLabel.Name = "chatNameLabel";
            chatNameLabel.Size = new Size(103, 21);
            chatNameLabel.TabIndex = 0;
            chatNameLabel.Text = "Chat Name";
            chatNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memberCountLabel
            // 
            memberCountLabel.AutoSize = true;
            memberCountLabel.BackColor = Color.FromArgb(255, 128, 0);
            memberCountLabel.ForeColor = SystemColors.ButtonHighlight;
            memberCountLabel.Location = new Point(3, 29);
            memberCountLabel.Name = "memberCountLabel";
            memberCountLabel.Size = new Size(25, 20);
            memberCountLabel.TabIndex = 1;
            memberCountLabel.Text = "99";
            // 
            // chatCountLabel
            // 
            chatCountLabel.AutoSize = true;
            chatCountLabel.BackColor = Color.FromArgb(255, 128, 0);
            chatCountLabel.ForeColor = SystemColors.ButtonHighlight;
            chatCountLabel.Location = new Point(115, 29);
            chatCountLabel.Name = "chatCountLabel";
            chatCountLabel.Size = new Size(25, 20);
            chatCountLabel.TabIndex = 2;
            chatCountLabel.Text = "99";
            // 
            // memberCount
            // 
            memberCount.AutoSize = true;
            memberCount.ForeColor = SystemColors.ButtonHighlight;
            memberCount.Location = new Point(3, 47);
            memberCount.Name = "memberCount";
            memberCount.Size = new Size(71, 20);
            memberCount.TabIndex = 3;
            memberCount.Text = "Members";
            // 
            // chatCount
            // 
            chatCount.AutoSize = true;
            chatCount.ForeColor = SystemColors.ButtonHighlight;
            chatCount.Location = new Point(95, 47);
            chatCount.Name = "chatCount";
            chatCount.Size = new Size(45, 20);
            chatCount.TabIndex = 4;
            chatCount.Text = "Chats";
            // 
            // GroupChatControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(chatCount);
            Controls.Add(memberCount);
            Controls.Add(chatCountLabel);
            Controls.Add(memberCountLabel);
            Controls.Add(chatNameLabel);
            Name = "GroupChatControl";
            Size = new Size(140, 67);
            Load += GroupChatControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chatNameLabel;
        private Label memberCountLabel;
        private Label chatCountLabel;
        private Label memberCount;
        private Label chatCount;
    }
}
