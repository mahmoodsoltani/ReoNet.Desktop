using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_Component
{
    public partial class ExcelOptions : Form
    {
        public ExcelOptions()
        {
            InitializeComponent();
        }
        public ExcelOptions(List<string> availableFields)
        {
            InitializeComponent();

            foreach (string field in availableFields)
                chklst.Items.Add(field, true);
        }

        public static bool PathIsValid(string inputPath)
        {
            try
            {
                Path.GetFullPath(inputPath);
            }
            catch (PathTooLongException ex)
            {
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" && !PathIsValid(txtTitle.Text))
            {
                MessageBox.Show("???? ??? ???? ????? ?????? ??????");
                txtTitle.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }
        public string PrintTitle
        {
            get { return txtTitle.Text; }
        }




        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ExcelOptions_Load(object sender, EventArgs e)
        {

        }

    }
}