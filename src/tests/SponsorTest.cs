using Models;

namespace Test
{
    public class SponsorTest
    {
        public static void store()
        {
            try
            {
                Sponsor sponsors = new Sponsor("Test");
                Sponsor.store(sponsors);
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
                form.Text = "Sponsors";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");

                List<Sponsor> sponsors = Sponsor.index();

                foreach (Sponsor sponsor in sponsors)
                {
                    ListViewItem item = new ListViewItem(sponsor.Id.ToString());
                    item.SubItems.Add(sponsor.Name);
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
                form.Text = "Sponsors";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");

                List<Sponsor> sponsors = Sponsor.show(id);

                foreach (Sponsor s in sponsors)
                {
                    ListViewItem item = new ListViewItem(s.Id.ToString());
                    item.SubItems.Add(s.Name);
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

        public static void update(int id, Sponsor sponsor)
        {
            try
            {
                Sponsor.update(id, sponsor);
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
                Sponsor.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

    }
}