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
            //WorldPart part1 = new WorldPart { Name = "Европа" };
            //WorldPart part2 = new WorldPart { Name = "Азия" };
            //WorldPart part3 = new WorldPart { Name = "Африка" };
            //WorldPart part4 = new WorldPart { Name = "Европа" };
            //db.WorldParts.Add(part1);
            //db.WorldParts.Add(part2);
            //db.WorldParts.Add(part3);
            //db.WorldParts.Add(part4);
            //}
        }
    }
}