using System;

namespace views
{
    public class Menu
    {
        public static void Show()
        {
            Form form = new Form();
            form.Text = "Hello World";
            form.Width = 500;
            form.Height = 500;

            form.Show();

        }
    }
}