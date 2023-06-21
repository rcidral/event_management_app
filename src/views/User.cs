using System;
using System.Windows.Forms;

namespace views{
    public class UserView {
        public static bool isOpen = false;
        public static Form user;

        public static ListView List() {      
            ListView lista = new ListView();
            lista.Size = new System.Drawing.Size(600, 500);
            lista.Location = new System.Drawing.Point(220, 0);
            lista.View = View.Details;
            lista.Columns.Add("ID", 30);
            lista.Columns.Add("Nome", 60);
            lista.Columns.Add("Login", 100);
            lista.Columns.Add("Senha", 110);

            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.MultiSelect = false;
            lista.HideSelection = false;

            IEnumerable<Models.User> usuarioList = Controllers.UserController.Index();
            foreach (Models.User usuario in usuarioList) {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Name);
                item.SubItems.Add(usuario.Login);
                item.SubItems.Add(usuario.Password);
                lista.Items.Add(item);
            }

            Button btnAdd = new Button();
            btnAdd.Text = "Adicionar";
            btnAdd.Top = 300;
            btnAdd.Left = 0;
            btnAdd.Size = new System.Drawing.Size(103, 25);
            btnAdd.BackColor = Color.Transparent;
            btnAdd.ForeColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.MouseHover += (sender, e) => {
                btnAdd.BackColor = Color.SkyBlue;
            };
            btnAdd.MouseLeave += (sender, e) => {
                btnAdd.BackColor = Color.Transparent;
            };
            btnAdd.Click += (sender, e) => {
                user.Close();
                user.Dispose();
                Adicionar();
                user.Close();
            };
            

            Button btnEdit = new Button();
            btnEdit.Text = "Editar";
            btnEdit.Top = 300;
            btnEdit.Left = 100;
            btnEdit.Size = new System.Drawing.Size(100, 25);
            btnEdit.BackColor = Color.Transparent;
            btnEdit.ForeColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.MouseHover += (sender, e) => {
                btnEdit.BackColor = Color.LimeGreen;
            };
            btnEdit.MouseLeave += (sender, e) => {
                btnEdit.BackColor = Color.Transparent;
            };
            btnEdit.Click += (sender, e) => {
                try
                {
                    string id = lista.SelectedItems[0].Text;
                    user.Close();
                    user.Dispose();
                    Editar(Int32.Parse(id));
                    user.Close(); 
                }
                catch
                {
                    MessageBox.Show("Selecione um Usuario para editar");
                }
                
            };

            Button BtnRemove = new Button();
            BtnRemove.Text = "Remove";
            BtnRemove.Top = 300;
            BtnRemove.Left = 200;
            BtnRemove.Size = new System.Drawing.Size(100, 25);
            BtnRemove.BackColor = Color.Transparent;
            BtnRemove.ForeColor = Color.Black;
            BtnRemove.FlatStyle = FlatStyle.Flat;
            BtnRemove.MouseHover += (sender, e) => {
                BtnRemove.BackColor = Color.SkyBlue;
            };
            BtnRemove.MouseLeave += (sender, e) => {
                BtnRemove.BackColor = Color.Transparent;
            };
            BtnRemove.Click += (sender, e) => {
                try
                {
                    string id = lista.SelectedItems[0].Text;
                    user.Close();
                    user.Dispose();
                    Remover(Int32.Parse(id));
                    user.Close();  
                }
                catch
                {
                    MessageBox.Show("Selecione um Almoxerifado para remover");
                }
                      
            };

            Button BtnVoltar = new Button();
            BtnVoltar.Text = "Voltar";
            BtnVoltar.Top = 300;
            BtnVoltar.Left = 300;
            BtnVoltar.Size = new System.Drawing.Size(100, 25);
            BtnVoltar.BackColor = Color.Transparent;
            BtnVoltar.ForeColor = Color.Black;
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.MouseHover += (sender, e) => {
                BtnVoltar.BackColor = Color.SkyBlue;
            };
            BtnVoltar.MouseLeave += (sender, e) => {
                BtnVoltar.BackColor = Color.Transparent;
            };
            BtnVoltar.Click += (sender, e) => {
                user.Hide();
                user.Close();
                user.Dispose();
            };

            return lista;
        }


