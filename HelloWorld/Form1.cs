namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ClickThis_Click(object sender, EventArgs e)
        {
            lbl_HelloWorld.Text = "Oláaaaaaaaaaaaaaaaaaaa";
        }

    }
}