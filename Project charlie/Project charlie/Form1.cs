using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form2 F2 = new Form2();
            if (F2.ShowDialog()==DialogResult.OK)
            {
                if (F2.radioButton1.Checked == true)
                    button1.Text = F2.radioButton1.Text;
                else if (F2.radioButton2.Checked == true)
                    button1.Text = F2.radioButton2.Text;
                else if (F2.radioButton3.Checked == true)
                    button1.Text = F2.radioButton3.Text;
                else if (F2.radioButton4.Checked == true)
                    button1.Text = F2.radioButton4.Text;
            }
            else
            {
                button1.Text = ("Nature of Meeting");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int num = 0; //using for number validation
            if (textBox1.Text == "") //Empty Validation
            {
                MessageBox.Show("Firstname can't be empty");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();// it will bring cursor back to the textbox 1
            }
            else if (textBox2.Text == "")
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Lastname can't be empty");
                textBox2.BackColor = Color.Red;
            }
            else if (int.TryParse(textBox3.Text, out num) == false) //number validation
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Enter Digits only:");
                textBox3.BackColor = Color.Red;
            }
            else if (textBox4.Text == "")
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Email can't be empty");
                textBox4.BackColor = Color.Red;
            }
            else if (textBox4.Text.Contains("@") == false)
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Please enter a valid email");
                textBox4.BackColor = Color.Red;
            }
            else if (numericUpDown1.Value == 0) //Numeric UpDown validation
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time:");
                numericUpDown1.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex == -1) //Combo Box validation
            {
                numericUpDown1.BackColor = Color.White;
                MessageBox.Show("Please select any item");
                comboBox1.BackColor = Color.Red;
            }
            else if (button1.Text == ("Nature of Meeting")) //buttom validation
            {
                comboBox1.BackColor = Color.White;
                MessageBox.Show("Please select the nature of the meeting");
            }
            else
            {
                listBox1.Items.Add("Meeting of: " + textBox1.Text + " " + textBox2.Text);
                if (numericUpDown2.Value < 10)
                {
                    listBox1.Items.Add("Meeting Time: " + numericUpDown1.Value + ":0" + numericUpDown2.Value);
                }
                else
                {
                    listBox1.Items.Add("Meeting Time: " + numericUpDown1.Value + ":" + numericUpDown2.Value);
                }
                listBox1.Items.Add("Meeting With: " + comboBox1.Text);
                listBox1.Items.Add("Meeting Aim: " + button1.Text);
                listBox1.Items.Add("---------------------------------------------------");

                textBox1.Text = ("");
                textBox1.BackColor = Color.White;
                textBox2.Text = ("");
                textBox2.BackColor = Color.White;
                textBox3.Text = ("");
                textBox3.BackColor = Color.White;
                textBox4.Text = ("");
                textBox4.BackColor = Color.White;
                numericUpDown1.Value = (0);
                numericUpDown1.BackColor = Color.White;
                numericUpDown2.Value = (0);
                comboBox1.Text = ("");
                comboBox1.BackColor = Color.White;
                button1.Text = ("Nature of Meeting");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
