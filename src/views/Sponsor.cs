namespace views
{
    public class Sponsor
    {
        public static bool isOpen = false;
        public static Form sponsor;

        public static void List()
        {
            if (!isOpen)
            {
                sponsor = new Form();
                sponsor.Text = "Patrocinador";
                sponsor.Size = new Size(500, 500);
                sponsor.FormBorderStyle = FormBorderStyle.FixedDialog;
                sponsor.MaximizeBox = false;
                sponsor.StartPosition = FormStartPosition.CenterScreen;
                sponsor.FormClosed += (s, e) => isOpen = false;

                Label lblName = new Label();
                lblName.Text = " Nome do Patrocinador:";
                lblName.Location = new Point(10, 10);
                lblName.AutoSize = true;

                TextBox txtName = new TextBox();
                txtName.Location = new Point(10, 30);
                txtName.Size = new Size(200, 20);

                
                Button btnAdd = new Button();
                btnAdd.Text = "Adicionar";
                btnAdd.Location = new Point(10, 310);
                btnAdd.AutoSize = true;

                sponsor.Controls.Add(lblName);
                sponsor.Controls.Add(txtName);

                sponsor.Controls.Add(btnAdd);

                btnAdd.Click += (s, e) =>
                {
                    string name = txtName.Text;
                    

                    if (name == "" )
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        MessageBox.Show("Patrocinador adicionado com sucesso!");
                        txtName.Text = "";
                        
                    }
                };

                sponsor.ShowDialog();
            }
        }
    }
}

