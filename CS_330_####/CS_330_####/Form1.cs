//contestant number here

namespace CS_330_____
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult box = MessageBox.Show("Are you sure you wish to exit the Unit Conve", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (box == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1: Close();
        }
    }
}
