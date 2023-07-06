using System.Drawing;

namespace Views
{
    public class UserView
    {
        public static bool isOpen = false;
        public static Form user;

        public static ListView List(Panel panel2)
        {
            ListView lista = new ListView();
            lista.Size = new System.Drawing.Size(900, 450);
            lista.Location = new System.Drawing.Point(220, 0);
            lista.Columns.Add("ID", 225);
            lista.Columns.Add("Nome", 225);
            lista.Columns.Add("Login", 225);
            lista.Columns.Add("Senha", 225);
            lista.View = View.Details;
            lista.BackColor = System.Drawing.Color.White;
            lista.BorderStyle = BorderStyle.None;
            lista.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.MultiSelect = false;
            lista.HideSelection = false;


            IEnumerable<Models.User> usuarioList = Controllers.UserController.Index();
            foreach (Models.User usuario in usuarioList)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Name);
                item.SubItems.Add(usuario.Login);
                item.SubItems.Add(usuario.Password);
                lista.Items.Add(item);
            }

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
                try
                {
                    panel2.Controls.Clear();
                    string id = lista.SelectedItems[0].Text;
                    panel2.Controls.Add(UserView.Editar(id, panel2));
                }
                catch (System.Exception)
                {

                    MessageBox.Show("Selecione um Usuario para Editar");
                    panel2.Controls.Clear();
                    panel2.Controls.Add(Views.UserView.List(panel2));

                    Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.UserView.Adicionar(panel2), panel2);
                    Button buttonRemove = Views.ButtonAED.btnDeletar(Views.UserView.Adicionar(panel2), panel2);

                    panel2.Controls.Add(buttonAdd);
                    panel2.Controls.Add(buttonRemove);
                }
            };

            string imagePath8 = "src/assets/editar.png";
            Image image8 = Image.FromFile(imagePath8);
            image8 = new Bitmap(image8, new Size(26, 26));
            buttonEdit.Image = image8;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            panel2.Controls.Add(buttonEdit);


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
                try
                {
                    string id = lista.SelectedItems[0].Text;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Confirmação", buttons);
                    if (result == DialogResult.Yes)
                    {

                        Controllers.UserController.Delete(Int32.Parse(id));
                        panel2.Controls.Clear();
                        panel2.Controls.Add(UserView.List(panel2));
                    }
                    else
                    {
                        panel2.Controls.Clear();
                        panel2.Controls.Add(UserView.List(panel2));
                    }

                }
                catch (System.Exception)
                {

                    MessageBox.Show("Selecione um Usuario para Remover");
                }


            };

            string imagePath9 = "src/assets/remove.png";
            Image image9 = Image.FromFile(imagePath9);
            image9 = new Bitmap(image9, new Size(26, 26));
            buttonRemove.Image = image9;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;

            panel2.Controls.Add(buttonRemove);
            Button buttonAdd = Views.ButtonAED.btnAdicionar(UserView.Adicionar(panel2), panel2);

            panel2.Controls.Add(buttonAdd);
            return lista;

        }

        public static Panel Editar(string id, Panel panel2)
        {
            List<Models.User> users = Controllers.UserController.show(id);


            Panel editar = new Panel();
            editar.Size = new System.Drawing.Size(900, 450);
            editar.Location = new System.Drawing.Point(220, 0);
            editar.BackColor = Color.White;

            Label lblName = new Label();
            lblName.Text = "Nome";
            lblName.Location = new System.Drawing.Point(190, 50);
            lblName.Size = new System.Drawing.Size(100, 20);
            editar.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(190, 70);
            txtName.Size = new System.Drawing.Size(500, 40);
            txtName.Text = users[0].Name;
            editar.Controls.Add(txtName);

            Label lblLogin = new Label();
            lblLogin.Text = "Login";
            lblLogin.Location = new System.Drawing.Point(190, 120);
            lblLogin.Size = new System.Drawing.Size(100, 20);
            editar.Controls.Add(lblLogin);

            TextBox txtLogin = new TextBox();
            txtLogin.Location = new System.Drawing.Point(190, 140);
            txtLogin.Size = new System.Drawing.Size(500, 40);
            txtLogin.Text = users[0].Login;
            editar.Controls.Add(txtLogin);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Location = new System.Drawing.Point(190, 190);
            lblSenha.Size = new System.Drawing.Size(100, 20);
            editar.Controls.Add(lblSenha);

            TextBox txtSenha = new TextBox();
            txtSenha.Location = new System.Drawing.Point(190, 210);
            txtSenha.Size = new System.Drawing.Size(500, 40);
            txtSenha.Text = users[0].Password;
            editar.Controls.Add(txtSenha);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Alterar";
            btnSalvar.Location = new System.Drawing.Point(370, 270);
            btnSalvar.Size = new System.Drawing.Size(100, 20);

            btnSalvar.Click += (sender, e) =>
            {
                Controllers.UserController.Update(Int32.Parse(id), new Models.User(txtName.Text, txtLogin.Text, txtSenha.Text));
                panel2.Controls.Clear();
                panel2.Controls.Add(UserView.List(panel2));
                Button buttonAdd = Views.ButtonAED.btnAdicionar(UserView.Adicionar(panel2), panel2);
                Button buttonRemove = Views.ButtonAED.btnDeletar(UserView.Adicionar(panel2), panel2);
                panel2.Controls.Add(buttonAdd);
                panel2.Controls.Add(buttonRemove);
            };
            editar.Controls.Add(btnSalvar);

            return editar;
        }
        public static Panel Adicionar(Panel panel)
        {
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lblName = new Label();
            lblName.Text = "Nome";
            lblName.Location = new System.Drawing.Point(190, 50);
            lblName.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(190, 70);
            txtName.Size = new System.Drawing.Size(500, 40);
            form.Controls.Add(txtName);


            Label lblLogin = new Label();
            lblLogin.Text = "Login";
            lblLogin.Location = new System.Drawing.Point(190, 120);
            lblLogin.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblLogin);

            TextBox txtLogin = new TextBox();
            txtLogin.Location = new System.Drawing.Point(190, 140);
            txtLogin.Size = new System.Drawing.Size(500, 40);
            form.Controls.Add(txtLogin);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Location = new System.Drawing.Point(190, 190);
            lblSenha.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblSenha);

            TextBox txtSenha = new TextBox();
            txtSenha.Location = new System.Drawing.Point(190, 210);
            txtSenha.Size = new System.Drawing.Size(500, 40);
            form.Controls.Add(txtSenha);


            Button btnSalvar = new Button();
            btnSalvar.Text = "Adicionar";
            btnSalvar.Location = new System.Drawing.Point(370, 270);
            btnSalvar.Size = new System.Drawing.Size(100, 20);
            btnSalvar.Click += (sender, e) =>
            {
                if (txtName.Text != "" && txtLogin.Text != "" && txtSenha.Text != "")
                {
                    Controllers.UserController.store(new Models.User(txtName.Text, txtLogin.Text, txtSenha.Text));
                    panel.Controls.Clear();
                    panel.Controls.Add(UserView.List(panel));
                    Button buttonAdd = Views.ButtonAED.btnAdicionar(UserView.Adicionar(panel), panel);
                    Button buttonRemove = Views.ButtonAED.btnDeletar(UserView.Adicionar(panel), panel);

                    panel.Controls.Add(buttonAdd);
                    panel.Controls.Add(buttonRemove);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            };
            form.Controls.Add(btnSalvar);

            return form;
        }
    }
}


