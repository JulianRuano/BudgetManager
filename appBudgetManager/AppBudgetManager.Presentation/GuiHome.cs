﻿using AppBudGetManager.Domain.System;
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
                dataRow["ID"] = objSystem.GetClsBudGet().fldMyIncomes[i].GetIdTransaction();
                dataRow["Amount"] = objSystem.GetClsBudGet().fldMyIncomes[i].GetQuantity();
                dataRow["Date"] = objSystem.GetClsBudGet().fldMyIncomes[i].GetDate();
                dataRow["Category"] = objSystem.GetClsBudGet().fldMyIncomes[i].GetCategory().GetName();
                dataRow["Description"] = objSystem.GetClsBudGet().fldMyIncomes[i].GetDescription();
                dt.Rows.Add(dataRow);
            }
        }

        private void addTransaction_Click(object sender, System.EventArgs e)
        {
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
