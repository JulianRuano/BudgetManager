using AppBudGetManager.Domain.System;
using System;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiAddTransaction : Form
    {
        private ClsSystem objSystem;
        public GuiAddTransaction(ClsSystem prmSystem)
        {
            InitializeComponent();
            objSystem = prmSystem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtQuantity.Text);
            string description = txtDescription.Text;
            //DateTime date = Convert.ToDateTime(CalendarD);

            objSystem.CreateTransaction(1, quantity, default, description, objSystem.fldMyCategory[0], "Incomes");
            MessageBox.Show("Transaction added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuantity.Text = "";
            txtDescription.Text = "";
        }
    }
}
