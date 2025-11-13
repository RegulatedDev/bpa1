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
            DialogResult box = MessageBox.Show("Are you sure you wish to exit the Unit Conversion?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

            if (sender == literBox)
            {
                bool worked = double.TryParse(literBox.Text, out double liters);
                pintBox.Text = (liters * 2.113).ToString();
                quartBox.Text = (liters * 1.057).ToString();
                gallonBox.Text = (liters * 3.785).ToString();
            }
            else if (sender == pintBox)
            {
                bool worked = double.TryParse(literBox.Text, out double pints);
                literBox.Text = (pints / 2.113).ToString();
                quartBox.Text=(pints/2).ToString();
                gallonBox.Text = (pints / 8).ToString();
            }
            else if(sender == quartBox)
            {
                bool worked = double.TryParse(literBox.Text, out double quarts);
                literBox.Text = (quarts / 1.057).ToString();
                pintBox.Text=(quarts*2).ToString();
                gallonBox.Text = (quarts / 4).ToString();
            }
            else if (sender == gallonBox)
            {
                bool worked = double.TryParse(literBox.Text, out double gallons);
                literBox.Text = (gallons * 3.785).ToString();
                pintBox.Text =(gallons)
            }
            /*List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.AddRange(new TextBox[] { literBox, pintBox, quartBox, gallonBox });
            for (int i = 0; i < textBoxes.Count; i++)
            {
                TextBox textBox = textBoxes[i];
                if (!textBox.Focused)
                {
                    Console.WriteLine(e.KeyChar +" before");
                    if (char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        if (sender == literBox)
                        {

                        }
                        if (textBox.TextLength == 0)
                        {
                            textBox.Text = e.KeyChar.ToString();
                        }
                        else
                        {
                            Console.WriteLine(e.KeyChar + " after");
                            textBox.Text += e.KeyChar.ToString();

                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    sender = textBox;
                }
            }*/
        }
    }
}
