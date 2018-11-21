using BLLSalarie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

            BLLDepartement objDALDepartement = new BLLDepartement();
            comboBoxLoc.DataSource = objDALDepartement.LoadDataDepartement();
            comboBoxLoc.DisplayMember = "NomDepartement";
            comboBoxLoc.ValueMember = "NumeroDepartement";

            LoadDataGrid();

        }

        private void comboBoxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGrid();

        }

        private void LoadDataGrid()
        {
            BLLEmploye objDALEmploye = new BLLEmploye();
            if (comboBoxLoc.SelectedValue is int)
            {
                dataGridViewEname.DataSource = objDALEmploye.LoadDataEmployesByDeptno(Convert.ToInt32(comboBoxLoc.SelectedValue));
            }
        }
    }
}
