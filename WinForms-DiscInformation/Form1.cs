using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForms_DiscInformation
{
    public partial class FormDiskInformation : Form
    {
        public FormDiskInformation()
        {
            InitializeComponent();
        }

        private void FormDiskInformation_Load(object sender, EventArgs e)
        {
            comboBox.Items.AddRange(DriveInfo.GetDrives());
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo(comboBox.Text.Substring(0, 1));
            labelType.Text = driveInfo.DriveType.ToString();

            if (driveInfo.IsReady)
            {
                labelFormat.Text = driveInfo.DriveFormat;
                labelFreeSpace.Text = driveInfo.AvailableFreeSpace.ToPrettySize();
                labelFreeSize.Text = driveInfo.TotalFreeSpace.ToPrettySize();
                labelSize.Text = driveInfo.TotalSize.ToPrettySize();
            }
        }
    }
}
