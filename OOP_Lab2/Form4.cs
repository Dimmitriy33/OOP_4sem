using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class SearchForm : Form
    {
        SearchElem searchElem = new SearchElem();
        List<Airplane> searchList;
        List<Airplane> searchResult = new List<Airplane>();

        private class SearchElem
        {
            private string manufacturerName;
            private string type;
            private int numberOfPassengers;
            private int carrying;

            public SearchElem()
            {

            }

            public SearchElem(string m, string t, int n, int c)
            {
                this.ManufacturerName = m;
                this.Type = t;
                this.NumberOfPassengers = n;
                this.Carrying = c;
            }

            [StringLength(30)]
            public string ManufacturerName
            {
                get => manufacturerName;
                set => manufacturerName = value;
            }

            [StringLength(13)]
            public string Type
            {
                get => type;
                set => type = value;
            }

            [My]
            [Range(0, 300)]
            public int NumberOfPassengers
            {
                get => numberOfPassengers;
                set => numberOfPassengers = value;
            }

            [My]
            [Range(1000, 15000)]
            public int Carrying
            {
                get => carrying;
                set => carrying = value;
            }
        }
        public SearchForm(List<Airplane> airplanes)
        {
            InitializeComponent();
            searchList = airplanes;
        }

        private void SearchTypeValue_TextChanged(object sender, System.EventArgs e)
        {
            searchElem.Type = SearchTypeValue.Text;
        }

        private void SearchNumberOfPassengersValue_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                searchElem.NumberOfPassengers = Convert.ToInt32(SearchNumberOfPassengersValue.Text);
            }
            catch
            {

            }
        }

        private void SearchCarryingValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                searchElem.Carrying = Convert.ToInt32(SearchCarryingValue.Text);
            }
            catch
            {

            }
        }

        private void SearchManufacturerNameValue_TextChanged(object sender, EventArgs e)
        {
            searchElem.ManufacturerName = SearchManufacturerNameValue.Text;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            if (radioButtonFullSearch.Checked)
            {
                foreach (Airplane airplane in searchList)
                {
                    if (SearchTypeValue.Modified)
                        if (airplane.Type == searchElem.Type && !searchResult.Contains(airplane))
                            searchResult.Add(airplane);
                    if (SearchCarryingValue.Modified)
                        if (airplane.Carrying == searchElem.Carrying && !searchResult.Contains(airplane)
                            && (!SearchTypeValue.Modified || airplane.Type == searchElem.Type))
                            searchResult.Add(airplane);
                    if (SearchNumberOfPassengersValue.Modified)
                        if (airplane.NumberOfPassengers == searchElem.NumberOfPassengers && !searchResult.Contains(airplane)
                            && (!SearchTypeValue.Modified || airplane.Type == searchElem.Type)
                            && (!SearchCarryingValue.Modified || airplane.Carrying == searchElem.Carrying))
                            searchResult.Add(airplane);
                    if (SearchManufacturerNameValue.Modified)
                        if (airplane.AirplaneManufacturer.Name.Equals(searchElem.ManufacturerName)
                            && (!SearchTypeValue.Modified || airplane.Type.Equals(searchElem.Type))
                            && (!SearchCarryingValue.Modified || airplane.Carrying.Equals(searchElem.Carrying))
                            && (!SearchNumberOfPassengersValue.Modified || airplane.Carrying.Equals(searchElem.NumberOfPassengers))
                            && !searchResult.Contains(airplane))
                            searchResult.Add(airplane);
                }
                SearchOut.ResetText();
                foreach (Airplane AirportItem in searchResult)
                {
                    SearchOut.AppendText("\n---------------------------------------------\n\r\n");
                    SearchOut.AppendText($" Airplane №{ AirportItem.ID}\r\n");
                    SearchOut.AppendText($" Тип: {AirportItem.Type}\r\n");
                    SearchOut.AppendText($" Модель: {AirportItem.Model}\r\n");
                    SearchOut.AppendText($" Количество пасадочных мест: {AirportItem.NumberOfPassengers}\r\n");
                    SearchOut.AppendText($" Год выпуска: {AirportItem.YearOfIssue}\r\n");
                    SearchOut.AppendText($" Грузоподъемность: {AirportItem.Carrying}\r\n");
                    SearchOut.AppendText($" Дата последнего тех.обслуживания: {AirportItem.DateOfTheLatestMaintenance.Date}." +
                        $"{AirportItem.DateOfTheLatestMaintenance.Month}.{AirportItem.DateOfTheLatestMaintenance.Year}\r\n");
                    SearchOut.AppendText(" Экипаж:\r\n");
                    foreach (CrewMember item in AirportItem.CrewMembers)
                    {
                        SearchOut.AppendText($"  Член экипажа №{AirportItem.CrewMembers.IndexOf(item) + 1}\r\n");
                        SearchOut.AppendText($"  Фамилия: {item.Surname}\r\n");
                        SearchOut.AppendText($"  Имя: {item.Name}\r\n");
                        SearchOut.AppendText($"  Отчество: {item.Patronymic}\r\n");
                        SearchOut.AppendText($"  Должность: {item.Position}\r\n");
                        SearchOut.AppendText($"  Возраст: {item.Age}\r\n");
                        SearchOut.AppendText($"  Стаж(лет): {item.Experience}\r\n");
                    }
                    SearchOut.AppendText(" Производитель\r\n");
                    SearchOut.AppendText($"  Название: {AirportItem.AirplaneManufacturer.Name}\r\n");
                    SearchOut.AppendText($"  Страна: {AirportItem.AirplaneManufacturer.Country}\r\n");
                    SearchOut.AppendText($"  Год основания: {AirportItem.AirplaneManufacturer.YearOfFoundation}\r\n");
                    SearchOut.AppendText($"  Типы производимых самолетов: \r\n");
                    foreach (string el in AirportItem.AirplaneManufacturer.TypesOfAircraft)
                        SearchOut.AppendText($"   {el}\r\n");


                }

            }
            else if (radioButtonPartillySearch.Checked)
            {

            }
            searchElem = new SearchElem();
            searchResult = new List<Airplane>();
            SearchTypeValue.ResetText();
            SearchCarryingValue.ResetText();
            SearchNumberOfPassengersValue.ResetText();
            SearchManufacturerNameValue.ResetText();
        }

        private void ManufacturerName_Click(object sender, EventArgs e)
        {

        }
    }
}

