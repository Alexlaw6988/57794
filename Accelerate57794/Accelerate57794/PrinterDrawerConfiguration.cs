using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accelerate57794
{
    public partial class PrinterDrawerConfiguration : Form
    {
        List<Panel> PanelList = new List<Panel>();
        List<string> HeadingList = new List<string>();

        int index = 0;
        public PrinterDrawerConfiguration()
        {
            InitializeComponent();
        }

        private void OnCountrySelected(object sender, EventArgs e)
        {
            lblCountry.Text = ((RadioButton)sender).Text;
            lblCountry.Visible = true;
        }

        private void OnRegisterSelected(object sender, EventArgs e)
        {
            lblRT.Text = ((RadioButton)sender).Text;
            lblRT.Visible = true;
        }

        private void OnPrinterSelected(object sender, EventArgs e)
        {
            label1.Visible = true;
            lblPT.Text = ((RadioButton)sender).Text;
            lblPT.Visible = true;
        }

        private void OnCDSelected(object sender, EventArgs e)
        {
            label3.Visible = true;
            lblDT.Text = ((RadioButton)sender).Text;
            lblDT.Visible = true;
        }

        private void OnPulseSelected(object sender, EventArgs e)
        {
            label5.Visible = true;
            lblPulse.Text = ((RadioButton)sender).Text;
            lblPulse.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrinterDrawerConfiguration_Load(object sender, EventArgs e)
        {
            PanelList.Add(pnlCountry);
            PanelList.Add(pnlRT);
            PanelList.Add(pnlPT);
            PanelList.Add(pnlCD);
            PanelList.Add(pnlPulse);

            HeadingList.Add("Country Type :");
            HeadingList.Add("Register Type :");
            HeadingList.Add("Printer Type :");
            HeadingList.Add("Cash Drawer Type :");
            HeadingList.Add("Pulse :");

            PanelList[index].Visible = true;
            lblHeading.Text = HeadingList[index];

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;

            if (index >= 0)
            {
                PanelList[index].Visible = true;
                lblHeading.Text = HeadingList[index];

                if (index == 0)
                {
                    btnPrevious.Enabled = false;
                }
                if (index < PanelList.Count - 1)
                {
                    btnFinish.Visible = false;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (index < PanelList.Count)
            {
                PanelList[index].Visible = true;
                PanelList[index - 1].Visible = false;
                lblHeading.Text = HeadingList[index];
                btnPrevious.Enabled = true;

                if (index == PanelList.Count-1)
                {
                    btnFinish.Visible = true;
                }
                
            }
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printer and Cashdrawer Setup Completed successfully");
        }
    }
}
