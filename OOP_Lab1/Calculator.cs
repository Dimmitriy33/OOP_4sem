using System;
using System.Windows.Forms;

namespace OOP_Lab1
{
    public partial class Calculator : Form
    {
        private class Info
        {
            private string type;
            private int size;

            public string Type
            {
                get => type;
                set => type = value;
            }

            public int Size
            {
                get => size;
                set => size = value;
            }
            public Info()
            {
                type = "";
                size = 0;
            }
        }

        private Info ClothesType = new Info();
        private Info BootsType = new Info();
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClothesType.Size = Convert.ToInt32(textBox7.Text);
            }
            catch (Exception)
            {

            }
            ClothesType.Type = label1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClothesType.Size = Convert.ToInt32(textBox8.Text);
            }
            catch (Exception)
            {

            }
            ClothesType.Type = label2.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClothesType.Size = Convert.ToInt32(textBox9.Text);
            }
            catch (Exception)
            {

            }
            ClothesType.Type = label3.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClothesType.Size = Convert.ToInt32(textBox10.Text);
            }
            catch (Exception)
            {

            }
            ClothesType.Type = label4.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BootsType.Size = Convert.ToInt32(textBox11.Text);
            }
            catch (Exception)
            {

            }
            BootsType.Type = label1.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BootsType.Size = Convert.ToInt32(textBox12.Text);
            }
            catch (Exception)
            {

            }
            BootsType.Type = label2.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BootsType.Size = Convert.ToInt32(textBox13.Text);
            }
            catch (Exception)
            {

            }
            BootsType.Type = label3.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BootsType.Size = Convert.ToInt32(textBox14.Text);
            }
            catch (Exception)
            {

            }
            BootsType.Type = label4.Text;
        }
        internal void button1_Click(object sender, EventArgs e)
        {
            switch (ClothesType.Type)
            {
                case "EUR":
                    switch (ClothesType.Size)
                    {
                        case 34:
                            textBox8.Text = "8";
                            textBox9.Text = "40";
                            textBox10.Text = "6";
                            break;
                        case 36:
                            textBox8.Text = "10";
                            textBox9.Text = "42";
                            textBox10.Text = "8";
                            break;
                        case 38:
                            textBox8.Text = "10";
                            textBox9.Text = "44";
                            textBox10.Text = "10";
                            break;
                        case 40:
                            textBox8.Text = "12";
                            textBox9.Text = "46";
                            textBox10.Text = "12";
                            break;
                        case 42:
                            textBox8.Text = "14";
                            textBox9.Text = "48";
                            textBox10.Text = "14";
                            break;
                        case 44:
                            textBox8.Text = "16";
                            textBox9.Text = "50";
                            textBox10.Text = "16";
                            break;
                        case 46:
                            textBox8.Text = "18";
                            textBox9.Text = "52";
                            textBox10.Text = "18";
                            break;
                        case 48:
                            textBox8.Text = "20";
                            textBox9.Text = "54";
                            textBox10.Text = "20";
                            break;
                        case 50:
                            textBox8.Text = "22";
                            textBox9.Text = "56";
                            textBox10.Text = "22";
                            break;
                        default:
                            textBox8.Text = "unknown";
                            textBox9.Text = "unknown";
                            textBox10.Text = "unknown";
                            break;
                    }
                    break;
                case "GB":
                    switch (ClothesType.Size)
                    {
                        case 8:
                            textBox7.Text = "34";
                            textBox9.Text = "40";
                            textBox10.Text = "6";
                            break;
                        case 10:
                            textBox7.Text = "36";
                            textBox9.Text = "42";
                            textBox10.Text = "8";
                            break;
                        case 12:
                            textBox7.Text = "38";
                            textBox9.Text = "44";
                            textBox10.Text = "10";
                            break;
                        case 14:
                            textBox7.Text = "40";
                            textBox9.Text = "46";
                            textBox10.Text = "12";
                            break;
                        case 16:
                            textBox7.Text = "42";
                            textBox9.Text = "48";
                            textBox10.Text = "14";
                            break;
                        case 18:
                            textBox7.Text = "44";
                            textBox9.Text = "50";
                            textBox10.Text = "16";
                            break;
                        case 20:
                            textBox7.Text = "46";
                            textBox9.Text = "52";
                            textBox10.Text = "18";
                            break;
                        case 22:
                            textBox7.Text = "48";
                            textBox9.Text = "54";
                            textBox10.Text = "20";
                            break;
                        case 24:
                            textBox7.Text = "50";
                            textBox9.Text = "56";
                            textBox10.Text = "22";
                            break;
                        default:
                            textBox7.Text = "unknown";
                            textBox9.Text = "unknown";
                            textBox10.Text = "unknown";
                            break;
                    }
                    break;
                case "RUS":
                    switch (ClothesType.Size)
                    {
                        case 40:
                            textBox7.Text = "34";
                            textBox8.Text = "8";
                            textBox10.Text = "6";
                            break;
                        case 42:
                            textBox7.Text = "36";
                            textBox8.Text = "10";
                            textBox10.Text = "8";
                            break;
                        case 44:
                            textBox7.Text = "38";
                            textBox8.Text = "12";
                            textBox10.Text = "10";
                            break;
                        case 46:
                            textBox7.Text = "40";
                            textBox8.Text = "14";
                            textBox10.Text = "12";
                            break;
                        case 48:
                            textBox7.Text = "42";
                            textBox8.Text = "16";
                            textBox10.Text = "14";
                            break;
                        case 50:
                            textBox7.Text = "44";
                            textBox8.Text = "18";
                            textBox10.Text = "16";
                            break;
                        case 52:
                            textBox7.Text = "46";
                            textBox8.Text = "20";
                            textBox10.Text = "18";
                            break;
                        case 54:
                            textBox7.Text = "48";
                            textBox8.Text = "22";
                            textBox10.Text = "20";
                            break;
                        case 56:
                            textBox7.Text = "50";
                            textBox8.Text = "24";
                            textBox10.Text = "22";
                            break;
                        default:
                            textBox7.Text = "unknown";
                            textBox8.Text = "unknown";
                            textBox10.Text = "unknown";
                            break;
                    }
                    break;
                case "USA":
                    switch (ClothesType.Size)
                    {
                        case 6:
                            textBox7.Text = "34";
                            textBox8.Text = "8";
                            textBox9.Text = "40";
                            break;
                        case 8:
                            textBox7.Text = "36";
                            textBox8.Text = "10";
                            textBox9.Text = "42";
                            break;
                        case 10:
                            textBox7.Text = "38";
                            textBox8.Text = "12";
                            textBox9.Text = "44";
                            break;
                        case 12:
                            textBox7.Text = "40";
                            textBox8.Text = "14";
                            textBox9.Text = "46";
                            break;
                        case 14:
                            textBox7.Text = "42";
                            textBox8.Text = "16";
                            textBox9.Text = "48";
                            break;
                        case 16:
                            textBox7.Text = "44";
                            textBox8.Text = "18";
                            textBox9.Text = "50";
                            break;
                        case 18:
                            textBox7.Text = "46";
                            textBox8.Text = "20";
                            textBox9.Text = "52";
                            break;
                        case 20:
                            textBox7.Text = "48";
                            textBox8.Text = "22";
                            textBox9.Text = "54";
                            break;
                        case 22:
                            textBox7.Text = "50";
                            textBox8.Text = "24";
                            textBox9.Text = "56";
                            break;
                        default:
                            textBox7.Text = "unknown";
                            textBox8.Text = "unknown";
                            textBox9.Text = "unknown";
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        internal void button2_Click(object sender, EventArgs e)
        {
            switch (BootsType.Type)
            {
                case "EUR":
                    switch (BootsType.Size)
                    {
                        case 37:
                            textBox12.Text = "6";
                            textBox13.Text = "36";
                            textBox14.Text = "7";
                            break;
                        case 38:
                            textBox12.Text = "7";
                            textBox13.Text = "37";
                            textBox14.Text = "8";
                            break;
                        case 39:
                            textBox12.Text = "8";
                            textBox13.Text = "38";
                            textBox14.Text = "9";
                            break;
                        case 40:
                            textBox12.Text = "9";
                            textBox13.Text = "39";
                            textBox14.Text = "10";
                            break;
                        case 41:
                            textBox12.Text = "10";
                            textBox13.Text = "40";
                            textBox14.Text = "11";
                            break;
                        case 42:
                            textBox12.Text = "11";
                            textBox13.Text = "41";
                            textBox14.Text = "12";
                            break;
                        case 43:
                            textBox12.Text = "12";
                            textBox13.Text = "42";
                            textBox14.Text = "13";
                            break;
                        case 44:
                            textBox12.Text = "13";
                            textBox13.Text = "43";
                            textBox14.Text = "14";
                            break;
                        case 45:
                            textBox12.Text = "14";
                            textBox13.Text = "44";
                            textBox14.Text = "15";
                            break;
                        default:
                            textBox12.Text = "unknown";
                            textBox13.Text = "unknown";
                            textBox14.Text = "unknown";
                            break;
                    }
                    break;
                case "GB":
                    switch (BootsType.Size)
                    {
                        case 6:
                            textBox11.Text = "37";
                            textBox13.Text = "36";
                            textBox14.Text = "7";
                            break;
                        case 7:
                            textBox11.Text = "38";
                            textBox13.Text = "37";
                            textBox14.Text = "8";
                            break;
                        case 8:
                            textBox11.Text = "39";
                            textBox13.Text = "38";
                            textBox14.Text = "9";
                            break;
                        case 9:
                            textBox11.Text = "40";
                            textBox13.Text = "39";
                            textBox14.Text = "10";
                            break;
                        case 10:
                            textBox11.Text = "41";
                            textBox13.Text = "40";
                            textBox14.Text = "11";
                            break;
                        case 11:
                            textBox11.Text = "42";
                            textBox13.Text = "41";
                            textBox14.Text = "12";
                            break;
                        case 12:
                            textBox11.Text = "43";
                            textBox13.Text = "42";
                            textBox14.Text = "13";
                            break;
                        case 13:
                            textBox11.Text = "44";
                            textBox13.Text = "43";
                            textBox14.Text = "14";
                            break;
                        case 14:
                            textBox11.Text = "45";
                            textBox13.Text = "44";
                            textBox14.Text = "15";
                            break;
                        default:
                            textBox11.Text = "unknown";
                            textBox13.Text = "unknown";
                            textBox14.Text = "unknown";
                            break;
                    }
                    break;
                case "RUS":
                    switch (BootsType.Size)
                    {
                        case 36:
                            textBox11.Text = "37";
                            textBox12.Text = "6";
                            textBox14.Text = "7";
                            break;
                        case 37:
                            textBox11.Text = "38";
                            textBox12.Text = "7";
                            textBox14.Text = "8";
                            break;
                        case 38:
                            textBox11.Text = "39";
                            textBox12.Text = "8";
                            textBox14.Text = "9";
                            break;
                        case 39:
                            textBox11.Text = "40";
                            textBox12.Text = "9";
                            textBox14.Text = "10";
                            break;
                        case 40:
                            textBox11.Text = "41";
                            textBox12.Text = "10";
                            textBox14.Text = "11";
                            break;
                        case 41:
                            textBox11.Text = "42";
                            textBox12.Text = "11";
                            textBox14.Text = "12";
                            break;
                        case 42:
                            textBox11.Text = "43";
                            textBox12.Text = "12";
                            textBox14.Text = "13";
                            break;
                        case 43:
                            textBox11.Text = "44";
                            textBox12.Text = "13";
                            textBox14.Text = "14";
                            break;
                        case 44:
                            textBox11.Text = "45";
                            textBox12.Text = "14";
                            textBox14.Text = "15";
                            break;
                        default:
                            textBox11.Text = "unknown";
                            textBox12.Text = "unknown";
                            textBox14.Text = "unknown";
                            break;
                    }
                    break;
                case "USA":
                    switch (BootsType.Size)
                    {
                        case 36:
                            textBox11.Text = "37";
                            textBox12.Text = "6";
                            textBox13.Text = "36";
                            break;
                        case 37:
                            textBox11.Text = "38";
                            textBox12.Text = "7";
                            textBox13.Text = "37";
                            break;
                        case 38:
                            textBox11.Text = "39";
                            textBox12.Text = "8";
                            textBox13.Text = "38";
                            break;
                        case 39:
                            textBox11.Text = "40";
                            textBox12.Text = "9";
                            textBox13.Text = "39";
                            break;
                        case 40:
                            textBox11.Text = "41";
                            textBox12.Text = "10";
                            textBox13.Text = "40";
                            break;
                        case 41:
                            textBox11.Text = "42";
                            textBox12.Text = "11";
                            textBox13.Text = "41";
                            break;
                        case 42:
                            textBox11.Text = "43";
                            textBox12.Text = "12";
                            textBox13.Text = "42";
                            break;
                        case 43:
                            textBox11.Text = "44";
                            textBox12.Text = "13";
                            textBox13.Text = "43";
                            break;
                        case 44:
                            textBox11.Text = "45";
                            textBox12.Text = "14";
                            textBox13.Text = "44";
                            break;
                        default:
                            textBox11.Text = "unknown";
                            textBox12.Text = "unknown";
                            textBox13.Text = "unknown";
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 13) // 8 - backspace, 13 - enter
            {
                MessageBox.Show("incorrect value");
                e.Handled = true;
            }
            else if (number == 13)
            {
                button1_Click(sender, e);
                button2_Click(sender, e);
            }
        }
    }
}
