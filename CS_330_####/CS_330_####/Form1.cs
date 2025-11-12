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

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.AddRange(new TextBox[] { literBox, pintBox, quartBox, gallonBox });
            for (int i = 0; i < textBoxes.Count; i++)
            {
                TextBox textBox = textBoxes[i];
                if (!textBox.Focused)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        Console.WriteLine("gdrghdh");
                        textBox.Text.Remove(textBox.TextLength-1);
                    }
                    if (textBox.TextLength == 0)
                    {
                        textBox.Text = e.KeyChar.ToString();
                    }
                    else
                    {
                        Console.WriteLine(e.KeyChar);
                        textBox.Text += e.KeyChar.ToString();
                    }
                }
            }
        }
    }
}
