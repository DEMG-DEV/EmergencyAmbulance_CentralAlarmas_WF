namespace EmergencyAmbulance_CentralAlarmas_WF
{
    partial class ListasEmergencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emergenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyDataSet = new EmergencyAmbulance_CentralAlarmas_WF.emergencyDataSet();
            this.emergenciasTableAdapter = new EmergencyAmbulance_CentralAlarmas_WF.emergencyDataSetTableAdapters.emergenciasTableAdapter();
            this.idEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entreCallesEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmergenciaDataGridViewTextBoxColumn,
            this.calleEmergenciaDataGridViewTextBoxColumn,
            this.coloniaEmergenciaDataGridViewTextBoxColumn,
            this.numeroEmergenciaDataGridViewTextBoxColumn,
            this.cpEmergenciaDataGridViewTextBoxColumn,
            this.ciudadEmergenciaDataGridViewTextBoxColumn,
            this.estadoEmergenciaDataGridViewTextBoxColumn,
            this.entreCallesEmergenciaDataGridViewTextBoxColumn,
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn,
            this.ubicacionEmergencia});
            this.dataGridView1.DataSource = this.emergenciasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(904, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // emergenciasBindingSource
            // 
            this.emergenciasBindingSource.DataMember = "emergencias";
            this.emergenciasBindingSource.DataSource = this.emergencyDataSet;
            // 
            // emergencyDataSet
            // 
            this.emergencyDataSet.DataSetName = "emergencyDataSet";
            this.emergencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emergenciasTableAdapter
            // 
            this.emergenciasTableAdapter.ClearBeforeFill = true;
            // 
            // idEmergenciaDataGridViewTextBoxColumn
            // 
            this.idEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "idEmergencia";
            this.idEmergenciaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idEmergenciaDataGridViewTextBoxColumn.Name = "idEmergenciaDataGridViewTextBoxColumn";
            this.idEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmergenciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // calleEmergenciaDataGridViewTextBoxColumn
            // 
            this.calleEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "calleEmergencia";
            this.calleEmergenciaDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleEmergenciaDataGridViewTextBoxColumn.Name = "calleEmergenciaDataGridViewTextBoxColumn";
            this.calleEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.calleEmergenciaDataGridViewTextBoxColumn.Width = 200;
            // 
            // coloniaEmergenciaDataGridViewTextBoxColumn
            // 
            this.coloniaEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "coloniaEmergencia";
            this.coloniaEmergenciaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaEmergenciaDataGridViewTextBoxColumn.Name = "coloniaEmergenciaDataGridViewTextBoxColumn";
            this.coloniaEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.coloniaEmergenciaDataGridViewTextBoxColumn.Width = 200;
            // 
            // numeroEmergenciaDataGridViewTextBoxColumn
            // 
            this.numeroEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "numeroEmergencia";
            this.numeroEmergenciaDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroEmergenciaDataGridViewTextBoxColumn.Name = "numeroEmergenciaDataGridViewTextBoxColumn";
            this.numeroEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroEmergenciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // cpEmergenciaDataGridViewTextBoxColumn
            // 
            this.cpEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "cpEmergencia";
            this.cpEmergenciaDataGridViewTextBoxColumn.HeaderText = "C.P.";
            this.cpEmergenciaDataGridViewTextBoxColumn.Name = "cpEmergenciaDataGridViewTextBoxColumn";
            this.cpEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpEmergenciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // ciudadEmergenciaDataGridViewTextBoxColumn
            // 
            this.ciudadEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "ciudadEmergencia";
            this.ciudadEmergenciaDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadEmergenciaDataGridViewTextBoxColumn.Name = "ciudadEmergenciaDataGridViewTextBoxColumn";
            this.ciudadEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadEmergenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoEmergenciaDataGridViewTextBoxColumn
            // 
            this.estadoEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "estadoEmergencia";
            this.estadoEmergenciaDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoEmergenciaDataGridViewTextBoxColumn.Name = "estadoEmergenciaDataGridViewTextBoxColumn";
            this.estadoEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoEmergenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // entreCallesEmergenciaDataGridViewTextBoxColumn
            // 
            this.entreCallesEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "entreCallesEmergencia";
            this.entreCallesEmergenciaDataGridViewTextBoxColumn.HeaderText = "Entre Calles";
            this.entreCallesEmergenciaDataGridViewTextBoxColumn.Name = "entreCallesEmergenciaDataGridViewTextBoxColumn";
            this.entreCallesEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.entreCallesEmergenciaDataGridViewTextBoxColumn.Width = 300;
            // 
            // otrasReferenciasEmergenciaDataGridViewTextBoxColumn
            // 
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "otrasReferenciasEmergencia";
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn.HeaderText = "Otras Referencias";
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn.Name = "otrasReferenciasEmergenciaDataGridViewTextBoxColumn";
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.otrasReferenciasEmergenciaDataGridViewTextBoxColumn.Width = 300;
            // 
            // ubicacionEmergencia
            // 
            this.ubicacionEmergencia.DataPropertyName = "ubicacionEmergencia";
            this.ubicacionEmergencia.HeaderText = "Ubicacion";
            this.ubicacionEmergencia.Name = "ubicacionEmergencia";
            this.ubicacionEmergencia.ReadOnly = true;
            this.ubicacionEmergencia.Width = 200;
            // 
            // ListasEmergencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(929, 407);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListasEmergencias";
            this.Text = "ListasEmergencias";
            this.Load += new System.EventHandler(this.ListasEmergencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private emergencyDataSet emergencyDataSet;
        private System.Windows.Forms.BindingSource emergenciasBindingSource;
        private emergencyDataSetTableAdapters.emergenciasTableAdapter emergenciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entreCallesEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrasReferenciasEmergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionEmergencia;
    }
}