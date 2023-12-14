using Country_for_Git;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Country_for_Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var db = new WorldPartContext())
                {
                    var query = from b in db.WorldParts
                                select b;
                    comboBoxWorldPart.DataSource = query.ToList();
                    comboBoxWorldPart.DisplayMember = "Name";

                    var query2 = from b in db.Countries
                                 select b;
                    comboBoxCountry.DataSource = query2.ToList();
                    comboBoxCountry.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddGroupClick(object sender, EventArgs e)
        {
            try
            {
                string groupname = textBoxWorldPart.Text.Trim();
                if (groupname == "")
                {
                    MessageBox.Show("Не задано название части мира!");
                    return;
                }
                using (var db = new WorldPartContext())
                {
                    var WorldPart = new WorldPart { Name = groupname };
                    db.WorldParts.Add(WorldPart);
                    db.SaveChanges();
                    textBoxWorldPart.Text = "";

                    var query = from b in db.WorldParts
                                select b;
                    comboBoxWorldPart.DataSource = query.ToList();
                    comboBoxWorldPart.DisplayMember = "Name";

                    MessageBox.Show("Часть мира добавлена!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveGroupClick(object sender, EventArgs e)
        {
            if (comboBoxWorldPart.Items.Count == 0)
                return;
            try
            {
                using (var db = new WorldPartContext())
                {
                    List<WorldPart> list = comboBoxWorldPart.DataSource as List<WorldPart>;
                    string WorldPart = list[comboBoxWorldPart.SelectedIndex].Name;
                    var query = from b in db.WorldParts
                                where b.Name == WorldPart
                                select b;
                    db.WorldParts.RemoveRange(query);
                    db.SaveChanges();

                    query = from b in db.WorldParts
                            select b;
                    comboBoxWorldPart.DataSource = query.ToList();
                    comboBoxWorldPart.DisplayMember = "Name";

                    var query2 = from b in db.Countries
                                 select b;
                    comboBoxCountry.DataSource = query2.ToList();
                    comboBoxCountry.DisplayMember = "Name";

                    if (comboBoxCountry.Items.Count == 0)
                    {
                        textBoxCapital.Text = "";
                        textBoxName.Text = "";
                        textBoxArea.Text = "";
                        textBoxPopulation.Text = "";
                        textBoxGr.Text = "";
                    }

                    MessageBox.Show("Часть мира удалена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditGroupClick(object sender, EventArgs e)
        {
            try
            {
                string groupname = textBoxWorldPart.Text.Trim();
                if (groupname == "")
                {
                    MessageBox.Show("Не задано название части мира!");
                    return;
                }
                using (var db = new WorldPartContext())
                {
                    List<WorldPart> list = comboBoxWorldPart.DataSource as List<WorldPart>;
                    string WorldPart = list[comboBoxWorldPart.SelectedIndex].Name;
                    var query = (from b in db.WorldParts
                                 where b.Name == WorldPart
                                 select b).Single();
                    query.Name = groupname;
                    db.SaveChanges();
                    textBoxWorldPart.Text = "";

                    var query2 = from b in db.WorldParts
                                 select b;
                    comboBoxWorldPart.DataSource = query2.ToList();
                    comboBoxWorldPart.DisplayMember = "Name";

                    MessageBox.Show("Часть мира переименована!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCountryClick(object sender, EventArgs e)
        {
            try
            {
                string capital = textBoxCapital.Text.Trim();
                string Name = textBoxName.Text.Trim();
                if (capital == "" || Name == "")
                {
                    MessageBox.Show("Не указано имя страны!");
                    return;
                }
                if (comboBoxWorldPart.Items.Count == 0)
                {
                    MessageBox.Show("Не создано ни одной части мира!");
                    return;
                }
                double? area = null;
                if (textBoxArea.Text != "")
                    area = Convert.ToDouble(textBoxArea.Text);

                int? population = null;
                if (textBoxPopulation.Text != "")
                    population = Convert.ToInt32(textBoxPopulation.Text);

                using (var db = new WorldPartContext())
                {
                    List<WorldPart> list = comboBoxWorldPart.DataSource as List<WorldPart>;
                    string WorldPart = list[comboBoxWorldPart.SelectedIndex].Name;
                    var query = (from b in db.WorldParts
                                 where b.Name == WorldPart
                                 select b).Single();

                    var Country = new Country
                    {
                        Capital = capital,
                        Name = Name,
                        Population = population,
                        Area = area,
                        WorldPart = query
                    };
                    db.Countries.Add(Country);
                    db.SaveChanges();

                    var query2 = from b in db.Countries
                                 select b;
                    comboBoxCountry.DataSource = query2.ToList();
                    comboBoxCountry.DisplayMember = "Name";

                    MessageBox.Show("Страна добавлена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveCountryClick(object sender, EventArgs e)
        {
            if (comboBoxCountry.Items.Count == 0)
                return;
            try
            {
                using (var db = new WorldPartContext())
                {
                    List<Country> list = comboBoxCountry.DataSource as List<Country>;
                    string Country = list[comboBoxCountry.SelectedIndex].Name;
                    var query = from b in db.Countries
                                where b.Name == Country
                                select b;
                    db.Countries.RemoveRange(query);
                    db.SaveChanges();

                    var query2 = from b in db.Countries
                                 select b;
                    comboBoxCountry.DataSource = query2.ToList();
                    comboBoxCountry.DisplayMember = "Name";

                    if (comboBoxCountry.Items.Count == 0)
                    {
                        textBoxCapital.Text = "";
                        textBoxName.Text = "";
                        textBoxArea.Text = "";
                        textBoxPopulation.Text = "";
                        textBoxGr.Text = "";
                    }

                    MessageBox.Show("Страна удалена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCountryClick(object sender, EventArgs e)
        {
            try
            {
                string capital = textBoxCapital.Text.Trim();
                string Name = textBoxName.Text.Trim();
                if (capital == "" || Name == "")
                {
                    MessageBox.Show("Не указано имя страны или столицы!");
                    return;
                }

                double? area = null;
                if (textBoxArea.Text != "")
                    area = Convert.ToDouble(textBoxArea.Text);

                int? population = null;
                if (textBoxPopulation.Text != "")
                    population = Convert.ToInt32(textBoxPopulation.Text);

                using (var db = new WorldPartContext())
                {
                    List<WorldPart> list = comboBoxWorldPart.DataSource as List<WorldPart>;
                    string WorldPart = list[comboBoxWorldPart.SelectedIndex].Name;
                    var query = (from b in db.WorldParts
                                 where b.Name == WorldPart
                                 select b).Single();
                    if (query == null)
                        return;

                    List<Country> Countrylist = comboBoxCountry.DataSource as List<Country>;
                    string Country = Countrylist[comboBoxCountry.SelectedIndex].Name;
                    var query2 = (from b in db.Countries
                                  where b.Name == Country
                                  select b).Single();

                    query2.WorldPart = query;
                    query2.Capital = capital;
                    query2.Name = Name;
                    query2.Population = population;
                    query2.Area = area;
                    db.SaveChanges();

                    var query3 = from b in db.Countries
                                 select b;
                    comboBoxCountry.DataSource = query3.ToList();
                    comboBoxCountry.DisplayMember = "Name";

                    MessageBox.Show("Данные о стране изменены!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.Items.Count == 0)
                return;
            try
            {
                using (var db = new WorldPartContext())
                {
                    List<Country> Countrylist = comboBoxCountry.DataSource as List<Country>;
                    if (Countrylist == null)
                        return;
                    string Country = Countrylist[comboBoxCountry.SelectedIndex].Name;
                    var query = (from b in db.Countries
                                 where b.Name == Country
                                 select b).Single();

                    textBoxCapital.Text = query.Capital;
                    textBoxName.Text = query.Name;
                    textBoxArea.Text = query.Area.ToString();
                    textBoxPopulation.Text = query.Population.ToString();
                    textBoxGr.Text = query.WorldPart.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxWorldPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorldPart.Items.Count == 0)
                return;
            try
            {
                using (var db = new WorldPartContext())
                {
                    List<WorldPart> list = comboBoxWorldPart.DataSource as List<WorldPart>;
                    string WorldPart = list[comboBoxWorldPart.SelectedIndex].Name;
                    var query = (from b in db.WorldParts
                                 where b.Name == WorldPart
                                 select b).Single();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {

                var query = db.Countries.Join(
     db.WorldParts,
     (Country country) => country.WorldPart.Id,
     (WorldPart part) => part.Id,
     (country, part) => new
     {
         Name = country.Name,
         Capital = country.Capital,
         Population = country.Population,
         Area = country.Area,
         WorldPart = part.Name
     });


                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button11_Click(object sender, EventArgs e)

        {
            if (numberText.Text.Length == 0)
            {
                MessageBox.Show("Задайте числo");
                return;
            }
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.Area > Double.Parse(numberText.Text)).Select(n => new { n.Name });
                dataGridView1.DataSource = query.ToList();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {
                var names = db.Countries.Select(n => new { n.Name });
                dataGridView1.DataSource = names.ToList();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {
                var capital = db.Countries.Select(n => new { n.Capital });
                dataGridView1.DataSource = capital.ToList();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.WorldPart.Equals("Европа")).Select(n => new { n.Name });
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.Name.StartsWith("а")).Select(n => new { n.Name });
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.Name.Contains("а") || l.Name.Contains("е")).Select(n => new { n.Name });
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (minText.Text.Length == 0 || maxText.Text.Length == 0)
            {
                MessageBox.Show("Задайте диапазон");
                return;
            }
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.Area >= Double.Parse(minText.Text) && l.Area <= Double.Parse(maxText.Text));
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (numberText.Text.Length == 0)
            {
                MessageBox.Show("Задайте числo");
                return;
            }
            using (var db = new WorldPartContext())
            {
                var query = db.Countries.Join(
   db.WorldParts,
   (Country country) => country.WorldPart.Id,
   (WorldPart part) => part.Id,
   (country, part) => new
   {
       Name = country.Name,
       Capital = country.Capital,
       Population = country.Population,
       Area = country.Area,
       WorldPart = part.Name
   }).Where(l => l.Population > Int32.Parse(numberText.Text));
                dataGridView1.DataSource = query.ToList();
            }

        }
    }
}