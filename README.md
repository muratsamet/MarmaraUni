# MarmaraUni
MarmaraUni
SHA 256 Şifreleme Algoritması İle Uygulama Örneği(Login Simülasyonu)
C# .Net programlama dili kullanarak basit bir şifreleme uygulaması geliştirelim.

Visual Studio üzerinden yeni bir proje oluşturalım. Proje tipi için;

Dil : C#
İşletim Sistemi : Windows
Platform : Desktop

Açılan yeni proje üzerine bazı kontroller ekleyeceğiz. Ekleyeceğimiz kontroller : 
1.2. TabControl -> 2 sekmeli olmalıdır.
TabControlün birinci sekmesine 2 adet Textbox, 4 adet RadioButton, 1 adet chechBox, 2 Button, 2 adet Label, 1 adet ListView ekleyeceğiz. Son durumda TabControlün 1. tabında aşağıdaki gibi bir ekran elde edeceğiz.(İsteğe bağlı olarak GroupBox eklenerek tasarım güzelleştirilebilir.)

1.2. TabControlün 2. tabı için 8 adet TextBox, 8 adet RadioButton, 8 adet Label, 1 adet Button, 1 adet ListBox forma eklenmelidir.

1.3. TabControlün dışında kalan kısma 3 adet Button eklenmelidir.

2. Formun altına aşağıdaki kodlar yazılmalıdır.

Not : Aşağıdaki kodların metotlarının üzerinde yorum satırları ile yaptıkları işlemler belirtilmiştir.
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
 public partial class Form1 : Form
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
 if (textBox1.Text != null || textBox1.Text != "")
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
 if (textBox1.Text != null || textBox1.Text != "")
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
 if (textBox1.Text != null || textBox1.Text != "")
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
 if (textBox1.Text != null || textBox1.Text != "")
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
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox9.Text = ha.Sha1Enc(textBox3.Text);
 textBox5.Text = ha.Sha1Enc(textBox4.Text);
 }
 }
//Sha256 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton6_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox9.Text = ha.Sha256Enc(textBox3.Text);
 textBox5.Text = ha.Sha256Enc(textBox4.Text);
 }
 }
 
 //Sha512 algritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton7_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox9.Text = ha.Sha512Enc(textBox3.Text);
 textBox5.Text = ha.Sha512Enc(textBox4.Text);
 }
 }
//MD5 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton8_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox9.Text = ha.MD5Enc(textBox3.Text);
 textBox5.Text = ha.MD5Enc(textBox4.Text);
 }
 }
//Sha1 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton12_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox10.Text = ha.Sha1Enc(textBox8.Text);
 textBox6.Text = ha.Sha1Enc(textBox7.Text);
 }
 }
//Sha256 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton11_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox10.Text = ha.Sha256Enc(textBox8.Text);
 textBox6.Text = ha.Sha256Enc(textBox7.Text);
 }
 }
//Sha512 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton10_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
 {
 textBox10.Text = ha.Sha512Enc(textBox8.Text);
 textBox6.Text = ha.Sha512Enc(textBox7.Text);
 }
 }
//MD5 algoritmasına göre şifreleme yapan metodu çağırır.
 private void radioButton9_CheckedChanged(object sender, EventArgs e)
 {
 if ((textBox3.Text != null || textBox3.Text != "") && (textBox4.Text != null || textBox4.Text != ""))
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
 MessageBox.Show("Bu uygulama Marmara Üniversitesi Kriptoloji ve Güvenlik Protokolleri Dersi Final Ödevi İçin Hazırlanmıştır. \nHazırlayanlar : \nMurat Samet KÜÇÜk\nOğuzhan KASAP\nMuhammed YILDIZ");
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

Yeni bir class projeye eklenir. Class adı HashAlgrotithm olarak belirlenir.
Eklenen classın altına aşağıdaki kodlar yazılır.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Sifreleme
{
class HashAlgrotithm
{
public string Sha256Enc(string Data)
{
using (SHA256 sha256Hash = SHA256.Create())
{
byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Data));
StringBuilder builder = new StringBuilder();
for (int i = 0; i < bytes.Length; i++)
{
builder.Append(bytes[i].ToString("x2"));
}
return builder.ToString();
}
}
public string Sha1Enc(string stringToHash)
{
using (var sha1 = new SHA1Managed())
{
return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(stringToHash)));
}
}
public string Sha512Enc(string inputString)
{
if (string.IsNullOrWhiteSpace(inputString)) return string.Empty;
using (SHA512 shaM = new SHA512Managed())
{
return Convert.ToBase64String(shaM.ComputeHash(Encoding.UTF8.GetBytes(inputString)));
}
}
public string MD5Enc(string text)
{
MD5 md5 = new MD5CryptoServiceProvider();
md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
byte[] result = md5.Hash;
StringBuilder strBuilder = new StringBuilder();
for (int i = 0; i < result.Length; i++)
{
strBuilder.Append(result[i].ToString("x2"));
}
return strBuilder.ToString();
}
}
}

Uygulamamız artık son haline geldi. Artık çalışmaya hazır.
2.1. Uygulama testleri
Şifreleme tabındaki "Şifrelenecek Veri" alanına "marmarauni" yazıyoruz. LoginTest chechboxına tıklıyoruz. Aşağıdan SHA256 algoritmasını seçiyoruz. Son olarak "Şifrele butonuna basıyoruz."
Sonuç aşağıdaki gibi.

Test tabına geçtiğimizde girdiğimiz verilerin Şifreleme Tabından test tabına aktarıldığını görüyoruz.
Giriş Bilgileri alanına aşağıdaki bilgileri yazıyoruz.
Kullanıcı Adı : marmarauni
Şifre : marmarauni
Algoritma olarak SHA 256 seçiyoruz. Login butonuna bastığımızda şifrelenerek saklanan veriler ile yeniden giriş yaparken kullandığımız bilgilerin aynı metotla şifrelendikleri için başarılı şekilde karşılaştırmadan geçtiğini görüyoruz. İlgili veri ListBox'a basılmıştır.
Uygulamayı indirmek için 

Hazırlayanlar : 
Murat Samet KÜÇÜK
Oğuzhan KASAP
Muhammet YILDIZ
