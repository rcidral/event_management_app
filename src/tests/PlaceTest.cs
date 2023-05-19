using Models;

namespace Test
{
    public class PlaceTest
    {
        public static void store()
        {
            try
            {
                Place place = new Place("Test", "test");
                Place.store(place);
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
                form.Text = "Places";
                
                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");
                listView.Columns.Add("Address");
                
                List<Place> places = Place.index();

                foreach (Place place in places)
                {
                    ListViewItem item = new ListViewItem(place.Id.ToString());
                    item.SubItems.Add(place.Name);
                    item.SubItems.Add(place.Address);
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
                form.Text = "Places";
                
                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");
                listView.Columns.Add("Address");
                
                List<Place> places = Place.show(id);

                foreach (Place place in places)
                {
                    ListViewItem item = new ListViewItem(place.Id.ToString());
                    item.SubItems.Add(place.Name);
                    item.SubItems.Add(place.Address);
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

        public static void update(int id, Place place)
        {
            try
            {
                Place.update(id, place);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}