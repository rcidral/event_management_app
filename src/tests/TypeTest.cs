using Models;

namespace Test
{
    public class TypeTest
    {
        public static void store()
        {
            try
            {
                Models.Type type = new Models.Type("Test");
                Models.Type.store(type);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void index()
        {
            try
            {
                Form form = new Form();
                form.Width = 500;
                form.Height = 500;
                form.Text = "Types";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Description");

                List<Models.Type> types = Models.Type.index();

                foreach (Models.Type type in types)
                {
                    ListViewItem item = new ListViewItem(type.Id.ToString());
                    item.SubItems.Add(type.Description);
                    listView.Items.Add(item);
                }

                form.Controls.Add(listView);
                form.ShowDialog();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void show(int id)
        {
            try
            {
                Form form = new Form();
                form.Width = 500;
                form.Height = 500;
                form.Text = "Types";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Description");

                List<Models.Type> types = Models.Type.show(id);

                foreach (Models.Type type in types)
                {
                    ListViewItem item = new ListViewItem(type.Id.ToString());
                    item.SubItems.Add(type.Description);
                    listView.Items.Add(item);
                }

                form.Controls.Add(listView);
                form.ShowDialog();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void update(int id, Models.Type type)
        {
            try
            {
                Models.Type.update(id, type);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(int id)
        {
            try
            {
                Models.Type.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}