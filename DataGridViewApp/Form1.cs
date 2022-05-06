using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewApp
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.formulaOneDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formulaOneDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.formulaOneDataSet.Teams);

        }
    }
}
