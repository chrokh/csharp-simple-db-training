using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reports911
{
    public partial class ReportsForm : Form
    {
        IQueryExecuter _actualExecuter = new QueryExecuter();

        public ReportsForm()
        {
            InitializeComponent();

            var db = new ErisDbContext();
            DatabaseManager.Seed(db);

            dtgrdReportOutput.DataMember = "PRIMARY";
        }

        private void btnQueryAllEMTs_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllEmts);
        }

        private void btnQueryAllEMTsOnScene_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllEmtsOnScene);
        }

        private void btnQueryAllEMTsFromBaseStation_Click(object sender, EventArgs e)
        {
            _executeWithParameter(_actualExecuter.AllEmtsForBaseStation, txtBaseStationId.Text);
        }

        private void btnQueryNumberOfActiveIncidentsForBaseStation_Click(object sender, EventArgs e)
        {
            _executeWithParameter(_actualExecuter.NumberOfActiveIncidentsPerBaseStation, txtBaseStationId.Text);
        }

        private void btnQueryActiveIncidentsForBaseStation_Click(object sender, EventArgs e)
        {
            _executeWithParameter(_actualExecuter.AllActiveIncidentsForBaseStation, txtBaseStationId.Text);
        }

        private void btnAllBaseStationsAndNumberOfEMTsOffScene_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllBaseStationsAndNumberOfEmtsOffScene);
        }

        private void btnQueryAllEMTsOffScene_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllEmtsOffScene);
        }

        private void btnQueryAllIncidents_Click(object sender, EventArgs e)
        {
             _executeParameterless(_actualExecuter.AllIncidents);
        }

        private void btnQueryAllActiveIncidents_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllActiveIncidents);
        }

        private void btnQueryAllBaseStations_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllBaseStations);
        }


        private void btnQueryBaseStationsAndNumberOfActiveIncidents_Click(object sender, EventArgs e)
        {
            _executeParameterless(_actualExecuter.AllBaseStationsAndNumberOfActiveIncidents);
        }

        /*
         * Helpers
         */

        private void _executeWithParameter(Func<int, DataSet> actual, string val)
        {
            int valueAsInt;
            if (Int32.TryParse(val, out valueAsInt))
            try
            {
                    dtgrdReportOutput.DataSource = actual(valueAsInt);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            else
                MessageBox.Show("Please enter a numeric value");
        }

        private void _executeParameterless(Func<DataSet> actual)
        {
            try
            {
                dtgrdReportOutput.DataSource = actual();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
