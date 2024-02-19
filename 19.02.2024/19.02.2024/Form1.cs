namespace _19._02._2024
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string t = " ";
            t = textBox1.Text;
            richTextBox1.AppendText(t + "\n");
            t = comboBox1.Text;
            richTextBox1.AppendText(t + "\n");
            if (radioButton1.Checked) t += "Male \n";
            if (radioButton2.Checked) t += "Female \n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                t += checkedListBox1.CheckedItems[i].ToString() + "\n";
            richTextBox1.AppendText(Text);
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}