namespace VRChatAutoFishing
{
    partial class SettingsForm
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
            components = new System.ComponentModel.Container();
            tbcSettings = new TabControl();
            tabControl = new TabPage();
            lblOSCTip = new Label();
            lblOSCPort = new Label();
            tbOSCPort = new TextBox();
            tbOSCAddr = new TextBox();
            lblOSCAddr = new Label();
            tabWebhookNotification = new TabPage();
            webhookNotificationSettings = new WebhookNotificationSettingsControl();
            errorProvider = new ErrorProvider(components);
            tbcSettings.SuspendLayout();
            tabControl.SuspendLayout();
            tabWebhookNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tbcSettings
            // 
            tbcSettings.Controls.Add(tabControl);
            tbcSettings.Controls.Add(tabWebhookNotification);
            tbcSettings.Location = new Point(12, 12);
            tbcSettings.Name = "tbcSettings";
            tbcSettings.SelectedIndex = 0;
            tbcSettings.Size = new Size(384, 298);
            tbcSettings.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(lblOSCTip);
            tabControl.Controls.Add(lblOSCPort);
            tabControl.Controls.Add(tbOSCPort);
            tabControl.Controls.Add(tbOSCAddr);
            tabControl.Controls.Add(lblOSCAddr);
            tabControl.Location = new Point(4, 26);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Padding(3);
            tabControl.Size = new Size(376, 268);
            tabControl.TabIndex = 1;
            tabControl.Text = "控制";
            tabControl.UseVisualStyleBackColor = true;
            // 
            // lblOSCTip
            // 
            lblOSCTip.AutoSize = true;
            lblOSCTip.ForeColor = Color.FromArgb(192, 0, 0);
            lblOSCTip.Location = new Point(6, 43);
            lblOSCTip.Name = "lblOSCTip";
            lblOSCTip.Size = new Size(320, 17);
            lblOSCTip.TabIndex = 4;
            lblOSCTip.Text = "警告：请勿修改上述地址与端口，除非你知道自己在做什么";
            // 
            // lblOSCPort
            // 
            lblOSCPort.AutoSize = true;
            lblOSCPort.Location = new Point(246, 15);
            lblOSCPort.Name = "lblOSCPort";
            lblOSCPort.Size = new Size(32, 17);
            lblOSCPort.TabIndex = 3;
            lblOSCPort.Text = "端口";
            // 
            // tbOSCPort
            // 
            tbOSCPort.Location = new Point(284, 12);
            tbOSCPort.MaxLength = 5;
            tbOSCPort.Name = "tbOSCPort";
            tbOSCPort.PlaceholderText = "9000";
            tbOSCPort.Size = new Size(62, 23);
            tbOSCPort.TabIndex = 2;
            tbOSCPort.Text = "9000";
            // 
            // tbOSCAddr
            // 
            tbOSCAddr.Location = new Point(73, 12);
            tbOSCAddr.Name = "tbOSCAddr";
            tbOSCAddr.PlaceholderText = "127.0.0.1";
            tbOSCAddr.Size = new Size(140, 23);
            tbOSCAddr.TabIndex = 1;
            tbOSCAddr.Text = "127.0.0.1";
            // 
            // lblOSCAddr
            // 
            lblOSCAddr.AutoSize = true;
            lblOSCAddr.Location = new Point(6, 15);
            lblOSCAddr.Name = "lblOSCAddr";
            lblOSCAddr.Size = new Size(61, 17);
            lblOSCAddr.TabIndex = 0;
            lblOSCAddr.Text = "OSC 地址";
            // 
            // tabWebhookNotification
            // 
            tabWebhookNotification.Controls.Add(webhookNotificationSettings);
            tabWebhookNotification.Location = new Point(4, 26);
            tabWebhookNotification.Name = "tabWebhookNotification";
            tabWebhookNotification.Padding = new Padding(3);
            tabWebhookNotification.Size = new Size(376, 268);
            tabWebhookNotification.TabIndex = 0;
            tabWebhookNotification.Text = "Webhook 通知";
            tabWebhookNotification.UseVisualStyleBackColor = true;
            // 
            // webhookNotificationSettings
            // 
            webhookNotificationSettings.Location = new Point(9, 6);
            webhookNotificationSettings.Name = "webhookNotificationSettings";
            webhookNotificationSettings.Size = new Size(359, 247);
            webhookNotificationSettings.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 320);
            Controls.Add(tbcSettings);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "自动钓鱼 - 高级设置";
            tbcSettings.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabControl.PerformLayout();
            tabWebhookNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcSettings;
        private TabPage tabWebhookNotification;
        private WebhookNotificationSettingsControl webhookNotificationSettings;
        private TabPage tabControl;
        private Label lblOSCPort;
        private TextBox tbOSCPort;
        private TextBox tbOSCAddr;
        private Label lblOSCAddr;
        private Label lblOSCTip;
        private ErrorProvider errorProvider;
    }
}