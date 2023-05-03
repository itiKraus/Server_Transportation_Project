using Repository.Models;

namespace Application_Transportation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Services.CarServices().GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Services.CarServices().AddNew(new CarsTable() { CompanyCar = textBox1.Text, Status =textBox2.Text });
        }
    }
}