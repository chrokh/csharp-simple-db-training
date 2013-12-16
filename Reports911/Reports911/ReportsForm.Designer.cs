namespace Reports911
{
    partial class ReportsForm
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
            this.btnQueryAllEMTsFromBaseStation = new System.Windows.Forms.Button();
            this.btnQueryNumberOfActiveIncidentsForBaseStation = new System.Windows.Forms.Button();
            this.btnAllBaseStationsAndNumberOfEMTsOffScene = new System.Windows.Forms.Button();
            this.btnQueryAllEMTs = new System.Windows.Forms.Button();
            this.btnQueryAllEMTsOnScene = new System.Windows.Forms.Button();
            this.dtgrdReportOutput = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnQueryAllEMTsOffScene = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQueryBaseStationsAndNumberOfActiveIncidents = new System.Windows.Forms.Button();
            this.btnQueryAllBaseStations = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBaseStationId = new System.Windows.Forms.TextBox();
            this.btnQueryActiveIncidentsForBaseStation = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnQueryAllActiveIncidents = new System.Windows.Forms.Button();
            this.btnQueryAllIncidents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdReportOutput)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQueryAllEMTsFromBaseStation
            // 
            this.btnQueryAllEMTsFromBaseStation.Location = new System.Drawing.Point(6, 26);
            this.btnQueryAllEMTsFromBaseStation.Name = "btnQueryAllEMTsFromBaseStation";
            this.btnQueryAllEMTsFromBaseStation.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllEMTsFromBaseStation.TabIndex = 1;
            this.btnQueryAllEMTsFromBaseStation.Text = "All EMTs";
            this.btnQueryAllEMTsFromBaseStation.UseVisualStyleBackColor = true;
            this.btnQueryAllEMTsFromBaseStation.Click += new System.EventHandler(this.btnQueryAllEMTsFromBaseStation_Click);
            // 
            // btnQueryNumberOfActiveIncidentsForBaseStation
            // 
            this.btnQueryNumberOfActiveIncidentsForBaseStation.Location = new System.Drawing.Point(6, 84);
            this.btnQueryNumberOfActiveIncidentsForBaseStation.Name = "btnQueryNumberOfActiveIncidentsForBaseStation";
            this.btnQueryNumberOfActiveIncidentsForBaseStation.Size = new System.Drawing.Size(181, 23);
            this.btnQueryNumberOfActiveIncidentsForBaseStation.TabIndex = 1;
            this.btnQueryNumberOfActiveIncidentsForBaseStation.Text = "Num. Active Incidents";
            this.btnQueryNumberOfActiveIncidentsForBaseStation.UseVisualStyleBackColor = true;
            this.btnQueryNumberOfActiveIncidentsForBaseStation.Click += new System.EventHandler(this.btnQueryNumberOfActiveIncidentsForBaseStation_Click);
            // 
            // btnAllBaseStationsAndNumberOfEMTsOffScene
            // 
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.Location = new System.Drawing.Point(6, 48);
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.Name = "btnAllBaseStationsAndNumberOfEMTsOffScene";
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.Size = new System.Drawing.Size(181, 23);
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.TabIndex = 1;
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.Text = "With Num. of Available EMTs";
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.UseVisualStyleBackColor = true;
            this.btnAllBaseStationsAndNumberOfEMTsOffScene.Click += new System.EventHandler(this.btnAllBaseStationsAndNumberOfEMTsOffScene_Click);
            // 
            // btnQueryAllEMTs
            // 
            this.btnQueryAllEMTs.Location = new System.Drawing.Point(6, 19);
            this.btnQueryAllEMTs.Name = "btnQueryAllEMTs";
            this.btnQueryAllEMTs.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllEMTs.TabIndex = 1;
            this.btnQueryAllEMTs.Text = "All";
            this.btnQueryAllEMTs.UseVisualStyleBackColor = true;
            this.btnQueryAllEMTs.Click += new System.EventHandler(this.btnQueryAllEMTs_Click);
            // 
            // btnQueryAllEMTsOnScene
            // 
            this.btnQueryAllEMTsOnScene.Location = new System.Drawing.Point(6, 48);
            this.btnQueryAllEMTsOnScene.Name = "btnQueryAllEMTsOnScene";
            this.btnQueryAllEMTsOnScene.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllEMTsOnScene.TabIndex = 1;
            this.btnQueryAllEMTsOnScene.Text = "All On Scene";
            this.btnQueryAllEMTsOnScene.UseVisualStyleBackColor = true;
            this.btnQueryAllEMTsOnScene.Click += new System.EventHandler(this.btnQueryAllEMTsOnScene_Click);
            // 
            // dtgrdReportOutput
            // 
            this.dtgrdReportOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdReportOutput.Location = new System.Drawing.Point(247, 12);
            this.dtgrdReportOutput.Name = "dtgrdReportOutput";
            this.dtgrdReportOutput.ReadOnly = true;
            this.dtgrdReportOutput.Size = new System.Drawing.Size(644, 447);
            this.dtgrdReportOutput.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnQueryAllEMTs);
            this.groupBox6.Controls.Add(this.btnQueryAllEMTsOffScene);
            this.groupBox6.Controls.Add(this.btnQueryAllEMTsOnScene);
            this.groupBox6.Location = new System.Drawing.Point(30, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(198, 112);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EMTs";
            // 
            // btnQueryAllEMTsOffScene
            // 
            this.btnQueryAllEMTsOffScene.Location = new System.Drawing.Point(6, 77);
            this.btnQueryAllEMTsOffScene.Name = "btnQueryAllEMTsOffScene";
            this.btnQueryAllEMTsOffScene.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllEMTsOffScene.TabIndex = 1;
            this.btnQueryAllEMTsOffScene.Text = "All Off Scene";
            this.btnQueryAllEMTsOffScene.UseVisualStyleBackColor = true;
            this.btnQueryAllEMTsOffScene.Click += new System.EventHandler(this.btnQueryAllEMTsOffScene_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQueryBaseStationsAndNumberOfActiveIncidents);
            this.groupBox1.Controls.Add(this.btnAllBaseStationsAndNumberOfEMTsOffScene);
            this.groupBox1.Controls.Add(this.btnQueryAllBaseStations);
            this.groupBox1.Location = new System.Drawing.Point(30, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BaseStations";
            // 
            // btnQueryBaseStationsAndNumberOfActiveIncidents
            // 
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.Location = new System.Drawing.Point(6, 77);
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.Name = "btnQueryBaseStationsAndNumberOfActiveIncidents";
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.Size = new System.Drawing.Size(181, 23);
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.TabIndex = 1;
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.Text = "With Num. of Active Incidents";
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.UseVisualStyleBackColor = true;
            this.btnQueryBaseStationsAndNumberOfActiveIncidents.Click += new System.EventHandler(this.btnQueryBaseStationsAndNumberOfActiveIncidents_Click);
            // 
            // btnQueryAllBaseStations
            // 
            this.btnQueryAllBaseStations.Location = new System.Drawing.Point(6, 19);
            this.btnQueryAllBaseStations.Name = "btnQueryAllBaseStations";
            this.btnQueryAllBaseStations.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllBaseStations.TabIndex = 0;
            this.btnQueryAllBaseStations.Text = "All";
            this.btnQueryAllBaseStations.UseVisualStyleBackColor = true;
            this.btnQueryAllBaseStations.Click += new System.EventHandler(this.btnQueryAllBaseStations_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBaseStationId);
            this.groupBox2.Controls.Add(this.btnQueryAllEMTsFromBaseStation);
            this.groupBox2.Controls.Add(this.btnQueryNumberOfActiveIncidentsForBaseStation);
            this.groupBox2.Controls.Add(this.btnQueryActiveIncidentsForBaseStation);
            this.groupBox2.Location = new System.Drawing.Point(30, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BaseStation #";
            // 
            // txtBaseStationId
            // 
            this.txtBaseStationId.Location = new System.Drawing.Point(87, 0);
            this.txtBaseStationId.Name = "txtBaseStationId";
            this.txtBaseStationId.Size = new System.Drawing.Size(50, 20);
            this.txtBaseStationId.TabIndex = 8;
            // 
            // btnQueryActiveIncidentsForBaseStation
            // 
            this.btnQueryActiveIncidentsForBaseStation.Location = new System.Drawing.Point(6, 55);
            this.btnQueryActiveIncidentsForBaseStation.Name = "btnQueryActiveIncidentsForBaseStation";
            this.btnQueryActiveIncidentsForBaseStation.Size = new System.Drawing.Size(181, 23);
            this.btnQueryActiveIncidentsForBaseStation.TabIndex = 1;
            this.btnQueryActiveIncidentsForBaseStation.Text = "All Active Incidents";
            this.btnQueryActiveIncidentsForBaseStation.UseVisualStyleBackColor = true;
            this.btnQueryActiveIncidentsForBaseStation.Click += new System.EventHandler(this.btnQueryActiveIncidentsForBaseStation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnQueryAllActiveIncidents);
            this.groupBox5.Controls.Add(this.btnQueryAllIncidents);
            this.groupBox5.Location = new System.Drawing.Point(30, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 87);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Incidents";
            // 
            // btnQueryAllActiveIncidents
            // 
            this.btnQueryAllActiveIncidents.Location = new System.Drawing.Point(8, 48);
            this.btnQueryAllActiveIncidents.Name = "btnQueryAllActiveIncidents";
            this.btnQueryAllActiveIncidents.Size = new System.Drawing.Size(186, 23);
            this.btnQueryAllActiveIncidents.TabIndex = 1;
            this.btnQueryAllActiveIncidents.Text = "All active incidents";
            this.btnQueryAllActiveIncidents.UseVisualStyleBackColor = true;
            this.btnQueryAllActiveIncidents.Click += new System.EventHandler(this.btnQueryAllActiveIncidents_Click);
            // 
            // btnQueryAllIncidents
            // 
            this.btnQueryAllIncidents.Location = new System.Drawing.Point(8, 19);
            this.btnQueryAllIncidents.Name = "btnQueryAllIncidents";
            this.btnQueryAllIncidents.Size = new System.Drawing.Size(186, 23);
            this.btnQueryAllIncidents.TabIndex = 0;
            this.btnQueryAllIncidents.Text = "All";
            this.btnQueryAllIncidents.UseVisualStyleBackColor = true;
            this.btnQueryAllIncidents.Click += new System.EventHandler(this.btnQueryAllIncidents_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 468);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrdReportOutput);
            this.Controls.Add(this.groupBox6);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdReportOutput)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueryAllEMTsFromBaseStation;
        private System.Windows.Forms.Button btnAllBaseStationsAndNumberOfEMTsOffScene;
        private System.Windows.Forms.Button btnQueryAllEMTs;
        private System.Windows.Forms.Button btnQueryAllEMTsOnScene;
        private System.Windows.Forms.DataGridView dtgrdReportOutput;
        private System.Windows.Forms.Button btnQueryNumberOfActiveIncidentsForBaseStation;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnQueryAllEMTsOffScene;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQueryAllBaseStations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBaseStationId;
        private System.Windows.Forms.Button btnQueryBaseStationsAndNumberOfActiveIncidents;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnQueryAllIncidents;
        private System.Windows.Forms.Button btnQueryAllActiveIncidents;
        private System.Windows.Forms.Button btnQueryActiveIncidentsForBaseStation;
    }
}

