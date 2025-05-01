namespace Assigment4._1
{

    public partial class Form1 : Form
    {
        Dictionary<string, Person> dataBook = new Dictionary<string, Person>();
        public Form1()
        {
            InitializeComponent();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataBook.Values;
            dataGridView1.DataSource = bindingSource;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                MobilePhone = textBox3.Text,
                WorPhone = textBox4.Text,
                Address = textBox5.Text,
            };
            dataBook.Add(person.GetFullName(), person);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
