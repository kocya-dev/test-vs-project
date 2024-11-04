namespace test_vs_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var sample = new Sample();
            try
            {
                _textBoxResult.Text = sample.Add(int.Parse(_textBoxLhs.Text), int.Parse(_textBoxRhs.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void _subButton_Click(object sender, EventArgs e)
        {
            var sample = new Sample();
            try
            {
                _textBoxResult.Text = sample.Sub(int.Parse(_textBoxLhs.Text), int.Parse(_textBoxRhs.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
