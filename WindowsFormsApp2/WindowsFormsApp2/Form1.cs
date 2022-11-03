using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                MessageBox.Show($"Вы выбрали вариант - A, ето неверный ответ");
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                DialogResult result = MessageBox.Show(
        "Вы выбрали вариант - D, ето верный ответ\nХотите продолжить тест?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    label1.Visible=false;
                    label4.Visible = true;
                    radioButton1.Visible = false;
                    radioButton4.Visible = false;
                    radioButton6.Visible = true;
                    radioButton5.Visible = true;
                    label6.ForeColor= Color.Green;
                }
            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                MessageBox.Show($"Вы выбрали вариант - B, ето неверный ответ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
                MessageBox.Show($"Вы выбрали вариант - C, ето неверный ответ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                DialogResult result = MessageBox.Show(
        "Вы выбрали вариант - A, ето верный ответ\nХотите продолжить тест?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    label4.Visible = false;
                    label2.Visible = true;
                    radioButton1.Visible = true;
                    radioButton5.Visible = false;
                    radioButton7.Visible = true;
                    label7.ForeColor = Color.Green;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
                MessageBox.Show($"Вы выбрали вариант - D, ето неверный ответ");
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                DialogResult result = MessageBox.Show(
        "Вы выбрали вариант - C, ето верный ответ\nХотите продолжить тест?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    label3.Visible = true;
                    label2.Visible = false;
                    radioButton1.Visible = true;
                    radioButton3.Visible = true;
                    radioButton7.Visible =false;
                    radioButton5.Visible = false;
                    radioButton8.Visible = true;
                    radioButton2.Visible = false;
                    label8.ForeColor = Color.Green;
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                DialogResult result = MessageBox.Show(
        "Вы выбрали вариант - C, ето верный ответ\nХотите продолжить тест?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
);
                if (result == DialogResult.Yes)
                {
                    label3.Visible = false;
                    label2.Visible = false;
                    label5.Visible = true;
                    radioButton1.Visible = false;
                    radioButton3.Visible = false;
                    radioButton7.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton8.Visible = false;
                    radioButton2.Visible = false;
                    label9.ForeColor = Color.Green;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

