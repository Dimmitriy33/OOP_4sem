using System;

namespace OOP_Lab2
{
    [Serializable]
    public class CrewMember
    {
        private string surname;
        private string name;
        private string patronymic;
        private string position;
        private int age;
        private int experience;

        public CrewMember()
        {

        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int Experience
        {
            get => experience;
            set => experience = value;
        }
    }
}
