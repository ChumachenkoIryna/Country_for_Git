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

            //using(var db = new WorldPartContext())
            //{
            //WorldPart part1 = new WorldPart { Name = "������" };
            //WorldPart part2 = new WorldPart { Name = "����" };
            //WorldPart part3 = new WorldPart { Name = "������" };
            //WorldPart part4 = new WorldPart { Name = "������" };
            //db.WorldParts.Add(part1);
            //db.WorldParts.Add(part2);
            //db.WorldParts.Add(part3);
            //db.WorldParts.Add(part4);
            //}
        }

        private void AddGroupClick(object sender, EventArgs e)
        {
            try
            {
                string groupname = textBoxWorldPart.Text.Trim();
                if (groupname == "")
                {
                    MessageBox.Show("�� ������ �������� ����� ����!");
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

                    MessageBox.Show("����� ���� ���������!");

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

                    MessageBox.Show("����� ���� �������!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}