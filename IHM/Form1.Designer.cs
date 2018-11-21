namespace IHM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEname = new System.Windows.Forms.DataGridView();
            this.comboBoxLoc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.labelDetail = new System.Windows.Forms.Label();
            this.textBoxEname = new System.Windows.Forms.TextBox();
            this.textBoxHiredate = new System.Windows.Forms.TextBox();
            this.textBoxEmpno = new System.Windows.Forms.TextBox();
            this.textBoxSalaire = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEname)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewEname);
            this.panel1.Controls.Add(this.comboBoxLoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 219);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewEname
            // 
            this.dataGridViewEname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEname.Location = new System.Drawing.Point(9, 52);
            this.dataGridViewEname.Name = "dataGridViewEname";
            this.dataGridViewEname.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEname.TabIndex = 1;
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Location = new System.Drawing.Point(9, 9);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(197, 21);
            this.comboBoxLoc.TabIndex = 0;
            this.comboBoxLoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMAJ);
            this.panel2.Controls.Add(this.labelDetail);
            this.panel2.Controls.Add(this.textBoxEname);
            this.panel2.Controls.Add(this.textBoxHiredate);
            this.panel2.Controls.Add(this.textBoxEmpno);
            this.panel2.Controls.Add(this.textBoxSalaire);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 219);
            this.panel2.TabIndex = 2;
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(682, 17);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(75, 23);
            this.buttonMAJ.TabIndex = 5;
            this.buttonMAJ.Text = "Mise à Jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(9, 17);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(100, 13);
            this.labelDetail.TabIndex = 4;
            this.labelDetail.Text = "Détails de l\'employé";
            // 
            // textBoxEname
            // 
            this.textBoxEname.Location = new System.Drawing.Point(9, 88);
            this.textBoxEname.Name = "textBoxEname";
            this.textBoxEname.Size = new System.Drawing.Size(100, 20);
            this.textBoxEname.TabIndex = 3;
            // 
            // textBoxHiredate
            // 
            this.textBoxHiredate.Location = new System.Drawing.Point(9, 168);
            this.textBoxHiredate.Name = "textBoxHiredate";
            this.textBoxHiredate.Size = new System.Drawing.Size(100, 20);
            this.textBoxHiredate.TabIndex = 2;
            // 
            // textBoxEmpno
            // 
            this.textBoxEmpno.Location = new System.Drawing.Point(9, 51);
            this.textBoxEmpno.Name = "textBoxEmpno";
            this.textBoxEmpno.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpno.TabIndex = 1;
            // 
            // textBoxSalaire
            // 
            this.textBoxSalaire.Location = new System.Drawing.Point(9, 129);
            this.textBoxSalaire.Name = "textBoxSalaire";
            this.textBoxSalaire.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalaire.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEname)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEname;
        private System.Windows.Forms.ComboBox comboBoxLoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.TextBox textBoxEname;
        private System.Windows.Forms.TextBox textBoxHiredate;
        private System.Windows.Forms.TextBox textBoxEmpno;
        private System.Windows.Forms.TextBox textBoxSalaire;
    }
}

