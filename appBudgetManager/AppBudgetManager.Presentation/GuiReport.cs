using appBudgetManager.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiReport : Form
    {
        ClsSystemServices objSystemServices;
        public GuiReport()
        {
            InitializeComponent();
            objSystemServices = ClsSystemServices.GetInstance();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime endDate = dateTimeEnd.Value;
            DateTime startDate = dateTimeStart.Value;
            if (endDate < startDate)
            {
                MessageBox.Show("The end date must be greater than the start date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string endDateString = endDate.ToString("dd-MM-yyyy");
                string startDateString = startDate.ToString("dd-MM-yyyy");
                
                MessageBox.Show("Report generated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
