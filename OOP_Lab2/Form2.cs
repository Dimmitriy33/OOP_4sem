using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class CrewMemberInfo : Form
    {
        public event AddToAirport1 SendInfo1;

        public List<CrewMember> CrewMembersList = new List<CrewMember>();
        private CrewMember crewMember = new CrewMember();

        public List<CrewMember> TakeList
        {
            get => CrewMembersList;
        }

        public CrewMemberInfo(AddToAirport1 addToAirport1)
        {
            InitializeComponent();
            try
            {
                CrewMembersList.Clear();
                this.SendInfo1 += addToAirport1;
            }
            catch
            {

            }
        }

        private void SurnameValue_TextChanged(object sender, System.EventArgs e)
        {
            crewMember.Surname = SurnameValue.Text;
        }

        private void CrewNameValue_TextChanged(object sender, System.EventArgs e)
        {
            crewMember.Name = CrewNameValue.Text;
        }

        private void PatronymicValue_TextChanged(object sender, System.EventArgs e)
        {
            crewMember.Patronymic = PatronymicValue.Text;
        }

        private void PositionList_SelectedValueChanged(object sender, System.EventArgs e)
        {
            crewMember.Position = PositionList.SelectedItem.ToString();
        }

        private void AgeValue_ValueChanged(object sender, System.EventArgs e)
        {
            crewMember.Age = Convert.ToInt32(AgeValue.Value);
        }

        private void ExperienceValue_ValueChanged(object sender, EventArgs e)
        {
            crewMember.Experience = Convert.ToInt32(ExperienceValue.Value);
        }

        private void AddCrewMemberToList_Click(object sender, EventArgs e)
        {
            CrewMembersList.Add(crewMember);
            crewMember = new CrewMember();
            SurnameValue.ResetText();
            CrewNameValue.ResetText();
            PatronymicValue.ResetText();
            PositionList.ResetText();
            AgeValue.ResetText();
            ExperienceValue.ResetText();
        }

        private void SaveInfoButton_Click(object sender, EventArgs e)
        {
            SendInfo1(this.CrewMembersList);
            this.Close();
        }

        private void JustLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Invalid value");
            }
        }
    }
}
