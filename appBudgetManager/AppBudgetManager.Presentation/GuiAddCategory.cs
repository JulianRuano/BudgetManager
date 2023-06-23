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
    public partial class GuiAddCategory : Form
    {
        private ClsSystemServices objSystemServices;
        public GuiAddCategory()
        {
            InitializeComponent();
            objSystemServices = ClsSystemServices.GetInstance();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;

            // add category
            objSystemServices.CreateCategory(0, name, description);
            MessageBox.Show("Category added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
            txtDescription.Text = "";
        }
    }
}
