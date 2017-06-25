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
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            // Проверка заполнения параметров доступа к сервису
            if (!NiceHashSettings.Instance.Sucsess)
            {
                FormSettings _settingsForm = new FormSettings();
                if (_settingsForm.ShowDialog() != DialogResult.OK || !NiceHashSettings.Instance.Sucsess)
                {
                    Application.Exit();
                }
            }
        }

        private void accessSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings __settingsForm = new FormSettings();
            __settingsForm.ShowDialog();
        }
    }
}
