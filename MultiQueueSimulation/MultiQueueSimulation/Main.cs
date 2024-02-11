﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Main : Form
    {
        private string fileName;
        private FileHandler fileHandler;
        private SimulationSystem system;

        public Main()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public string getFileName()
        {
            return fileName;
        }

        public void displayData()
        {

            numberOfServersTextBox.Text = system.NumberOfServers.ToString();
            stoppingNumberTextBox.Text = system.StoppingNumber.ToString();
            stoppingCriteriaTextBox.Text = system.StoppingCriteria.ToString();
            selectionMethodTextBox.Text = system.SelectionMethod.ToString();
           /* for (int i = 0; i < system.InterarrivalDistribution.Count; i++)
            {
                int interarrivalTime = system.InterarrivalDistribution[i].Time;
                decimal Probability = system.InterarrivalDistribution[i].Probability;
              //  interarrivalDistributionDataTable.Rows.Add(interarrivalTime, Probability);
            }*/
           
        }

      /*  public void loadComboBoxData()
        {
            serverComboBox.Items.Clear();
            for(int i = 1; i <= system.NumberOfServers; i++)
            {
                serverComboBox.Items.Add(i);
            }
        }
      */
        private void openTestCaseButton_Click(object sender, EventArgs e)
        {
            testCaseFileDialog = new OpenFileDialog();
            DialogResult fileResult = testCaseFileDialog.ShowDialog();
           
            if (fileResult == DialogResult.OK)
            {
                fileName = testCaseFileDialog.SafeFileName;
                system = fileHandler.ReadTestCase(testCaseFileDialog.FileName);
                //loadComboBoxData();
                //interarrivalDistributionDataTable.Rows.Clear();
                //serviceTimeDistributionDataTable.Rows.Clear();
                displayData();
              
            }
        }

      /*  private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = serverComboBox.SelectedIndex;
            //serviceTimeDistributionDataTable.Rows.Clear();
            for (int i = 0; i < system.Servers[index].TimeDistribution.Count; i++)
            {
                int serviceTime = system.Servers[index].TimeDistribution[i].Time;
                decimal Probability = system.Servers[index].TimeDistribution[i].Probability;
              //  serviceTimeDistributionDataTable.Rows.Add(serviceTime, Probability);
            }
            
        }
      */
        private void simulateButton_Click(object sender, EventArgs e)
        {
            if (system != null)
            {
                system.Simulate();
                Output output = new Output(system);
                output.Show();
                string result = TestingManager.Test(system, fileName);
                MessageBox.Show(result);
            }
            else
                MessageBox.Show("Please Choose Test Case");
        }

        private void numberOfServersLabel_Click(object sender, EventArgs e)
        {

        }

        /*  private void interarrivalDistributionDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }*/
    }
}
