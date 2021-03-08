using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool buttonwasclicked = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            comboBox1.Text = "";
            button1.Text = "Select";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonwasclicked = true;
            {
                this.Hide();
                var newform = new Form2();
                if (newform.ShowDialog() == DialogResult.OK)

                    if (newform.radioButton1.Checked == true)
                        button1.Text = newform.radioButton1.Text;
                    else if (newform.radioButton2.Checked == true)
                        button1.Text = newform.radioButton2.Text;
                    else if (newform.radioButton3.Checked == true)
                        button1.Text = newform.radioButton3.Text;
                    else if (newform.radioButton4.Checked == true)
                        button1.Text = newform.radioButton4.Text;

               
            }

               int num = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name is required");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Surname must be filled");
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Mobile number is required");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (int.TryParse(textBox3.Text, out num) == false)
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Mobile can't contain any letters/symbols");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Email Address is required");
                textBox4.BackColor = Color.Red;
                textBox4.Focus();
            }
            else if (numericUpDown1.Value == 0)
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time");
                numericUpDown1.BackColor = Color.Red;
                numericUpDown2.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a person");
            }
            else if (buttonwasclicked == false)
            {
                MessageBox.Show("Please select a meeting aim");
            }
            else
            {
                this.Hide();
                var newform = new Form2();
                if (newform.ShowDialog() == DialogResult.OK)

                    if (newform.radioButton1.Checked == true)
                        button1.Text = newform.radioButton1.Text;
                    else if (newform.radioButton2.Checked == true)
                        button1.Text = newform.radioButton2.Text;
                    else if (newform.radioButton3.Checked == true)
                        button1.Text = newform.radioButton3.Text;
                    else if (newform.radioButton4.Checked == true)
                        button1.Text = newform.radioButton4.Text;

                this.Show();
            }

        }
        private string buttonValue;
        private string hourValue;
        private string minuteValue;
        private string theDate;
        private int num_x;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            theDate = dateTimePicker1.Value.ToShortDateString();
            hourValue = Convert.ToString(numericUpDown1.Value);


            if (button1.Text == "Select")
                buttonValue = "";


            else
                buttonValue = button1.Text;



            if (numericUpDown2.Value <= 9)
                minuteValue = 0 + Convert.ToString(numericUpDown2.Value);


            else
                minuteValue = Convert.ToString(numericUpDown2.Value);

            if (textBox1.Text == "")
                listBox1.Items.Add("You need to enter a first name");


            else if (textBox2.Text == "")
                listBox1.Items.Add("You need to enter a surname");


            else if (textBox3.Text == "")
                listBox1.Items.Add("You need to enter a phone number");


            else if (int.TryParse(textBox3.Text, out num_x) == false)
            {
                listBox1.Items.Add("You need to enter a valid phone number");
                listBox1.Items.Add("(one with all digits)");
            }


            else if (textBox4.Text == "")
                listBox1.Items.Add("You need to enter an email");
            
           

            else if (!textBox4.Text.Contains("@"))
            {
                listBox1.Items.Add("You need to enter a valid email");
                listBox1.Items.Add("(@ symbol required)");
            }


            else if (comboBox1.Text == "")
                listBox1.Items.Add("You need to select a person that you want to have a meeting with");


            else if (button1.Text == "Select")
                listBox1.Items.Add("You need to select a meeting aim");


            else
                listBox1.Items.Add("Meeting For : " + textBox1.Text + "" + textBox2.Text + "" + textBox3.Text + "" + textBox4.Text);
            listBox1.Items.Add("Meeting At : " + numericUpDown1.Value + ":" + numericUpDown2.Value + " " + comboBox1.SelectedItem);
            listBox1.Items.Add("Meeting with : " + comboBox1.SelectedItem);
            listBox1.Items.Add("Meeting Aim : " + button1.Text);
            listBox1.Items.Add("---------------------------------------");
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            dateTimePicker1.ResetText();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            comboBox1.ResetText();
            button1.Text = ("Meeting Aim");


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}



