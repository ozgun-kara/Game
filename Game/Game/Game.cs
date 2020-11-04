using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Game
{
    public partial class Game : Form
    {

        int targetValue;

        public Game()
        {
            Random rand = new Random(); 
            targetValue = rand.Next(1000, 10000);   

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void TahminYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Length < 4)
                return;

            String targetValue1 = targetValue.ToString();
            string inputValue = textBox1.Text;
            List<String> outputList = new List<String>();

            // Target 
            char[] targetArray = new char[targetValue1.Length];

            for (int i = 0; i < targetValue1.Length; i++)
            {
                targetArray[i] = targetValue1[i];
            }


            // Input
            char[] inputArray = new char[inputValue.Length];

            for (int i = 0; i < inputValue.Length; i++)
            {
                inputArray[i] = inputValue[i];
            }

            // First Character Control
            if (inputArray[0] == targetArray[0])
                outputList.Add("+");
            else if (inputArray[0] == targetArray[1])
                outputList.Add("-");
            else if (inputArray[0] == targetArray[2])
                outputList.Add("-");
            else if (inputArray[0] == targetArray[3])
                outputList.Add("-");
            else
                outputList.Add("X");

            // Second Character Control
            if (inputArray[1] == targetArray[1])
                outputList.Add("+");
            else if (inputArray[1] == targetArray[0])
                outputList.Add("-");
            else if (inputArray[1] == targetArray[2])
                outputList.Add("-");
            else if (inputArray[1] == targetArray[3])
                outputList.Add("-");
            else
                outputList.Add("X");

            // Third Character Control
            if (inputArray[2] == targetArray[2])
                outputList.Add("+");
            else if (inputArray[2] == targetArray[0])
                outputList.Add("-");
            else if (inputArray[2] == targetArray[1])
                outputList.Add("-");
            else if (inputArray[2] == targetArray[3])
                outputList.Add("-");
            else
                outputList.Add("X");

            // Fourth Character Control
            if (inputArray[3] == targetArray[3])
                outputList.Add("+");
            else if (inputArray[3] == targetArray[0])
                outputList.Add("-");
            else if (inputArray[3] == targetArray[1])
                outputList.Add("-");
            else if (inputArray[3] == targetArray[2])
                outputList.Add("-");
            else
                outputList.Add("X");


            string result = string.Join(" ", outputList);

            ListViewItem item = new ListViewItem(targetValue1);
            item.SubItems.Add(inputValue);
            item.SubItems.Add(result);
            listView1.Items.Add(item);
            outputList.Clear();
        }

        private void YeniOyun_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
