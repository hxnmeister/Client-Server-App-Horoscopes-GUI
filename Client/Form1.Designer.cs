namespace Client
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
            this.ControllGroupBox = new System.Windows.Forms.GroupBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ServerStatusColorLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortInputTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPInputTextBox = new System.Windows.Forms.TextBox();
            this.PredictionRequestGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.PredictionRequestTextBox = new System.Windows.Forms.TextBox();
            this.PredictionsLogGroupBox = new System.Windows.Forms.GroupBox();
            this.PredictionsLogTextBox = new System.Windows.Forms.TextBox();
            this.ControllGroupBox.SuspendLayout();
            this.ConnectionParamsGroupBox.SuspendLayout();
            this.PredictionRequestGroupBox.SuspendLayout();
            this.PredictionsLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControllGroupBox
            // 
            this.ControllGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControllGroupBox.Controls.Add(this.StopButton);
            this.ControllGroupBox.Controls.Add(this.StartButton);
            this.ControllGroupBox.Controls.Add(this.ServerStatusColorLabel);
            this.ControllGroupBox.Controls.Add(this.ServerStatusLabel);
            this.ControllGroupBox.Location = new System.Drawing.Point(422, 143);
            this.ControllGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ControllGroupBox.Name = "ControllGroupBox";
            this.ControllGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ControllGroupBox.Size = new System.Drawing.Size(280, 123);
            this.ControllGroupBox.TabIndex = 3;
            this.ControllGroupBox.TabStop = false;
            this.ControllGroupBox.Text = "Control Buttons / Status";
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Crimson;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopButton.Location = new System.Drawing.Point(148, 58);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 47);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Break the connection.";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartButton.Location = new System.Drawing.Point(33, 58);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 47);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Establish a connection";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ServerStatusColorLabel
            // 
            this.ServerStatusColorLabel.AutoSize = true;
            this.ServerStatusColorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ServerStatusColorLabel.ForeColor = System.Drawing.Color.White;
            this.ServerStatusColorLabel.Location = new System.Drawing.Point(174, 32);
            this.ServerStatusColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerStatusColorLabel.Name = "ServerStatusColorLabel";
            this.ServerStatusColorLabel.Size = new System.Drawing.Size(42, 16);
            this.ServerStatusColorLabel.TabIndex = 2;
            this.ServerStatusColorLabel.Text = "       ";
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.AutoSize = true;
            this.ServerStatusLabel.Location = new System.Drawing.Point(30, 32);
            this.ServerStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(141, 16);
            this.ServerStatusLabel.TabIndex = 0;
            this.ServerStatusLabel.Text = " Connection Status:";
            // 
            // ConnectionParamsGroupBox
            // 
            this.ConnectionParamsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionParamsGroupBox.Controls.Add(this.PortLabel);
            this.ConnectionParamsGroupBox.Controls.Add(this.PortInputTextBox);
            this.ConnectionParamsGroupBox.Controls.Add(this.IPLabel);
            this.ConnectionParamsGroupBox.Controls.Add(this.IPInputTextBox);
            this.ConnectionParamsGroupBox.Location = new System.Drawing.Point(422, 13);
            this.ConnectionParamsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectionParamsGroupBox.Name = "ConnectionParamsGroupBox";
            this.ConnectionParamsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ConnectionParamsGroupBox.Size = new System.Drawing.Size(280, 123);
            this.ConnectionParamsGroupBox.TabIndex = 2;
            this.ConnectionParamsGroupBox.TabStop = false;
            this.ConnectionParamsGroupBox.Text = "Connection Parameters";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(30, 73);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(45, 16);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port: ";
            // 
            // PortInputTextBox
            // 
            this.PortInputTextBox.Location = new System.Drawing.Point(116, 70);
            this.PortInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortInputTextBox.MaxLength = 20;
            this.PortInputTextBox.Name = "PortInputTextBox";
            this.PortInputTextBox.Size = new System.Drawing.Size(132, 23);
            this.PortInputTextBox.TabIndex = 4;
            this.PortInputTextBox.Text = "9988";
            this.PortInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(30, 37);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(80, 16);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP Adress: ";
            // 
            // IPInputTextBox
            // 
            this.IPInputTextBox.Location = new System.Drawing.Point(116, 34);
            this.IPInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IPInputTextBox.MaxLength = 20;
            this.IPInputTextBox.Name = "IPInputTextBox";
            this.IPInputTextBox.Size = new System.Drawing.Size(132, 23);
            this.IPInputTextBox.TabIndex = 2;
            this.IPInputTextBox.Text = "127.0.0.1";
            this.IPInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PredictionRequestGroupBox
            // 
            this.PredictionRequestGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictionRequestGroupBox.Controls.Add(this.ClearButton);
            this.PredictionRequestGroupBox.Controls.Add(this.SendButton);
            this.PredictionRequestGroupBox.Controls.Add(this.PredictionRequestTextBox);
            this.PredictionRequestGroupBox.Location = new System.Drawing.Point(422, 273);
            this.PredictionRequestGroupBox.Name = "PredictionRequestGroupBox";
            this.PredictionRequestGroupBox.Size = new System.Drawing.Size(281, 269);
            this.PredictionRequestGroupBox.TabIndex = 4;
            this.PredictionRequestGroupBox.TabStop = false;
            this.PredictionRequestGroupBox.Text = "Prediction Request";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(150, 218);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(98, 45);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear Request";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(33, 218);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 45);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send Request";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PredictionRequestTextBox
            // 
            this.PredictionRequestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictionRequestTextBox.Enabled = false;
            this.PredictionRequestTextBox.Location = new System.Drawing.Point(6, 22);
            this.PredictionRequestTextBox.Multiline = true;
            this.PredictionRequestTextBox.Name = "PredictionRequestTextBox";
            this.PredictionRequestTextBox.Size = new System.Drawing.Size(269, 190);
            this.PredictionRequestTextBox.TabIndex = 0;
            // 
            // PredictionsLogGroupBox
            // 
            this.PredictionsLogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictionsLogGroupBox.Controls.Add(this.PredictionsLogTextBox);
            this.PredictionsLogGroupBox.Location = new System.Drawing.Point(12, 13);
            this.PredictionsLogGroupBox.Name = "PredictionsLogGroupBox";
            this.PredictionsLogGroupBox.Size = new System.Drawing.Size(403, 529);
            this.PredictionsLogGroupBox.TabIndex = 5;
            this.PredictionsLogGroupBox.TabStop = false;
            this.PredictionsLogGroupBox.Text = "Predictions";
            // 
            // PredictionsLogTextBox
            // 
            this.PredictionsLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionsLogTextBox.Location = new System.Drawing.Point(3, 19);
            this.PredictionsLogTextBox.Multiline = true;
            this.PredictionsLogTextBox.Name = "PredictionsLogTextBox";
            this.PredictionsLogTextBox.ReadOnly = true;
            this.PredictionsLogTextBox.Size = new System.Drawing.Size(397, 507);
            this.PredictionsLogTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.PredictionsLogGroupBox);
            this.Controls.Add(this.PredictionRequestGroupBox);
            this.Controls.Add(this.ControllGroupBox);
            this.Controls.Add(this.ConnectionParamsGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(731, 593);
            this.Name = "Form1";
            this.Text = "Horoscopes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ControllGroupBox.ResumeLayout(false);
            this.ControllGroupBox.PerformLayout();
            this.ConnectionParamsGroupBox.ResumeLayout(false);
            this.ConnectionParamsGroupBox.PerformLayout();
            this.PredictionRequestGroupBox.ResumeLayout(false);
            this.PredictionRequestGroupBox.PerformLayout();
            this.PredictionsLogGroupBox.ResumeLayout(false);
            this.PredictionsLogGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControllGroupBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ServerStatusColorLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.GroupBox ConnectionParamsGroupBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortInputTextBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox IPInputTextBox;
        private System.Windows.Forms.GroupBox PredictionRequestGroupBox;
        private System.Windows.Forms.GroupBox PredictionsLogGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox PredictionRequestTextBox;
        private System.Windows.Forms.TextBox PredictionsLogTextBox;
    }
}

