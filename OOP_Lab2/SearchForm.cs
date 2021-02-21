using System;
using System.Collections.Generic;
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

            public string ManufacturerName
            {
                get => manufacturerName;
                set => manufacturerName = value;
            }

            public string Type
            {
                get => type;
                set => type = value;
            }

            public int NumberOfPassengers
            {
                get => numberOfPassengers;
                set => numberOfPassengers = value;
            }

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
                        if (airplane.Carrying == searchElem.NumberOfPassengers && !searchResult.Contains(airplane)
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
                foreach (Airplane AirportItem in searchResult)
                {

                    SearchResult.AppendText("\n---------------------------------------------\n\r\n");
                    SearchResult.AppendText($" Airplane №{ AirportItem.ID}\r\n");
                    SearchResult.AppendText($" Тип: {AirportItem.Type}\r\n");
                    SearchResult.AppendText($" Модель: {AirportItem.Model}\r\n");
                    SearchResult.AppendText($" Количество пасадочных мест: {AirportItem.NumberOfPassengers}\r\n");
                    SearchResult.AppendText($" Год выпуска: {AirportItem.YearOfIssue}\r\n");
                    SearchResult.AppendText($" Грузоподъемность: {AirportItem.Carrying}\r\n");
                    SearchResult.AppendText($" Дата последнего тех.обслуживания: {AirportItem.DateOfTheLatestMaintenance.Date}." +
                        $"{AirportItem.DateOfTheLatestMaintenance.Month}.{AirportItem.DateOfTheLatestMaintenance.Year}\r\n");
                    SearchResult.AppendText(" Экипаж:\r\n");
                    foreach (CrewMember item in AirportItem.CrewMembers)
                    {
                        SearchResult.AppendText($"  Член экипажа №{AirportItem.CrewMembers.IndexOf(item) + 1}\r\n");
                        SearchResult.AppendText($"  Фамилия: {item.Surname}\r\n");
                        SearchResult.AppendText($"  Имя: {item.Name}\r\n");
                        SearchResult.AppendText($"  Отчество: {item.Patronymic}\r\n");
                        SearchResult.AppendText($"  Должность: {item.Position}\r\n");
                        SearchResult.AppendText($"  Возраст: {item.Age}\r\n");
                        SearchResult.AppendText($"  Стаж(лет): {item.Experience}\r\n");
                    }
                    SearchResult.AppendText(" Производитель\r\n");
                    SearchResult.AppendText($"  Название: {AirportItem.AirplaneManufacturer.Name}\r\n");
                    SearchResult.AppendText($"  Страна: {AirportItem.AirplaneManufacturer.Country}\r\n");
                    SearchResult.AppendText($"  Год основания: {AirportItem.AirplaneManufacturer.YearOfFoundation}\r\n");
                    SearchResult.AppendText($"  Типы производимых самолетов: \r\n");
                    foreach (string el in AirportItem.AirplaneManufacturer.TypesOfAircraft)
                        SearchResult.AppendText($"   {el}\r\n");


                }

            }
            else if (radioButtonPartillySearch.Checked)
            {

            }
            searchElem = new SearchElem();
            searchResult = new List<Airplane>();
            SearchTypeValue.ResetText();
            SearchTypeValue.ResetText();
            SearchNumberOfPassengersValue.ResetText();
            SearchManufacturerNameValue.ResetText();
        }
    }
}
