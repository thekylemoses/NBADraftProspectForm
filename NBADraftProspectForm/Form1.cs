using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBADraftProspectForm
{
    public partial class frmPlayerInfo : Form
    {
        private PlayerReportController playerReportController;
        public frmPlayerInfo(PlayerReportController playerReportController)
        {
            InitializeComponent();
            this.playerReportController = playerReportController;
            LoadPlayersDropDown();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }





        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = fnameText.Text + ' ' + lnameText.Text;
            string school = collegeName.Text;
            int year = eduLevel.SelectedIndex;
            int level = collegeLevel.SelectedIndex;
            int height = Convert.ToInt32((heightFeet.Value * 12) + heightInches.Value);
            int weight = Convert.ToInt32(weightPounds.Text);
            List<int> pos = new List<int>();
            string notes = addNotes.Text;

            if (posCheckBox.TabIndex == 0)
            {
                pos.Add(0);
            }
            if (posCheckBox.TabIndex == 1)
            {
                pos.Add(1);
            }
            if (posCheckBox.TabIndex == 2)
            {
                pos.Add(2);
            }
            if (posCheckBox.TabIndex == 3)
            {
                pos.Add(3);
            }
            if (posCheckBox.TabIndex == 4)
            {
                pos.Add(4);
            }

            playerReportController.AddPlayer(name, school, year, level, height, weight, pos, notes);
            LoadPlayersDropDown();
            ChoosePlayersFromDropDown(name);
            MessageBox.Show(playerReportController.GetPlayersAsString());

        }

        private void LoadPlayersDropDown()
        {
            List<string> playerNames = playerReportController.GetPlayerNames();
            comboBox1.DataSource = playerNames;
            comboBox1.Refresh();

        }

        private void ChoosePlayersFromDropDown(string name)
        {
            int index = comboBox1.Items.IndexOf(name);
            if (index >= 0)
            {
                comboBox1.SelectedIndex = index;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;
            Dictionary<string, string> data;
            string[] pos;
            if (comboBox1.SelectedIndex != -1)
            {
                name = comboBox1.GetItemText(comboBox1.SelectedItem);
                data = playerReportController.GetDataForPlayerName(name);
                if (data != null)
                {
                    fnameText.Text = data["name"].Split(' ')[0];
                    lnameText.Text = data["name"].Split(' ')[1];
                    eduLevel.SelectedIndex = eduLevel.Items.IndexOf(data["year"]);
                    collegeLevel.SelectedIndex = collegeLevel.Items.IndexOf(data["level"]);
                    heightFeet.Value = Convert.ToDecimal(data["height"])/12;
                    heightInches.Value = Convert.ToDecimal(data["height"])%12;
                    weightPounds.Text = data["weight"];
                    pos = data["pos"].Split(' ');
                    if (pos.Contains("0"))
                    {
                        posCheckBox.TabIndex = 0;
                    }
                    if (pos.Contains("1"))
                    {
                        posCheckBox.TabIndex = 1;
                    }
                    if (pos.Contains("2"))
                    {
                        posCheckBox.TabIndex = 2;
                    }
                    if (pos.Contains("3"))
                    {
                        posCheckBox.TabIndex = 3;
                    }
                    if (pos.Contains("4"))
                    {
                        posCheckBox.TabIndex = 4;
                    }
                    addNotes.Text = data["notes"];
                    Refresh();

                }
            }
        }
    }
}