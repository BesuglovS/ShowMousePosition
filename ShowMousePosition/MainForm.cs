namespace ShowMousePosition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var m = MouseOperations.GetCursorPosition();
            xPos.Text = m.X.ToString();
            yPos.Text = m.Y.ToString();

        }
    }
}