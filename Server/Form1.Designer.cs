namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectionParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.ControllGroupBox = new System.Windows.Forms.GroupBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPInputTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortInputTextBox = new System.Windows.Forms.TextBox();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.ServerStatusColorLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.BacklogGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BacklogTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionParamsGroupBox.SuspendLayout();
            this.ControllGroupBox.SuspendLayout();
            this.BacklogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionParamsGroupBox
            // 
            this.ConnectionParamsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionParamsGroupBox.Controls.Add(this.PortLabel);
            this.ConnectionParamsGroupBox.Controls.Add(this.PortInputTextBox);
            this.ConnectionParamsGroupBox.Controls.Add(this.IPLabel);
            this.ConnectionParamsGroupBox.Controls.Add(this.IPInputTextBox);
            this.ConnectionParamsGroupBox.Location = new System.Drawing.Point(471, 15);
            this.ConnectionParamsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectionParamsGroupBox.Name = "ConnectionParamsGroupBox";
            this.ConnectionParamsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectionParamsGroupBox.Size = new System.Drawing.Size(280, 123);
            this.ConnectionParamsGroupBox.TabIndex = 0;
            this.ConnectionParamsGroupBox.TabStop = false;
            this.ConnectionParamsGroupBox.Text = "Connection Parameters";
            // 
            // ControllGroupBox
            // 
            this.ControllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControllGroupBox.Controls.Add(this.StopButton);
            this.ControllGroupBox.Controls.Add(this.StartButton);
            this.ControllGroupBox.Controls.Add(this.ServerStatusColorLabel);
            this.ControllGroupBox.Controls.Add(this.ServerStatusLabel);
            this.ControllGroupBox.Location = new System.Drawing.Point(471, 145);
            this.ControllGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControllGroupBox.Name = "ControllGroupBox";
            this.ControllGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControllGroupBox.Size = new System.Drawing.Size(280, 123);
            this.ControllGroupBox.TabIndex = 1;
            this.ControllGroupBox.TabStop = false;
            this.ControllGroupBox.Text = "Control Buttons / Status";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(29, 39);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(80, 16);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP Adress: ";
            // 
            // IPInputTextBox
            // 
            this.IPInputTextBox.Location = new System.Drawing.Point(115, 36);
            this.IPInputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPInputTextBox.MaxLength = 20;
            this.IPInputTextBox.Name = "IPInputTextBox";
            this.IPInputTextBox.Size = new System.Drawing.Size(132, 23);
            this.IPInputTextBox.TabIndex = 2;
            this.IPInputTextBox.Text = "127.0.0.1";
            this.IPInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(29, 77);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(45, 16);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port: ";
            // 
            // PortInputTextBox
            // 
            this.PortInputTextBox.Location = new System.Drawing.Point(115, 74);
            this.PortInputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortInputTextBox.MaxLength = 20;
            this.PortInputTextBox.Name = "PortInputTextBox";
            this.PortInputTextBox.Size = new System.Drawing.Size(132, 23);
            this.PortInputTextBox.TabIndex = 4;
            this.PortInputTextBox.Text = "9988";
            this.PortInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.AutoSize = true;
            this.ServerStatusLabel.Location = new System.Drawing.Point(51, 32);
            this.ServerStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(110, 16);
            this.ServerStatusLabel.TabIndex = 0;
            this.ServerStatusLabel.Text = "Server Status: ";
            // 
            // ServerStatusColorLabel
            // 
            this.ServerStatusColorLabel.AutoSize = true;
            this.ServerStatusColorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ServerStatusColorLabel.ForeColor = System.Drawing.Color.White;
            this.ServerStatusColorLabel.Location = new System.Drawing.Point(162, 32);
            this.ServerStatusColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerStatusColorLabel.Name = "ServerStatusColorLabel";
            this.ServerStatusColorLabel.Size = new System.Drawing.Size(42, 16);
            this.ServerStatusColorLabel.TabIndex = 2;
            this.ServerStatusColorLabel.Text = "       ";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartButton.Location = new System.Drawing.Point(34, 68);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 37);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start Server";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Crimson;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopButton.Location = new System.Drawing.Point(148, 68);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 37);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop Server";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // BacklogGroupBox
            // 
            this.BacklogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BacklogGroupBox.Controls.Add(this.BacklogTextBox);
            this.BacklogGroupBox.Location = new System.Drawing.Point(16, 15);
            this.BacklogGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BacklogGroupBox.Name = "BacklogGroupBox";
            this.BacklogGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BacklogGroupBox.Size = new System.Drawing.Size(441, 705);
            this.BacklogGroupBox.TabIndex = 2;
            this.BacklogGroupBox.TabStop = false;
            this.BacklogGroupBox.Text = "Backlog";
            // 
            // BacklogTextBox
            // 
            this.BacklogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BacklogTextBox.Location = new System.Drawing.Point(4, 20);
            this.BacklogTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BacklogTextBox.Multiline = true;
            this.BacklogTextBox.Name = "BacklogTextBox";
            this.BacklogTextBox.ReadOnly = true;
            this.BacklogTextBox.Size = new System.Drawing.Size(433, 681);
            this.BacklogTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 740);
            this.Controls.Add(this.BacklogGroupBox);
            this.Controls.Add(this.ControllGroupBox);
            this.Controls.Add(this.ConnectionParamsGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(773, 779);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ConnectionParamsGroupBox.ResumeLayout(false);
            this.ConnectionParamsGroupBox.PerformLayout();
            this.ControllGroupBox.ResumeLayout(false);
            this.ControllGroupBox.PerformLayout();
            this.BacklogGroupBox.ResumeLayout(false);
            this.BacklogGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConnectionParamsGroupBox;
        private System.Windows.Forms.GroupBox ControllGroupBox;
        private System.Windows.Forms.TextBox IPInputTextBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortInputTextBox;
        private System.Windows.Forms.Label ServerStatusColorLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox BacklogGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox BacklogTextBox;
    }
}

