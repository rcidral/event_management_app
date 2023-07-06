namespace Views
{
    public class ButtonAED
    {
        public static Button btnAdicionar(Control v, Panel panel)
        {
            Button buttonAdd = new Button();
            buttonAdd.Location = new System.Drawing.Point(325, 490);
            buttonAdd.Size = new System.Drawing.Size(180, 40);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            buttonAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            buttonAdd.Text = "ADICIONAR";
            buttonAdd.Font = new Font("Arial", 13, FontStyle.Bold);
            buttonAdd.Click += (sender, e) =>
            {
                panel.Controls.Clear();
                panel.Controls.Add(v);
            };

            string imagePath7 = "src/assets/adicionar.png";
            Image image7 = Image.FromFile(imagePath7);
            image7 = new Bitmap(image7, new Size(26, 26));
            buttonAdd.Image = image7;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;

            return buttonAdd;
        }

        public static Button btnEditar(Control v, Panel panel)
        {
            Button buttonEdit = new Button();
            buttonEdit.Location = new System.Drawing.Point(565, 490);
            buttonEdit.Size = new System.Drawing.Size(180, 40);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            buttonEdit.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            buttonEdit.Text = "EDITAR";
            buttonEdit.Font = new Font("Arial", 13, FontStyle.Bold);
            buttonEdit.Click += (sender, e) =>
            {
                panel.Controls.Clear();
                panel.Controls.Add(v);
            };


            string imagePath8 = "src/assets/editar.png";
            Image image8 = Image.FromFile(imagePath8);
            image8 = new Bitmap(image8, new Size(26, 26));
            buttonEdit.Image = image8;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;


            return buttonEdit;
        }

        public static Button btnDeletar(Control v, Panel panel)
        {
            Button buttonRemove = new Button();
            buttonRemove.Location = new System.Drawing.Point(805, 490);
            buttonRemove.Size = new System.Drawing.Size(180, 40);
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            buttonRemove.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            buttonRemove.Text = "REMOVER";
            buttonRemove.Font = new Font("Arial", 13, FontStyle.Bold);
            buttonRemove.Click += (sender, e) =>
            {
                panel.Controls.Clear();
                panel.Controls.Add(v);
            };

            string imagePath9 = "src/assets/remove.png";
            Image image9 = Image.FromFile(imagePath9);
            image9 = new Bitmap(image9, new Size(26, 26));
            buttonRemove.Image = image9;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;

            return buttonRemove;
        }
    }
}