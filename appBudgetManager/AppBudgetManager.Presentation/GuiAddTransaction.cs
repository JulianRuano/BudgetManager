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
            comBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < objSystem.fldMyCategory.Count; i++)
            {
                comBoxCategory.Items.Add(objSystem.fldMyCategory[i].GetName());
            }
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtQuantity.Text);
            string description = txtDescription.Text;
            DateTime selectedDate = CalendarD.SelectionRange.Start;
            string dateString = selectedDate.ToString("dd-MM-yyyy");



            objSystem.CreateTransaction(0, quantity, dateString, description, objSystem.fldMyCategory[0], "Incomes");
            MessageBox.Show("Transaction added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuantity.Text = "";
            txtDescription.Text = "";
        }
    }
}
