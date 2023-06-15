using AppBudGetManager.Domain.System;
using System.Data;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiHome : Form
    {
        private ClsSystem objSystem;
        private Form FormSecundarios = new Form();
        private DataTable dt = new DataTable();
        private Panel pnlMain;
        public GuiHome(ClsSystem prmSystem, Panel prmPanel)
        {
            InitializeComponent();
            objSystem = prmSystem;
            pnlMain = prmPanel;

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Description");
            DGVHome.DataSource = dt;

            for (int i = 0; i < objSystem.GetClsBudGet().fldMyIncomes.Count; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["ID"] = objSystem.GetClsBudGet().fldMyIncomes[0].GetIdTransaction();
                dataRow["Amount"] = objSystem.GetClsBudGet().fldMyIncomes[0].GetQuantity();
                dataRow["Date"] = objSystem.GetClsBudGet().fldMyIncomes[0].GetDate();
                dataRow["Category"] = objSystem.GetClsBudGet().fldMyIncomes[0].GetCategory().GetName();
                dataRow["Description"] = objSystem.GetClsBudGet().fldMyIncomes[0].GetDescription();
                dt.Rows.Add(dataRow);
            }
        }

        private void addTransaction_Click(object sender, System.EventArgs e)
        {
            objSystem.CreateCategory(1, "Food", "Food expenses");
            objSystem.CreateCategory(2, "Transport", "Transport expenses");
            objSystem.CreateCategory(3, "Salary", "Salary incomes");
            objSystem.CreateCategory(4, "Extra", "Extra incomes");

            AbrirForm(new GuiAddTransaction(objSystem));

            
        }

        private void AbrirForm(Form FormHijo)
        {
            if (FormSecundarios != null)
            {
                FormSecundarios.Close();
            }
            FormSecundarios = FormHijo;

            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(FormHijo);
            pnlMain.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }
    }
}
