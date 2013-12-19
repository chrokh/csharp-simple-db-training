using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reports911
{
    public partial class ReportsForm : Form
    {
        AbstractExecuter _actualExecuter;
        AbstractExecuter _fakeExecuter;

        public ReportsForm()
        {
            InitializeComponent();

            
            try
            {
                ErisDbContext db = new ErisDbContext();
                new DatabaseSeeder(db).Seed();
                _actualExecuter = new QueryExecuter(db);
                _fakeExecuter = new FakeExecuter(db);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: Could not connect to db. Hey student, are you sure the database file is not open anywhere else (even Visual Studio Server Explorer will cause problems)? \r\n\r\n("+ e.Message + ")");
            }

            dtgrdReportOutput.DataMember = "PRIMARY";
            dtgrdExpectedOutput.DataMember = "PRIMARY";
        }


        private void btnQueryAllEMTs_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_EMTS);
        }

        private void btnQueryAllEMTsOnScene_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_EMTS_ON_SCENE);
        }

        private void btnQueryAllEMTsFromBaseStation_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_EMTS_FOR_BASESTATION, txtBaseStationId.Text);
        }

        private void btnQueryNumberOfActiveIncidentsForBaseStation_Click(object sender, EventArgs e)
        {
            _execute(QueryType.NUMBER_OF_ACTIVE_INCIDENTS_PER_BASESTATION, txtBaseStationId.Text);
        }

        private void btnQueryActiveIncidentsForBaseStation_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_ACTIVE_INCIDENTS_FOR_BASESTATION, txtBaseStationId.Text);
        }

        private void btnAllBaseStationsAndNumberOfEMTsOffScene_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_BASESTATIONS_AND_NUMBER_OF_EMTS_OFF_SCENE);
        }

        private void btnQueryAllEMTsOffScene_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_EMTS_OFF_SCENE);
        }

        private void btnQueryAllIncidents_Click(object sender, EventArgs e)
        {
             _execute(QueryType.ALL_INCIDENTS);
        }

        private void btnQueryAllActiveIncidents_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_ACTIVE_INCIDENTS);
        }

        private void btnQueryAllBaseStations_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_BASESTATIONS);
        }

        private void btnQueryBaseStationsAndNumberOfActiveIncidents_Click(object sender, EventArgs e)
        {
            _execute(QueryType.ALL_BASESTATIONS_AND_NUMBER_OF_ACTIVE_INCIDENTS);
        }



        /*
         * Helpers
         */

        private void _execute(QueryType kind, string val)
        {
            int valueAsInt;
            if (Int32.TryParse(val, out valueAsInt))
            {
                if (chkDoShowExpectedOutput.Checked)
                {
                    try
                    {
                        dtgrdExpectedOutput.Visible = true;
                        dtgrdExpectedOutput.DataSource = _fakeExecuter.Execute(kind, valueAsInt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not show expected example output. Sorry :) \r\n\r\nError: " + ex.Message);
                    }
                }
                else
                {
                    dtgrdExpectedOutput.Visible = false;
                }
                if (chkDoShowStudentOutput.Checked)
                {
                    try
                    {
                        dtgrdReportOutput.Visible = true;
                        dtgrdReportOutput.DataSource = _actualExecuter.Execute(kind, valueAsInt);
                    }
                    catch (SqlCeException ex)
                    {
                        MessageBox.Show("The error when running your query, student, was: \r\n\r\n" + ex.Message);
                    }
                }
                else
                {
                    dtgrdReportOutput.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
            }
        }

        private void _execute(QueryType kind)
        {
            if (chkDoShowExpectedOutput.Checked)
            {
                try
                {
                    dtgrdExpectedOutput.Visible = true;
                    dtgrdExpectedOutput.DataSource = _fakeExecuter.Execute(kind);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not show expected example output. Sorry :) \r\n\r\nError: " + ex.Message);
                }
            }
            else
            {
                dtgrdExpectedOutput.Visible = false;
            }
            if (chkDoShowStudentOutput.Checked)
            {
                try
                {
                    dtgrdReportOutput.Visible = true;
                    dtgrdReportOutput.DataSource = _actualExecuter.Execute(kind);
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("The error when running your query, student, was: \r\n\r\n" + ex.Message);
                }
            }
            else
            {
                dtgrdReportOutput.Visible = false;
            }
        }
    }
}
