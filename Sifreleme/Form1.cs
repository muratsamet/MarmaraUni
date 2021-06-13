using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Şifreleme işlemini yapan fonksiyonlara ulaşmak için geliştirilen HashAlgrotithm classına ulaşacak nesneyi oluşturur.
        HashAlgrotithm ha = new HashAlgrotithm();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                if (textBox1.Text != null || textBox1.Text != "")
                {
                    //HashAlgrotithm ha = new HashAlgrotithm();
                    textBox2.Text = ha.Sha1Enc(textBox1.Text);
                    LWAdd(textBox1.Text, textBox2.Text, "SHA1");
                    if (checkBox1.Checked)
                    {
                        textBox4.Text = textBox1.Text;
                        textBox5.Text = textBox2.Text;
                        radioButton5.Checked = true;
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox10.Text = "";
                        textBox9.Text = "";
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        radioButton11.Checked = false;
                        radioButton12.Checked = false;
                    }
                }
            }

            if (radioButton2.Checked)
            {
                if (textBox1.Text != null || textBox1.Text != "")
                {
                    //HashAlgrotithm ha = new HashAlgrotithm();
                    textBox2.Text = ha.Sha256Enc(textBox1.Text);
                    LWAdd(textBox1.Text, textBox2.Text, "SHA256");
                    if (checkBox1.Checked)
                    {
                        textBox4.Text = textBox1.Text;
                        textBox5.Text = textBox2.Text;
                        radioButton6.Checked = true;
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox10.Text = "";
                        textBox9.Text = "";
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        radioButton11.Checked = false;
                        radioButton12.Checked = false;
                    }
                }
            }

            if (radioButton3.Checked)
            {
                if (textBox1.Text != null || textBox1.Text != "")
                {
                    //HashAlgrotithm ha = new HashAlgrotithm();
                    textBox2.Text = ha.Sha512Enc(textBox1.Text);
                    LWAdd(textBox1.Text, textBox2.Text, "SHA512");
                    if (checkBox1.Checked)
                    {
                        textBox4.Text = textBox1.Text;
                        textBox5.Text = textBox2.Text;
                        radioButton7.Checked = true;
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox10.Text = "";
                        textBox9.Text = "";
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        radioButton11.Checked = false;
                        radioButton12.Checked = false;
                    }
                }
            }

            if (radioButton4.Checked)
            {
                if (textBox1.Text != null || textBox1.Text != "")
                {
                    //HashAlgrotithm ha = new HashAlgrotithm();
                    LWAdd(textBox1.Text, textBox2.Text, "MD5");
                    if (checkBox1.Checked)
                    {
                        textBox4.Text = textBox1.Text;
                        textBox5.Text = textBox2.Text;
                        radioButton8.Checked = true;
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox10.Text = "";
                        textBox9.Text = "";
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        radioButton11.Checked = false;
                        radioButton12.Checked = false;
                    }
                }
            }
        }
        //Şifreleme işlemi sonrasında oluşan sonuçları listviewa ekler.
        public void LWAdd(string data, string hashData, string algorithm)
        {
            string[] information = { data, hashData, algorithm };
            listView1.Items.Add(new ListViewItem(information));
            //textBox1.Clear();
            //textBox2.Clear();
        }
        //Tüm textboxları temizler.
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        //Hashlanmiş verileri birbirleri ile karşılaştırır ve login durumunu simüle eder.
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == textBox9.Text && textBox5.Text == textBox6.Text)
            {
                listBox1.Items.Add(DateTime.Now.ToString() + " anında başarılı login || Karşılaştırılan hash değerlerinin aynı olduğu tespit edildi.");
            }
            else
            {
                listBox1.Items.Add(DateTime.Now.ToString() + " anında başarısız login || Karşılaştırılan hash değerlerinin farklı olduğu tespit edildi.");
            }
        }

        //Sha1 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox9.Text = ha.Sha1Enc(textBox3.Text);
                textBox5.Text = ha.Sha1Enc(textBox4.Text);
            }
        }

        //Sha256 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox9.Text = ha.Sha256Enc(textBox3.Text);
                textBox5.Text = ha.Sha256Enc(textBox4.Text);
            }
        }
        
        //Sha512 algritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox9.Text = ha.Sha512Enc(textBox3.Text);
                textBox5.Text = ha.Sha512Enc(textBox4.Text);
            }
        }

        //MD5 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox9.Text = ha.MD5Enc(textBox3.Text);
                textBox5.Text = ha.MD5Enc(textBox4.Text);
            }
        }

        //Sha1 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox10.Text = ha.Sha1Enc(textBox8.Text);
                textBox6.Text = ha.Sha1Enc(textBox7.Text);
            }
        }

        //Sha256 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox10.Text = ha.Sha256Enc(textBox8.Text);
                textBox6.Text = ha.Sha256Enc(textBox7.Text);
            }
        }

        //Sha512 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox10.Text = ha.Sha512Enc(textBox8.Text);
                textBox6.Text = ha.Sha512Enc(textBox7.Text);
            }
        }

        //MD5 algoritmasına göre şifreleme yapan metodu çağırır.
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
            {
                textBox10.Text = ha.MD5Enc(textBox8.Text);
                textBox6.Text = ha.MD5Enc(textBox7.Text);
            }
        }

        //TabControl tablarındaki tüm verileri siler. Kullanıcı adı alanına marmarauni yazar.
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            checkBox1.Checked = false;
            textBox3.Text = "marmarauni";
        }

        //Hakkında butonuna basıldığında ekrana kısa bilgilendirme mesajı basar.
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Marmara Üniversitesi Kriptoloji ve Güvenlik Protokolleri Dersi Final Ödevi İçin Hazırlanmıştır. \nHazırlayanlar : \nMurat Samet KÜÇÜk\nOğuzhan KASAP\nMuhammed YILDIZ");
        }

        //Uygulamayı kapatır.
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Ekrandaki verileri temizler.
        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            checkBox1.Checked = false;
        }

    }
}
