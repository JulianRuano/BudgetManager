using appBudgetManager.Domain;
using AppBudGetManager.Domain;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiUptadeTransaction : Form
    {
        private ClsSystemServices objSystemServices;
        private Dictionary<int, string> comboBoxItems;
        private int idTransaction;
        public GuiUptadeTransaction(int prmIdTransaction, string prmType)
        {
            InitializeComponent();
            loadData();
            idTransaction = prmIdTransaction;
            ClsTransaction objTransaction = objSystemServices.GetSystem().GetClsBudGet().TransactionExists(prmIdTransaction, prmType);
            txtQuantity.Text = objTransaction.GetQuantity().ToString();
            txtDescription.Text = objTransaction.GetDescription();
            comBoxCategory.SelectedItem = objTransaction.GetCategory().GetName();
            comboBoxType.SelectedItem = prmType;
        }

        private void loadData()
        {
            objSystemServices = ClsSystemServices.GetInstance();
            comBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItems = new Dictionary<int, string>();
            for (int i = 0; i < objSystemServices.GetSystem().fldMyCategory.Count; i++)
            {
                comboBoxItems.Add(objSystemServices.GetSystem().fldMyCategory[i].GetIdCategory(), objSystemServices.GetSystem().fldMyCategory[i].GetName());
            }
            foreach (var item in comboBoxItems)
            {
                comBoxCategory.Items.Add(item.Value);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtQuantity.Text);
            string description = txtDescription.Text;
            DateTime selectedDate = CalendarD.SelectionRange.Start;
            string dateString = selectedDate.ToString("dd-MM-yyyy");
            string type = this.comboBoxType.GetItemText(this.comboBoxType.SelectedItem);

            var selectedItem = comBoxCategory.SelectedItem.ToString();
            int idCategory = comboBoxItems.FirstOrDefault(x => x.Value == selectedItem).Key;

            objSystemServices.UpdateTransaction(idTransaction, quantity, dateString, description, objSystemServices.GetSystem().CategoryExists(idCategory), type);
            MessageBox.Show("Transition successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuantity.Text = "";
            txtDescription.Text = "";
        }
    }
}
