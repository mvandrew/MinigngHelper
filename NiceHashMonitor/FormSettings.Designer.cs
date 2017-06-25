namespace NiceHashMonitor
{
    partial class FormSettings
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
            this.labelAPI_Id = new System.Windows.Forms.Label();
            this.numericAPI_Id = new System.Windows.Forms.NumericUpDown();
            this.labelAPI_Key = new System.Windows.Forms.Label();
            this.textBoxAPI_Key = new System.Windows.Forms.TextBox();
            this.linkLabelGetKeys = new System.Windows.Forms.LinkLabel();
            this.label2FA_Key = new System.Windows.Forms.Label();
            this.textBoxKey_2FA = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPI_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAPI_Id
            // 
            this.labelAPI_Id.AutoSize = true;
            this.labelAPI_Id.Location = new System.Drawing.Point(12, 9);
            this.labelAPI_Id.Name = "labelAPI_Id";
            this.labelAPI_Id.Size = new System.Drawing.Size(41, 13);
            this.labelAPI_Id.TabIndex = 0;
            this.labelAPI_Id.Text = "API ID:";
            // 
            // numericAPI_Id
            // 
            this.numericAPI_Id.Location = new System.Drawing.Point(15, 25);
            this.numericAPI_Id.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericAPI_Id.Name = "numericAPI_Id";
            this.numericAPI_Id.Size = new System.Drawing.Size(119, 20);
            this.numericAPI_Id.TabIndex = 1;
            // 
            // labelAPI_Key
            // 
            this.labelAPI_Key.AutoSize = true;
            this.labelAPI_Key.Location = new System.Drawing.Point(12, 48);
            this.labelAPI_Key.Name = "labelAPI_Key";
            this.labelAPI_Key.Size = new System.Drawing.Size(48, 13);
            this.labelAPI_Key.TabIndex = 2;
            this.labelAPI_Key.Text = "API Key:";
            // 
            // textBoxAPI_Key
            // 
            this.textBoxAPI_Key.Location = new System.Drawing.Point(15, 64);
            this.textBoxAPI_Key.Name = "textBoxAPI_Key";
            this.textBoxAPI_Key.Size = new System.Drawing.Size(296, 20);
            this.textBoxAPI_Key.TabIndex = 3;
            // 
            // linkLabelGetKeys
            // 
            this.linkLabelGetKeys.AutoSize = true;
            this.linkLabelGetKeys.Location = new System.Drawing.Point(12, 87);
            this.linkLabelGetKeys.Name = "linkLabelGetKeys";
            this.linkLabelGetKeys.Size = new System.Drawing.Size(136, 13);
            this.linkLabelGetKeys.TabIndex = 4;
            this.linkLabelGetKeys.TabStop = true;
            this.linkLabelGetKeys.Text = "Получить API Id и API Key";
            // 
            // label2FA_Key
            // 
            this.label2FA_Key.AutoSize = true;
            this.label2FA_Key.Location = new System.Drawing.Point(12, 108);
            this.label2FA_Key.Name = "label2FA_Key";
            this.label2FA_Key.Size = new System.Drawing.Size(58, 13);
            this.label2FA_Key.TabIndex = 5;
            this.label2FA_Key.Text = "Ключ 2FA:";
            // 
            // textBoxKey_2FA
            // 
            this.textBoxKey_2FA.Location = new System.Drawing.Point(15, 124);
            this.textBoxKey_2FA.Name = "textBoxKey_2FA";
            this.textBoxKey_2FA.Size = new System.Drawing.Size(296, 20);
            this.textBoxKey_2FA.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(155, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(236, 150);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(323, 183);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxKey_2FA);
            this.Controls.Add(this.label2FA_Key);
            this.Controls.Add(this.linkLabelGetKeys);
            this.Controls.Add(this.textBoxAPI_Key);
            this.Controls.Add(this.labelAPI_Key);
            this.Controls.Add(this.numericAPI_Id);
            this.Controls.Add(this.labelAPI_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры доступа к Nice Hash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAPI_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAPI_Id;
        private System.Windows.Forms.NumericUpDown numericAPI_Id;
        private System.Windows.Forms.Label labelAPI_Key;
        private System.Windows.Forms.TextBox textBoxAPI_Key;
        private System.Windows.Forms.LinkLabel linkLabelGetKeys;
        private System.Windows.Forms.Label label2FA_Key;
        private System.Windows.Forms.TextBox textBoxKey_2FA;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}