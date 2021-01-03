namespace Client
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.iconButton1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1117, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsers.Location = new System.Drawing.Point(0, 100);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(270, 620);
            this.panelUsers.TabIndex = 1;
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.panelChat.Location = new System.Drawing.Point(270, 100);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(889, 547);
            this.panelChat.TabIndex = 3;
            this.panelChat.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelChat_ControlAdded);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(1044, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(73, 49);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.panelMessage.Controls.Add(this.txtChat);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMessage.Location = new System.Drawing.Point(270, 612);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(847, 108);
            this.panelMessage.TabIndex = 4;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.txtChat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtChat.Location = new System.Drawing.Point(24, 33);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(790, 40);
            this.txtChat.TabIndex = 0;
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 720);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FlowLayoutPanel panelUsers;
        private System.Windows.Forms.FlowLayoutPanel panelChat;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.TextBox txtChat;
    }
}

