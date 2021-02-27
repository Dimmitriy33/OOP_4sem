using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    public delegate void AddToAirport1(List<CrewMember> members);
    public delegate void AddToAirport2(AirplaneManufacturer manufacturer);
    public partial class AirplaneInfo : Form
    {
        static AirportInfastructureBuilder airportInfastructureBuilder = new MinskAirportInfastructureBuilder();
        Creator creator = new Creator(airportInfastructureBuilder);
        AirportInfastructureProduct AirportInfrastructure = airportInfastructureBuilder.getAirportInfrastructure();

        /*List<Airplane> airport = new List<Airplane>();*/

        private IAirplaneFactory factory;
        Airplane airplane;


        public AirplaneInfo()
        {
            InitializeComponent();
            try
            {
                AirportInfrastructure.Airport.Clear();
            }
            catch
            {

            }
        }
        private void AirplaneInfo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Первым укажите тип самолета!");
        }

        public void AddToAirportCrewMembers(List<CrewMember> crewMembersList)
        {
            airplane.baseInfo.CrewMembers = crewMembersList;
        }

        public void AddToAirportManufacrurer(AirplaneManufacturer manufacturer)
        {
            airplane.technicalCharacteristics.AirplaneManufacturer = manufacturer;
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
                airplane.baseInfo.ID = Convert.ToInt32(NumberValue.Text);
            }
            catch
            {

            }
        }

        private void TypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (TypeRadioButton1.Checked)
            {
                factory = new PassangerAirplaneFactory();
                airplane = factory.CreateAirplane();
                airplane.baseInfo.Type = TypeRadioButton1.Text;
            }
            else if (TypeRadioButton2.Checked)
            {
                factory = new CargoAirplaneFactory();
                airplane = factory.CreateAirplane();
                airplane.baseInfo.Type = TypeRadioButton2.Text;
            }
            else if (TypeRadioButton3.Checked)
            {
                factory = new MilitaryAirplaneFactory();
                airplane = factory.CreateAirplane();
                airplane.baseInfo.Type = TypeRadioButton3.Text;
            }
        }

        private void ModelValue_TextChanged(object sender, EventArgs e)
        {
            airplane.baseInfo.Model = ModelValue.Text;
        }

        private void NumberOfPassengersValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.baseInfo.NumberOfPassengers = Convert.ToInt32(NumberOfPassengersValue.Value);
            }
            catch
            {

            }
        }

        private void YearOfIssueValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.baseInfo.YearOfIssue = Convert.ToInt32(YearOfIssueValue.Value);
            }
            catch { }
        }

        private void CarryingValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                airplane.technicalCharacteristics.Carrying = Convert.ToInt32(CarryingValue.Value);
            }
            catch
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            airplane.baseInfo.DateOfTheLatestMaintenance = dateTimePicker1.Value;
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
                    OutTextValue.AppendText($" Airplane №{ AirportItem.baseInfo.ID}\r\n");
                    OutTextValue.AppendText($" Тип: {AirportItem.baseInfo.Type}\r\n");
                    OutTextValue.AppendText($" Модель: {AirportItem.baseInfo.Model}\r\n");
                    OutTextValue.AppendText($" Количество пасадочных мест: {AirportItem.baseInfo.NumberOfPassengers}\r\n");
                    OutTextValue.AppendText($" Год выпуска: {AirportItem.baseInfo.YearOfIssue}\r\n");
                    OutTextValue.AppendText($" Грузоподъемность: {AirportItem.technicalCharacteristics.Carrying}\r\n");
                    OutTextValue.AppendText($" Дата последнего тех.обслуживания: {AirportItem.baseInfo.DateOfTheLatestMaintenance.Date}." +
                        $"{AirportItem.baseInfo.DateOfTheLatestMaintenance.Month}.{AirportItem.baseInfo.DateOfTheLatestMaintenance.Year}\r\n");
                    OutTextValue.AppendText(" Экипаж:\r\n");
                    foreach (CrewMember item in AirportItem.baseInfo.CrewMembers)
                    {
                        OutTextValue.AppendText($"  Член экипажа №{AirportItem.baseInfo.CrewMembers.IndexOf(item) + 1}\r\n");
                        OutTextValue.AppendText($"  Фамилия: {item.Surname}\r\n");
                        OutTextValue.AppendText($"  Имя: {item.Name}\r\n");
                        OutTextValue.AppendText($"  Отчество: {item.Patronymic}\r\n");
                        OutTextValue.AppendText($"  Должность: {item.Position}\r\n");
                        OutTextValue.AppendText($"  Возраст: {item.Age}\r\n");
                        OutTextValue.AppendText($"  Стаж(лет): {item.Experience}\r\n");
                    }
                    OutTextValue.AppendText(" Производитель\r\n");
                    OutTextValue.AppendText($"  Название: {AirportItem.technicalCharacteristics.AirplaneManufacturer.Name}\r\n");
                    OutTextValue.AppendText($"  Страна: {AirportItem.technicalCharacteristics.AirplaneManufacturer.Country}\r\n");
                    OutTextValue.AppendText($"  Год основания: {AirportItem.technicalCharacteristics.AirplaneManufacturer.YearOfFoundation}\r\n");
                    OutTextValue.AppendText($"  Типы производимых самолетов: \r\n");
                    foreach (string el in AirportItem.technicalCharacteristics.AirplaneManufacturer.TypesOfAircraft)
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
                    formatter.Serialize(file, AirportInfrastructure.Airport);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Push_Info_button_Click(object sender, EventArgs e)
        {
            AirportInfrastructure.Airport.Add(airplane);
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

        private void CreateAirportInfrastructure_Click(object sender, EventArgs e)
        {
            creator.Create(new List<Airplane>());
        }
    }
}
