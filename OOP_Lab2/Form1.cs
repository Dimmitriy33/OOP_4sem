using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    public delegate void AddToAirport1(List<CrewMember> members);
    public delegate void AddToAirport2(AirplaneManufacturer manufacturer);
    public partial class AirplaneInfo : Form
    {

        List<Airplane> airport = new List<Airplane>();
        public Airplane airplane = new Airplane();

        public AirplaneInfo()
        {
            InitializeComponent();
            try
            {
                airport.Clear();
            }
            catch
            {

            }
        }

        public void AddToAirportCrewMembers(List<CrewMember> crewMembersList)
        {
            airplane.CrewMembers = crewMembersList;
        }

        public void AddToAirportManufacrurer(AirplaneManufacturer manufacturer)
        {
            airplane.AirplaneManufacturer = manufacturer;
        }

        private void CrewMemberLinkButton_Click(object sender, System.EventArgs e)
        {
            CrewMemberInfo crewMemberInfo = new CrewMemberInfo(AddToAirportCrewMembers);
            crewMemberInfo.Show();
        }

        private void AirplaneManufacturerLinkButton_Click(object sender, System.EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer(AddToAirportManufacrurer);
            manufacturer.Show();
        }

        private void NumberValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.ID = Convert.ToInt32(NumberValue.Text);
            }
            catch
            {

            }
        }

        private void TypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (TypeRadioButton1.Checked)
                airplane.Type = TypeRadioButton1.Text;
            else if (TypeRadioButton2.Checked)
                airplane.Type = TypeRadioButton2.Text;
            else if (TypeRadioButton1.Checked)
                airplane.Type = TypeRadioButton3.Text;
        }

        private void ModelValue_TextChanged(object sender, EventArgs e)
        {
            airplane.Model = ModelValue.Text;
        }

        private void NumberOfPassengersValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.NumberOfPassengers = Convert.ToInt32(NumberOfPassengersValue.Value);
            }
            catch
            {

            }
        }

        private void YearOfIssueValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.YearOfIssue = Convert.ToInt32(YearOfIssueValue.Value);
            }
            catch { }
        }

        private void CarryingValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.Carrying = Convert.ToInt32(CarryingValue.Value);
            }
            catch
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            airplane.DateOfTheLatestMaintenance = dateTimePicker1.Value;
        }
        #region WriteShowInfo
        private void ShowInfoAboutAirplanes_Button_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Airplane>));
            using (FileStream file = new FileStream("..\\..\\Airport.xml", FileMode.OpenOrCreate))
            {
                List<Airplane> deserAirport = (List<Airplane>)formatter.Deserialize(file);
                OutTextValue.Text += "Самолеты\r\n";
                foreach (Airplane AirportItem in deserAirport)
                {

                    OutTextValue.AppendText("\n---------------------------------------------\n\r\n");
                    OutTextValue.AppendText($" Airplane №{ AirportItem.ID}\r\n");
                    OutTextValue.AppendText($" Тип: {AirportItem.Type}\r\n");
                    OutTextValue.AppendText($" Модель: {AirportItem.Model}\r\n");
                    OutTextValue.AppendText($" Количество пасадочных мест: {AirportItem.NumberOfPassengers}\r\n");
                    OutTextValue.AppendText($" Год выпуска: {AirportItem.YearOfIssue}\r\n");
                    OutTextValue.AppendText($" Грузоподъемность: {AirportItem.Carrying}\r\n");
                    OutTextValue.AppendText($" Дата последнего тех.обслуживания: {AirportItem.DateOfTheLatestMaintenance.Date}." +
                        $"{AirportItem.DateOfTheLatestMaintenance.Month}.{AirportItem.DateOfTheLatestMaintenance.Year}\r\n");
                    OutTextValue.AppendText(" Экипаж:\r\n");
                    foreach (CrewMember item in AirportItem.CrewMembers)
                    {
                        OutTextValue.AppendText($"  Член экипажа №{AirportItem.CrewMembers.IndexOf(item) + 1}\r\n");
                        OutTextValue.AppendText($"  Фамилия: {item.Surname}\r\n");
                        OutTextValue.AppendText($"  Имя: {item.Name}\r\n");
                        OutTextValue.AppendText($"  Отчество: {item.Patronymic}\r\n");
                        OutTextValue.AppendText($"  Должность: {item.Position}\r\n");
                        OutTextValue.AppendText($"  Возраст: {item.Age}\r\n");
                        OutTextValue.AppendText($"  Стаж(лет): {item.Experience}\r\n");
                    }
                    OutTextValue.AppendText(" Производитель\r\n");
                    OutTextValue.AppendText($"  Название: {AirportItem.AirplaneManufacturer.Name}\r\n");
                    OutTextValue.AppendText($"  Страна: {AirportItem.AirplaneManufacturer.Country}\r\n");
                    OutTextValue.AppendText($"  Год основания: {AirportItem.AirplaneManufacturer.YearOfFoundation}\r\n");
                    OutTextValue.AppendText($"  Типы производимых самолетов: \r\n");
                    foreach (string el in AirportItem.AirplaneManufacturer.TypesOfAircraft)
                        OutTextValue.AppendText($"   {el}\r\n");
                }
            }
        }
        private void WriteInfoAboutAirplanes_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("..\\..\\Airport.xml"))
                    File.Delete("..\\..\\Airport.xml");
                XmlSerializer formatter = new XmlSerializer(typeof(List<Airplane>));
                using (FileStream file = new FileStream("..\\..\\Airport.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(file, airport);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Push_Info_button_Click(object sender, EventArgs e)
        {
            airport.Add(airplane);
            airplane = new Airplane();
            NumberValue.ResetText();
            TypeRadioButton1.Checked = false;
            TypeRadioButton2.Checked = false;
            TypeRadioButton3.Checked = false;
            ModelValue.ResetText();
            NumberOfPassengersValue.ResetText();
            YearOfIssueValue.ResetText();
            CarryingValue.ResetText();
            dateTimePicker1.ResetText();
        }
        #endregion

        #region Validation
        private void NumberValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Invalid value");
            }

        }

        private void ModelValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (char ch in ModelValue.Text)
                if (!char.IsDigit(ch) && !char.IsLetter(ch) && ch != '-' && ch != 8)
                {
                    MessageBox.Show("Invalid value");
                    break;
                }
        }
        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(airport);
            searchForm.Show();
        }

        private void SerializePlusPrint(string path, List<Airplane> list)
        {
            //Serialize
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
                XmlSerializer formatter1 = new XmlSerializer(typeof(List<Airplane>));
                using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter1.Serialize(file, list);
                }
            }
            catch (Exception)
            {
                throw;
            }

            //Deserialize
            XmlSerializer formatter = new XmlSerializer(typeof(List<Airplane>));
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                OutTextValue.ResetText();
                List<Airplane> deserAirport = (List<Airplane>)formatter.Deserialize(file);
                OutTextValue.Text += "Самолеты\r\n";
                foreach (Airplane AirportItem in deserAirport)
                {

                    OutTextValue.AppendText("\n---------------------------------------------\n\r\n");
                    OutTextValue.AppendText($" Airplane №{ AirportItem.ID}\r\n");
                    OutTextValue.AppendText($" Тип: {AirportItem.Type}\r\n");
                    OutTextValue.AppendText($" Модель: {AirportItem.Model}\r\n");
                    OutTextValue.AppendText($" Количество пасадочных мест: {AirportItem.NumberOfPassengers}\r\n");
                    OutTextValue.AppendText($" Год выпуска: {AirportItem.YearOfIssue}\r\n");
                    OutTextValue.AppendText($" Грузоподъемность: {AirportItem.Carrying}\r\n");
                    OutTextValue.AppendText($" Дата последнего тех.обслуживания: {AirportItem.DateOfTheLatestMaintenance.Date}." +
                        $"{AirportItem.DateOfTheLatestMaintenance.Month}.{AirportItem.DateOfTheLatestMaintenance.Year}\r\n");
                    OutTextValue.AppendText(" Экипаж:\r\n");
                    foreach (CrewMember item in AirportItem.CrewMembers)
                    {
                        OutTextValue.AppendText($"  Член экипажа №{AirportItem.CrewMembers.IndexOf(item) + 1}\r\n");
                        OutTextValue.AppendText($"  Фамилия: {item.Surname}\r\n");
                        OutTextValue.AppendText($"  Имя: {item.Name}\r\n");
                        OutTextValue.AppendText($"  Отчество: {item.Patronymic}\r\n");
                        OutTextValue.AppendText($"  Должность: {item.Position}\r\n");
                        OutTextValue.AppendText($"  Возраст: {item.Age}\r\n");
                        OutTextValue.AppendText($"  Стаж(лет): {item.Experience}\r\n");
                    }
                    OutTextValue.AppendText(" Производитель\r\n");
                    OutTextValue.AppendText($"  Название: {AirportItem.AirplaneManufacturer.Name}\r\n");
                    OutTextValue.AppendText($"  Страна: {AirportItem.AirplaneManufacturer.Country}\r\n");
                    OutTextValue.AppendText($"  Год основания: {AirportItem.AirplaneManufacturer.YearOfFoundation}\r\n");
                    OutTextValue.AppendText($"  Типы производимых самолетов: \r\n");
                    foreach (string el in AirportItem.AirplaneManufacturer.TypesOfAircraft)
                        OutTextValue.AppendText($"   {el}\r\n");
                }
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            switch (SortListBox.SelectedItem.ToString())
            {
                case "году выпуска":
                    var sortedAirportByYear = airport.OrderBy(item => item.YearOfIssue).ToList();
                    SerializePlusPrint("..\\..\\AirportSortByYear.xml", (List<Airplane>)sortedAirportByYear);
                    break;
                case "количеству мест":
                    var sortedAirportByPlaces = airport.OrderBy(item => item.NumberOfPassengers).ToList();
                    SerializePlusPrint("..\\..\\AirportSortByPlaces.xml", (List<Airplane>)sortedAirportByPlaces);
                    break;
                case "грузоподъемности":
                    var sortedAirportByCarrying = airport.OrderBy(item => item.Carrying).ToList();
                    SerializePlusPrint("..\\..\\AirportSortByCarrying.xml", (List<Airplane>)sortedAirportByCarrying);
                    break;
                case "номеру самолета":
                    var sortedAirportByNumberOfAirplane = airport.OrderBy(item => item.ID).ToList();
                    SerializePlusPrint("..\\..\\sortedAirportByNumberOfAirplane.xml", (List<Airplane>)sortedAirportByNumberOfAirplane);
                    break;
                default:
                    break;
            }
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version 1.0\nShalunov Dmitriy", "About program");
        }


    }
}
