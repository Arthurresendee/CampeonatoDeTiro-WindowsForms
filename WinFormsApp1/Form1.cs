namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Criando um TableLayoutPanel
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Dock = DockStyle.Fill;

            // Adicionando células ao TableLayoutPanel
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 2;

            // Adicionando controles aos células
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();
            Button button4 = new Button();

            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);

            // Adicionando o TableLayoutPanel ao formulário
            this.Controls.Add(tableLayoutPanel1);

        }
    }
}