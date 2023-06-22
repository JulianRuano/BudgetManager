using appBudgetManager.Domain;
using AppBudGetManager.Domain.System;
using System.Data;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiHome : Form
    {
        private ClsSystemServices objSystemServices;
        private Form FormSecundarios = new Form();
        private DataTable dt = new DataTable();
        private Panel pnlMain;

        public GuiHome(Panel prmPanel)
        {
            InitializeComponent();
            pnlMain = prmPanel;
            objSystemServices = ClsSystemServices.GetInstance();
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Description");
            DGVHome.DataSource = dt;
            //Balance
            lblBalance.Text = objSystemServices.GetSystem().GetClsBudGet().GetBalance().ToString();
            lblAux.Text = objSystemServices.GetSystem().GetClsBudGet().GetTotalIncomes().ToString();

        }

        private void addTransaction_Click(object sender, System.EventArgs e)
        {
            AbrirForm(new GuiAddTransaction());           
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

        private void btnExpenses_Click(object sender, System.EventArgs e)
        {
            //Limpiar el DataTable
            dt.Clear();
            for (int i = 0; i < objSystemServices.GetSystem().GetClsBudGet().MyExpenses.Count; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["ID"] = objSystemServices.GetSystem().GetClsBudGet().MyExpenses[i].GetIdTransaction();
                dataRow["Amount"] = objSystemServices.GetSystem().GetClsBudGet().MyExpenses[i].GetQuantity();
                dataRow["Date"] = objSystemServices.GetSystem().GetClsBudGet().MyExpenses[i].GetDate();
                dataRow["Category"] = objSystemServices.GetSystem().GetClsBudGet().MyExpenses[i].GetCategory().GetName();
                dataRow["Description"] = objSystemServices.GetSystem().GetClsBudGet().MyExpenses[i].GetDescription();
                dt.Rows.Add(dataRow);
            }

            lblTypeBalance.Text = "Expenses";
            lblAux.Text = objSystemServices.GetSystem().GetClsBudGet().GetTotalExpenses().ToString();
        }

        private void btnIncomes_Click(object sender, System.EventArgs e)
        {
            //Limpiar el DataTable
            dt.Clear();
            for (int i = 0; i < objSystemServices.GetSystem().GetClsBudGet().MyIncomes.Count; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["ID"] = objSystemServices.GetSystem().GetClsBudGet().MyIncomes[i].GetIdTransaction();
                dataRow["Amount"] = objSystemServices.GetSystem().GetClsBudGet().MyIncomes[i].GetQuantity();
                dataRow["Date"] = objSystemServices.GetSystem().GetClsBudGet().MyIncomes[i].GetDate();
                dataRow["Category"] = objSystemServices.GetSystem().GetClsBudGet().MyIncomes[i].GetCategory().GetName();
                dataRow["Description"] = objSystemServices.GetSystem().GetClsBudGet().MyIncomes[i].GetDescription();
                dt.Rows.Add(dataRow);
            }

            lblTypeBalance.Text = "Incomes";
            lblAux.Text = objSystemServices.GetSystem().GetClsBudGet().GetTotalIncomes().ToString();

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            // Edit Transaction
            AbrirForm(new GuiAddTransaction(int.Parse(txtIdTransaction.Text),lblTypeBalance.Text));
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            // Delete Transaction
            objSystemServices.GetSystem().GetClsBudGet().DeleteTransaction(int.Parse(txtIdTransaction.Text), lblTypeBalance.Text);
        }
    }
}
