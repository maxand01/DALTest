﻿using BLLSalarie;
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

        private void dataGridViewEname_SelectionChanged(object sender, EventArgs e)
        {            
            if (dataGridViewEname.SelectedRows.Count != 0)
            {
                textBoxEmpno.Text = dataGridViewEname.CurrentRow.Cells["NumeroEmploye"].Value.ToString();
                textBoxEname.Text = dataGridViewEname.CurrentRow.Cells["NomEmploye"].Value.ToString();
                textBoxSalaire.Text = dataGridViewEname.CurrentRow.Cells["Salaire"].Value.ToString();
                textBoxHiredate.Text = dataGridViewEname.CurrentRow.Cells["Hiredate"].Value.ToString();

            }
            else
            {
                buttonMAJ.Enabled = false;
                textBoxEmpno.Text = "Non renseigné";
                textBoxEname.Text = "Non renseigné";
                textBoxSalaire.Text = "Non renseigné";
                textBoxHiredate.Text = "Non renseigné";
            }
                   
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            BLLEmploye objDALEmploye = new BLLEmploye();
            int nbLignes = objDALEmploye.UpdateDataEmploye(Convert.ToInt32(textBoxEmpno.Text), textBoxEname.Text);
            LoadDataGrid();
            MessageBox.Show(nbLignes.ToString() + " Lignes mise à jour!", "Nombre de Lignes mise à jour");

        }
    }
}
