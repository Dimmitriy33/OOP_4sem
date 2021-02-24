using System;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class Manufacturer : Form
    {
        public event AddToAirport2 SendInfo2;
        AirplaneManufacturer airplaneManufacturer;
        public Manufacturer(AddToAirport2 addToAirport2)
        {
            InitializeComponent();
            try
            {
                airplaneManufacturer = new AirplaneManufacturer();
                this.SendInfo2 += addToAirport2;
            }
            catch
            {

            }
        }


        private void ManufacturerNameValue_TextChanged(object sender, EventArgs e)
        {
            airplaneManufacturer.Name = ManufacturerNameValue.Text;
        }

        private void CountryValue_TextChanged(object sender, EventArgs e)
        {
            airplaneManufacturer.Country = CountryValue.Text;
        }

        private void YearOfFoundationValue_ValueChanged(object sender, EventArgs e)
        {
            airplaneManufacturer.YearOfFoundation = Convert.ToInt32(YearOfFoundationValue.Value);
        }

        private void TypesOfAircraftList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string item in TypesOfAircraftList.SelectedItems)
            {
                if (!airplaneManufacturer.TypesOfAircraft.Exists(el => el == item))
                    airplaneManufacturer.TypesOfAircraft.Add(item);
            }
        }

        private void PushInfoAboutManufacturer_Click(object sender, EventArgs e)
        {
            SendInfo2(this.airplaneManufacturer);
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
