using System.Drawing;

namespace OOP_Lab2
{
    public class UserSettings
    {
        private static UserSettings userSettings;
        private Color backColor;
        private double opacity;
        private Font font;
        private Size size;
        private UserSettings(AirplaneInfo form)
        {
            backColor = form.BackColor;
            opacity = form.Opacity;
            font = form.Font;
            size = form.Size;
        }

        public Color GetBackColor
        {
            get => backColor;
            private set => backColor = value;
        }

        public double GetOpacity
        {
            get => opacity;
            private set => opacity = value;
        }

        public Font GetFont
        {
            get => font;
            private set => font = value;
        }

        public Size GetSize
        {
            get => size;
            private set => size = value;
        }

        public static UserSettings getUserSettings(AirplaneInfo form)
        {
            if (userSettings == null)
                userSettings = new UserSettings(form);
            return userSettings;
        }
    }
}
