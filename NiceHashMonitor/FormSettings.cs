using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiceHashAPI;

namespace NiceHashMonitor
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                List<string> __errorMessages = new List<string>();
                if (numericAPI_Id.Value <= 0)
                {
                    __errorMessages.Add(@"API Id должен быть задан.");
                    numericAPI_Id.BackColor = Color.MistyRose;
                }
                if (textBoxAPI_Key.Text.Length == 0)
                {
                    __errorMessages.Add(@"API Key должен быть задан.");
                    textBoxAPI_Key.BackColor = Color.MistyRose;
                }

                if (__errorMessages.Count > 0)
                {
                    e.Cancel = true;
                    string __messageText = "";
                    foreach (string __value in __errorMessages)
                    {
                        __messageText += Environment.NewLine + @"- " + __value;
                    }
                    MessageBox.Show(
                        @"Необходимо заполнить обязательные параметры:" + __messageText, 
                        @"Ошибка настройки", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                else
                {
                    NiceHashSettings __settings = NiceHashSettings.Instance;
                    __settings.API_Id = (Int32)numericAPI_Id.Value;
                    __settings.API_Key = textBoxAPI_Key.Text;
                    __settings.Key_2FA = textBoxKey_2FA.Text;
                    if (!NiceHashSettings.SaveSettings(__settings))
                    {
                        MessageBox.Show(
                            @"Произошла ошибка при сохранении параметров доступа." + Environment.NewLine +
                            @"Проверьте права доступа к папке с программой.",
                            @"Ошибка настройки",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // Установка значений параметров в поля формы
            numericAPI_Id.Value = NiceHashSettings.Instance.API_Id;
            textBoxAPI_Key.Text = NiceHashSettings.Instance.API_Key;
            textBoxKey_2FA.Text = NiceHashSettings.Instance.Key_2FA;
        }
    }
}
