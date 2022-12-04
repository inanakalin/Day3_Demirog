namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            this.Controls.Add(button);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}