        public static void Editar(int id) {
            Models.User users = Controllers.UserController.show(id);

            Form editar = new Form();
            editar.Text = "Editar Produto";
            editar.Size = new System.Drawing.Size(418, 366);
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.FormBorderStyle = FormBorderStyle.FixedSingle;
            editar.MaximizeBox = false;
            editar.MinimizeBox = false;

            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Top = 25;
            lblNome.Left = 0;
            lblNome.Size = new System.Drawing.Size(100, 25);

            TextBox txtNome = new TextBox();
            txtNome.Top = 25;
            txtNome.Left = 100;
            txtNome.Size = new System.Drawing.Size(100, 25);
            txtNome.Text = users.Name;

            Label lblLogin = new Label();
            lblLogin.Text = "Login";
            lblLogin.Top = 50;
            lblLogin.Left = 0;
            lblLogin.Size = new System.Drawing.Size(100, 25);

            TextBox txtLogin = new TextBox();
            txtLogin.Top = 50;
            txtLogin.Left = 100;
            txtLogin.Size = new System.Drawing.Size(100, 25);
            txtLogin.Text = users.Login;

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Top = 75;
            lblSenha.Left = 0;
            lblSenha.Size = new System.Drawing.Size(100, 25);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 75;
            txtSenha.Left = 100;
            txtSenha.Size = new System.Drawing.Size(100, 25);
            txtSenha.Text = users.Password;

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";  
            btnSalvar.Top = 100;
            btnSalvar.Left = 0;
            btnSalvar.Size = new System.Drawing.Size(100, 25);
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.MouseHover += (sender, e) => {
                btnSalvar.BackColor = Color.LimeGreen;
            };
            btnSalvar.MouseLeave += (sender, e) => {
                btnSalvar.BackColor = Color.Transparent;
            };
            btnSalvar.Click += (sender, e) => {
                Controllers.UserController.Update(id, new Models.User(txtNome.Text, txtLogin.Text, txtSenha.Text));
                List();
            };


            editar.Controls.Add(lblNome);
            editar.Controls.Add(txtNome);
            editar.Controls.Add(lblLogin);
            editar.Controls.Add(txtLogin);
            editar.Controls.Add(lblSenha);
            editar.Controls.Add(txtSenha);
            editar.Controls.Add(btnSalvar);
            editar.ShowDialog();
        }
            public static void Adicionar() {
            int NextId = Controllers.UserController.nextId();

            Form adicionar = new Form();
            adicionar.Text = "Adicionar Usuario";
            adicionar.Size = new System.Drawing.Size(325, 175);
            adicionar.StartPosition = FormStartPosition.CenterScreen;
            adicionar.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionar.MaximizeBox = false;
            adicionar.MinimizeBox = false;

            Label lblId = new Label();
            lblId.Text = "Id";
            lblId.Top = 0;
            lblId.Left = 0;
            lblId.Size = new System.Drawing.Size(100, 25);

            TextBox txtId = new TextBox();
            txtId.Top = 0;
            txtId.Left = 100;
            txtId.Size = new System.Drawing.Size(50, 25);
            txtId.Enabled = false;
            txtId.Text = NextId.ToString();

            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Top = 25;
            lblNome.Left = 0;
            lblNome.Size = new System.Drawing.Size(100, 25); 

            TextBox txtNome = new TextBox();
            txtNome.Top = 25;
            txtNome.Left = 100;
            txtNome.Size = new System.Drawing.Size(200, 25);

            Label lblLogin = new Label();
            lblLogin.Text = "Login";
            lblLogin.Top = 50;
            lblLogin.Left = 0;
            lblLogin.Size = new System.Drawing.Size(100, 25);

            TextBox txtLogin = new TextBox();
            txtLogin.Top = 50;
            txtLogin.Left = 100;
            txtLogin.Size = new System.Drawing.Size(200, 25);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Top = 75;
            lblSenha.Left = 0;
            lblSenha.Size = new System.Drawing.Size(100, 25);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 75;
            txtSenha.Left = 100;
            txtSenha.Size = new System.Drawing.Size(200, 25);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 105;
            btnSalvar.Left = 50;
            btnSalvar.Size = new System.Drawing.Size(100, 25);
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.MouseLeave += (sender, e) => {
                btnSalvar.BackColor = Color.Transparent;
            };
            btnSalvar.Click += (sender, e) => {
                Controllers.UserController.store(new Models.User(txtNome.Text, txtLogin.Text, txtSenha.Text));
                List();
            };

            Button btnVoltar = new Button();
            btnVoltar.Text = "Cancelar";
            btnVoltar.Top = 105;
            btnVoltar.Left = 152;
            btnVoltar.Size = new System.Drawing.Size(100, 25);
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
            btnVoltar.MouseLeave += (sender, e) => {
                btnVoltar.BackColor = Color.Transparent;
            };
            btnVoltar.Click += (sender, e) => {
                adicionar.Close();
            };

            adicionar.Controls.Add(lblId);
            adicionar.Controls.Add(txtId);
            adicionar.Controls.Add(lblNome);
            adicionar.Controls.Add(txtNome);
            adicionar.Controls.Add(lblLogin);
            adicionar.Controls.Add(txtLogin);
            adicionar.Controls.Add(lblSenha);
            adicionar.Controls.Add(txtSenha);
            adicionar.Controls.Add(btnSalvar);
            adicionar.Controls.Add(btnVoltar);
            adicionar.ShowDialog();
        }

        public static void Remover(int id) {
            Form remover = new Form();
            remover.Text = "Remover";
            remover.Size = new System.Drawing.Size(418, 366);
            remover.StartPosition = FormStartPosition.CenterScreen;
            remover.FormBorderStyle = FormBorderStyle.FixedSingle;
            remover.MaximizeBox = false;
            remover.MinimizeBox = false;

            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Top = 25;
            lblNome.Left = 0;
            lblNome.Size = new System.Drawing.Size(100, 25);

            TextBox txtNome = new TextBox();
            txtNome.Top = 25;
            txtNome.Left = 100;
            txtNome.Size = new System.Drawing.Size(100, 25);
            txtNome.Text = Controllers.UserController.show(id).Name;
            txtNome.Enabled = false;

            Button btnRemover = new Button();
            btnRemover.Text = "Remover";
            btnRemover.Top = 75;
            btnRemover.Left = 0;
            btnRemover.Size = new System.Drawing.Size(100, 25);
            btnRemover.Click += (sender, e) => {
                Controllers.UserController.Delete(id);
                remover.Hide();
                remover.Close();
                remover.Dispose();
                List();   
            };

            Button btnVoltar = new Button();
            btnVoltar.Text = "Cancelar";
            btnVoltar.Top = 75;
            btnVoltar.Left = 100;
            btnVoltar.Size = new System.Drawing.Size(100, 25);
            btnVoltar.Click += (sender, e) => {
                if(isOpen){
                    remover.Close();
                    user.Close();
                    user.Dispose();
                }    
                List();
            };
            remover.Controls.Add(lblNome);
            remover.Controls.Add(txtNome);
            remover.Controls.Add(btnRemover);
            remover.Controls.Add(btnVoltar);
            remover.ShowDialog();
        }
    }
}

