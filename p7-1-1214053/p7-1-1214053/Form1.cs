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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace p7_1_1214053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900, 230);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox5.ResetText();
            comboBox1.ResetText();
            rblaki.Checked = false;
            rbperemuan.Checked = false;
            this.Size = new Size(900, 230);
            textBox6.ResetText();

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;


        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epCorrect.SetError(textBox2, "");
                epWarning.SetError(textBox2, "Textbox ID tidak boleh kosong");
                epWrong.SetError(textBox2, "");
            }
            else
            {
                if ((textBox2.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBox2, "Betul");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                }
                else
                {
                    epCorrect.SetError(textBox2, "");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Inputan hanya boleh angka!");


                    MessageBox.Show(
                   "Nim belum ter isi",
                   "informasi data submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Textbox Name tidak boleh kosong");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul!");
                }
                else
                {
                    epWarning.SetError(textBox1, "Inputan hanya boleh huruf!");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                epWarning.SetError(textBox5, "Textbox Email tidak boleh kosong");
                epWrong.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "");
            }
            else
            {
                if (Regex.IsMatch(textBox5.Text, @"^\d{4}/\d{4}$"))
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul");
                }
                else
                {
                    epWarning.SetError(textBox5, "Format email salah!\nContoh: a@b.c");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                epWarning.SetError(comboBox1, "Textbox Name tidak boleh kosong");
                epWrong.SetError(comboBox1, "");
                epCorrect.SetError(comboBox1, "");
            }
            else
            {
                if ((comboBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(comboBox1, "");
                    epWrong.SetError(comboBox1, "");
                    epCorrect.SetError(comboBox1, "Betul!");
                }
                else
                {
                    epWarning.SetError(comboBox1, "Inputan hanya boleh huruf!");
                    epWrong.SetError(comboBox1, "");
                    epCorrect.SetError(comboBox1, "");
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                epCorrect.SetError(textBox6, "");
                epWarning.SetError(textBox6, "Textbox ID tidak boleh kosong");
                epWrong.SetError(textBox6, "");
            }
            else
            {
                if ((textBox6.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBox6, "Betul");
                    epWarning.SetError(textBox6, "");
                    epWrong.SetError(textBox6, "");
                }
                else
                {
                    epCorrect.SetError(textBox6, "");
                    epWarning.SetError(textBox6, "");
                    epWrong.SetError(textBox6, "Inputan hanya boleh angka!");


                    MessageBox.Show(
                   "Nim belum ter isi",
                   "informasi data submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (textBox2.Text != "")
            {

                if (textBox3.Text != "")
                {
                    if (textBox1.Text != "")
                    {

                      

                        MessageBox.Show(
                "\nNama  :" + textBox2.Text +
                "\nProdi :" + textBox3.Text +
                "\nAlamat :" + textBox1.Text,
               "informasi data submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                
                );

                    }
                    else
                    {
                        MessageBox.Show(
                    "kelas bekum tersisi",
                    "informasi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show(
                    "Prodi bekum tersisi",
                   "informasi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show(
                    "Nama nya belum ter isi",
                   "informasi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        private void rbperemuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rblaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              if (textBox2.Text != "")
            {
                this.Size = new Size(900, 600);
                if (textBox5.Text == "")
                {
                    MessageBox.Show(
                           "kelas bekum tersisi",
                           "informasi data submit",
                           MessageBoxButtons.OK, MessageBoxIcon.Information
                           );

                    if (textBox3.Text != "")
                    {
                        this.Size = new Size(900, 600);
                        if (rblaki.Checked || rbperemuan.Checked)
                        {
                            this.Size = new Size(900, 600);

                            MessageBox.Show(

                            
                            
                            "\nNama :" + textBox1.Text,
                            

                   "informasi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                        }
                        else
                        {
                            this.Size = new Size(900, 600);
                            MessageBox.Show(
                        "kelas bekum tersisi",
                        "informasi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        this.Size = new Size(900, 600);
                        MessageBox.Show(
                        "Prodi bekum tersisi",
                       "informasi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    this.Size = new Size(900, 600);
                    MessageBox.Show(

                            "\nNama :" + textBox1.Text,
                       

                       "informasi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }

                

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                epCorrect.SetError(textBox3, "");
                epWarning.SetError(textBox3, "Textbox ID tidak boleh kosong");
                epWrong.SetError(textBox3, "");
            }
            else
            {
                if ((textBox3.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(textBox3, "Betul");
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "");
                }
                else
                {
                    epCorrect.SetError(textBox3, "");
                    epWarning.SetError(textBox3, "");
                    epWrong.SetError(textBox3, "Inputan hanya boleh angka!");


                    MessageBox.Show(
                   "Nim belum ter isi",
                   "informasi data submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = false; 
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string matkul = "";
            if (checkBox1.Checked)
            {
                matkul += checkBox1.Text + " ,";
            }
            if (checkBox2.Checked)
            {
                matkul += checkBox2.Text + " ,";
            }
            if (checkBox3.Checked)
            {
                matkul += checkBox3.Text + " ,";
            }
            if (checkBox4.Checked)
            {
                matkul += checkBox4.Text + " ,";
            }
            if (checkBox5.Checked)
            {
                matkul += checkBox5.Text + " ,";
            }
            if (checkBox6.Checked)
            {
                matkul += checkBox6.Text + " ,";
            }
            if (checkBox7.Checked)
            {
                matkul += checkBox7.Text + " ,";
            }
            if (checkBox8.Checked)
            {
                matkul += checkBox8.Text + " ,";
            }
            if (checkBox9.Checked)
            {
                matkul += checkBox9.Text + " ,";
            }
            if (checkBox10.Checked)
            {
                matkul += checkBox10.Text + " ,";
            }
            if (checkBox11.Checked)
            {
                matkul += checkBox11.Text + " ,";
            }
            if (checkBox12.Checked)
            {
                matkul += checkBox12.Text + " ,";
            }
            if (rblaki.Checked)
            {

                MessageBox.Show
             (
             "\nNama\t :" + textBox1.Text +
            "\nNOKTP\t" + textBox2.Text +
            "\njenis kelamin\t" + rbperemuan.Text +
            "\nlamat\t" + textBox3.Text +
            "\ntahun akademik\t" + textBox5.Text +
            "\nKODEPOS\t" + textBox6.Text +
            "\n=======\t" +
            "\nMEREKROKOK\t" + radioButton5.Text +
            "\nPILIHROKOK\t" + matkul,
             "iyaa",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rbperemuan.Checked)
            {
                if (radioButton3.Checked)
                {
                    MessageBox.Show
              (
               "\nNama\t :" + textBox1.Text +
            "\nNOKTP\t" + textBox2.Text +
            "\njenis kelamin\t" + rbperemuan.Text +
            "\nlamat\t" + textBox3.Text +
            "\ntahun akademik\t" + textBox5.Text +
            "\nKODEPOS\t" + textBox6.Text +
            "\n=======\t" +
            "\nMEREKROKOK\t" + radioButton5.Text +
            "\nPILIHROKOK\t" + matkul,
              "iyaa",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (radioButton4.Checked)
                    {
                    MessageBox.Show
            (
         "\nNama\t :" + textBox1.Text +
            "\nNOKTP\t" + textBox2.Text +
            "\njenis kelamin\t" + rbperemuan.Text +
            "\nlamat\t" + textBox3.Text +
            "\ntahun akademik\t" + textBox5.Text +
            "\nKODEPOS\t" + textBox6.Text +
            "\n=======\t" +
            "\nMEREKROKOK\t" + radioButton5.Text +
            "\nPILIHROKOK\t" + matkul,
            "iyaa",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton5.Checked)
                {
                   
                 MessageBox.Show
             (
             "\nNama\t :" + textBox1.Text +
            "\nNOKTP\t" + textBox2.Text +
            "\njenis kelamin\t" + rbperemuan.Text +
            "\nlamat\t" + textBox3.Text +
            "\ntahun akademik\t" + textBox5.Text +
            "\nKODEPOS\t" + textBox6.Text +
            "\n=======\t" +
            "\nMEREKROKOK\t" + radioButton5.Text +
            "\nPILIHROKOK\t" + matkul,
             "iyaa",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }
