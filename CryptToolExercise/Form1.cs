using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Numerics;

namespace CryptToolExercise
{

    public partial class Form1 : Form
    {
        public static string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbVigenere_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt1_Click(object sender, EventArgs e)
        {

            String m = tbText1.Text; //Lay string tu textbox
            String k = textKey1.Text;
            StringBuilder n = new StringBuilder();

            n.Append(m); //Copy chuoi m sang chuoi stringbuilder n

            if (tbText1.Text.Equals("")) // Kiem tra chuoi nhap vao rong
            {
                MessageBox.Show("Vui long nhap message text!");
                tbText1.Focus();
            }
            if (textKey1.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap message text!");
                textKey1.Focus();
            }

            StringBuilder re = new StringBuilder();
            re = vigenereEncrypt(ref n, k);
            tbResult1.Text = re.ToString();
        }

        static StringBuilder vigenereEncrypt(ref StringBuilder a, String key)
        {


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Char.ToUpper(a[i]); //Chuyen sang chu In
            }
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsLetter(a[i]))
                {
                    a[i] = (char)(a[i] + key[j] - 'A');
                    if (a[i] > 'Z') a[i] = (char)(a[i] - 'Z' + 'A' - 1);
                    j = j + 1 == key.Length ? 0 : j + 1;
                }
            }
            return a;
        }

        private void btnDecrypt1_Click(object sender, EventArgs e)
        {
            String m = tbText1.Text;
            String k = textKey1.Text;
            StringBuilder n = new StringBuilder();
            n.Append(m);
            if (tbText1.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap message text!");
                tbText1.Focus();
            }

            if (textKey1.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap message text!");
                textKey1.Focus();
            }
            StringBuilder re = new StringBuilder();
            re = vigenereDecrypt(ref n, k);
            tbResult1.Text = re.ToString();

        }

        static StringBuilder vigenereDecrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper(); // Chu in hoa
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i])) //Kiem tra co phai ki tu ko
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                    j = j + 1 == key.Length ? 0 : j + 1; //kiem tra co het chuoi key chua           
                }

            }
            return s;
        }

        private void btnIns1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\C#\CryptToolExercise\CryptToolExercise\MMH.pdf");
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\test.txt"; //Tao duong dan mac dinh khi browse
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // loai tep
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            tbText1.Text = File.ReadAllText(openFileDialog1.InitialDirectory);
                            //lay file theo duong dan luu trong openFileDialog1.InitialDirectory
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIns2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:\C#\CryptToolExercise\CryptToolExercise\MMH.pdf");
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt2_Click(object sender, EventArgs e)
        {
            String message = tbText2.Text; // lay chuoi da nhap tu textbox
            String key = tbKey2.Text; //lay chuoi key da nhao tu textbox

            if (rb1.Checked == true) EncryptPf_M5(message, key);
            else EncryptPf_M6(message, key);

        }

        private void EncryptPf_M6(String message, String key)
        {

            message = tbText2.Text;
            key = tbKey2.Text;
            Matrix_6x6(message, key);
            String[,] matrix = new String[5, 5];

        }

        private void EncryptPf_M5(String message, String key)
        {
            message = tbText2.Text;
            key = tbKey2.Text;
            Matrix_5x5(message, key);

        }
        void PlayFair(Char a, Char b, Char[,] matrix)
        {
            int w = 0, x = 0, y = 0, z = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a == matrix[i, j])
                    {
                        w = j;
                        x = i;
                    }
                    if (b == matrix[i, j])
                    {
                        y = j;
                        z = i;
                    }
                }
            }
            //Cu`ng ha`ng
            if (x == z)
            {
                w = (w + 1) % 5;
                y = (y + 1) % 5;
                result += matrix[x, w];
                result += matrix[z, y];


            }
            //Cu`ng cô?t
            else if (w == y)
            {
                x = (x + 1) % 5;
                z = (z + 1) % 5;
                result += matrix[x, w];
                result += matrix[z, y];

            }
            else
            {
                result += matrix[x, y];
                result += matrix[z, w];

            }
        }

        void Matrix_5x5(String plaintext, String key)
        {
            Char[,] arr = new Char[5, 5];
            String plaintext_1 = plaintext.Trim();
            String plaintext_2 = plaintext_1.Replace("J", "I");
            String plaintext_3 = plaintext_2.Replace("j", "I");
            String plaintext_4 = plaintext_3.Replace(" ", string.Empty);
            String plaintext_5 = plaintext_4.ToUpper();

            String key_1 = key.Trim();
            String key_2 = key_1.Replace(" ", string.Empty);
            String key_3 = key_2.ToUpper();
            String key_4 = RemoveDuplicates(key_3);
            int k = 0;
            char a = 'A';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k < key_4.Length)
                        arr[i, j] = key_4[k];
                    else if (k == key_4.Length)
                    {
                    a:
                        for (int l = 0; l < key_4.Length; l++)
                        {
                            if (key_4[l] == a)
                            {
                                if (a == 'I')
                                    a = (Char)(a + 2);
                                else
                                    a = (Char)(a + 1);
                                goto a;
                            }
                        }
                        arr[i, j] = a;
                        if (a == 'I')
                            a = (Char)(a + 2);
                        else
                            a = (Char)(a + 1);
                    }
                    if (k < key_4.Length)
                        k++;
                }
            }
            tbA11.Text = arr[0, 0].ToString();
            tbA12.Text = arr[0, 1].ToString();
            tbA13.Text = arr[0, 2].ToString();
            tbA14.Text = arr[0, 3].ToString();
            tbA15.Text = arr[0, 4].ToString();
            tbA21.Text = arr[1, 0].ToString();
            tbA22.Text = arr[1, 1].ToString();
            tbA23.Text = arr[1, 2].ToString();
            tbA24.Text = arr[1, 3].ToString();
            tbA25.Text = arr[1, 4].ToString();
            tbA31.Text = arr[2, 0].ToString();
            tbA32.Text = arr[2, 1].ToString();
            tbA33.Text = arr[2, 2].ToString();
            tbA34.Text = arr[2, 3].ToString();
            tbA35.Text = arr[2, 4].ToString();
            tbA41.Text = arr[3, 0].ToString();
            tbA42.Text = arr[3, 1].ToString();
            tbA43.Text = arr[3, 2].ToString();
            tbA44.Text = arr[3, 3].ToString();
            tbA45.Text = arr[3, 4].ToString();
            tbA51.Text = arr[4, 0].ToString();
            tbA52.Text = arr[4, 1].ToString();
            tbA53.Text = arr[4, 2].ToString();
            tbA54.Text = arr[4, 3].ToString();
            tbA55.Text = arr[4, 4].ToString();


            int m = 0;
            while (m < plaintext_5.Length)
            {
                if (m == plaintext_5.Length - 1)
                    PlayFair(plaintext_5[m], 'X', arr);
                else if (plaintext_5[m] == plaintext_5[m + 1])
                    PlayFair(plaintext_5[m], 'X', arr);
                else
                {
                    PlayFair(plaintext_5[m], plaintext_5[m + 1], arr);
                    m++;
                }
                m++;
            }
            tbResult2.Text = result;

        }

        void PlayFair_2(Char a, Char b, Char[,] matrix)
        {
            int w = 0, x = 0, y = 0, z = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (a == matrix[i, j])
                    {
                        w = j;
                        x = i;
                    }
                    if (b == matrix[i, j])
                    {
                        y = j;
                        z = i;
                    }
                }
            }
            //Cu`ng ha`ng
            if (x == z)
            {
                w = (w + 1) % 6;
                y = (y + 1) % 6;
                result += matrix[x, w];
                result += matrix[z, y];


            }
            //Cu`ng cô?t
            else if (w == y)
            {
                x = (x + 1) % 6;
                z = (z + 1) % 6;
                result += matrix[x, w];
                result += matrix[z, y];

            }
            else
            {
                result += matrix[x, y];
                result += matrix[z, w];

            }
        }

        void Matrix_6x6(String plaintext, String key)
        {
            Char[,] arr = new Char[6, 6];
            String plaintext_1 = plaintext.Trim();
            String plaintext_2 = plaintext_1.Replace(" ", string.Empty);
            String plaintext_3 = plaintext_2.ToUpper();

            String key_1 = key.Trim();
            String key_2 = key_1.Replace(" ", string.Empty);
            String key_3 = key_2.ToUpper();
            String key_4 = RemoveDuplicates(key_3);
            int k = 0;
            char[] a = new char[36] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
				'0','1','2','3','4','5','6','7','8','9'};
            int p = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (k < key_4.Length)
                        arr[i, j] = key_4[k];
                    else if (k == key_4.Length)
                    {
                    b:
                        for (int l = 0; l < key_4.Length; l++)
                        {
                            if (key_4[l] == a[p])
                            {
                                p++;
                                goto b;
                            }
                        }
                        arr[i, j] = a[p];
                        p++;
                    }
                    if (k < key_4.Length)
                        k++;
                }
            }
            tbA11.Text = arr[0, 0].ToString();
            tbA12.Text = arr[0, 1].ToString();
            tbA13.Text = arr[0, 2].ToString();
            tbA14.Text = arr[0, 3].ToString();
            tbA15.Text = arr[0, 4].ToString();
            tbA16.Text = arr[0, 5].ToString();
            tbA21.Text = arr[1, 0].ToString();
            tbA22.Text = arr[1, 1].ToString();
            tbA23.Text = arr[1, 2].ToString();
            tbA24.Text = arr[1, 3].ToString();
            tbA25.Text = arr[1, 4].ToString();
            tbA26.Text = arr[1, 5].ToString();
            tbA31.Text = arr[2, 0].ToString();
            tbA32.Text = arr[2, 1].ToString();
            tbA33.Text = arr[2, 2].ToString();
            tbA34.Text = arr[2, 3].ToString();
            tbA35.Text = arr[2, 4].ToString();
            tbA36.Text = arr[2, 5].ToString();
            tbA41.Text = arr[3, 0].ToString();
            tbA42.Text = arr[3, 1].ToString();
            tbA43.Text = arr[3, 2].ToString();
            tbA44.Text = arr[3, 3].ToString();
            tbA45.Text = arr[3, 4].ToString();
            tbA46.Text = arr[3, 5].ToString();
            tbA51.Text = arr[4, 0].ToString();
            tbA52.Text = arr[4, 1].ToString();
            tbA53.Text = arr[4, 2].ToString();
            tbA54.Text = arr[4, 3].ToString();
            tbA55.Text = arr[4, 4].ToString();
            tbA56.Text = arr[4, 5].ToString();
            tbA61.Text = arr[5, 0].ToString();
            tbA62.Text = arr[5, 1].ToString();
            tbA63.Text = arr[5, 2].ToString();
            tbA64.Text = arr[5, 3].ToString();
            tbA65.Text = arr[5, 4].ToString();
            tbA66.Text = arr[5, 5].ToString();

            int m = 0;
            while (m < plaintext_3.Length)
            {
                if (m == plaintext_3.Length - 1)
                    PlayFair_2(plaintext_3[m], 'X', arr);
                else if (plaintext_3[m] == plaintext_3[m + 1])
                    PlayFair_2(plaintext_3[m], 'X', arr);
                else
                {
                    PlayFair_2(plaintext_3[m], plaintext_3[m + 1], arr);
                    m++;
                }
                m++;
            }
            tbResult2.Text = result;
            result = null;
        }


        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        private void tbResult2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        // RSA START HERE
        private void tabDES_Click(object sender, EventArgs e)
        {

        }

        private void lbKey3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gbInputRSA_Enter(object sender, EventArgs e)
        {

        }

        private void gbPQRSA_Enter(object sender, EventArgs e)
        {

        }
       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tbText3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int _p = 0, _q = 0;
            Random rd = new Random();
        b:
            _p = rd.Next(2, 1000);
            if (checkSNT(_p) == 0) { goto b; }
            else goto c;
        c:
            _q = rd.Next(2, 1000);
            if (checkSNT(_q) == 0) { goto c; }
            else goto d;
        d:
            tbP.Text = _p.ToString();
            tbQ.Text = _q.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int _p, _q;
            _p = Convert.ToInt32(tbP.Text);
            _q = Convert.ToInt32(tbQ.Text);

           
            if (checkSNT(_p) == 0)
            {
                MessageBox.Show("The number of p you've chosen is not correct! Please choose a prime number !");
            }
            else
            {
                MessageBox.Show("You can use this number of p");
            }
            if (checkSNT(_q) == 0)
            {
                MessageBox.Show("The number of q you've chosen is not correct! Please choose a prime number !");
            }
            else
            {
                MessageBox.Show("You can use this number of q");
            }
        }

        static BigInteger Euler = 0;
        static BigInteger pxq = 0;
        public int checkSNT(BigInteger a)
        {
            if (a < 2) return 0;
            else
                for (int i = 3; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        return 0;
                    }
                }
            return 1;
        }

        private void btnChecke_Click(object sender, EventArgs e)
        {
            BigInteger selecte, rec,ran, p, q;
            bool _selecte = BigInteger.TryParse(tbSelecte.Text,out selecte);
            bool _p = BigInteger.TryParse(tbP.Text, out p);
            bool _q = BigInteger.TryParse(tbQ.Text, out q);
            Euler = (p - 1) * (q - 1);
            Random r = new Random();
            if (selecte >= Euler || selecte <= 1)
            {
                MessageBox.Show("You've entered an invalid e number!");
            }
            else
            {
                if (KTSNTCN(selecte, Euler) == true)
                {
                    MessageBox.Show("You can use this e number");
                }
                else
                {
                    MessageBox.Show("Please choose another e number");
                }
            }
            for (long i = 2; i < Euler - 1; i++)
            {
                if (KTSNTCN(i, Euler) == true) { tbeRecommend.Text = i.ToString(); break; }
                else continue;
            }
        }
        BigInteger UCLN(BigInteger a, BigInteger b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        bool KTSNTCN(BigInteger a, BigInteger b)
        {
            if (UCLN(a, b) == 1)
                return true;
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int _p, _q;
            
            _p = Convert.ToInt32(tbP.Text);
            _q = Convert.ToInt32(tbQ.Text);
            pxq = _p * _q;
            tbPublicKey.AppendText("(" + tbSelecte.Text + ",");
            tbPublicKey.AppendText("" +pxq.ToString() +")");
            tbPrivateKey.AppendText("(" + tbdRecommend.Text +",");
            tbPrivateKey.AppendText("" + pxq.ToString() + ")");

        }
    
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbSelectd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckd_Click(object sender, EventArgs e)
        {
            BigInteger _d, _e, _ran;
            bool bigE = BigInteger.TryParse(tbSelecte.Text,out _e);
            _d = selectD(_e, Euler);
            tbdRecommend.Text = _d.ToString();
        }
        private void btnEncryptRSA_Click(object sender, EventArgs e)
        {
            BigInteger  _d, _e;            
            double temp=0;
            byte[] m = Encoding.ASCII.GetBytes(tbText3.Text);
            bool boole = BigInteger.TryParse(tbSelecte.Text, out _e);
            bool boold = BigInteger.TryParse(tbdRecommend.Text, out _d);
            BigInteger _n = pxq;
            
            if (rbPublic.Checked == true) { EncryptRSAPub(m, _e, _n); }
            else { EncryptRSAPri(m, _d, _n); }                
        }

        public void EncryptRSAPub(byte[] m, BigInteger _e, BigInteger _n)
        {
            BigInteger temp = 0;
            for (long i = 0; i < m.Length; i++)
            {
                BigInteger temp1 =  m[i];
                temp = (BigInteger.Pow(temp1,(int) _e)) % _n;
                tbResult.AppendText(temp + " ");
            }
        }

        public void EncryptRSAPri(byte[] m, BigInteger _d, BigInteger _n)
        {
            BigInteger temp = 0;
            for (int i = 0; i < m.Length; i++)
            {
                BigInteger temp2 = m[i];
                temp = (BigInteger.Pow(m[i],(int) _d)) % _n;
                tbResult.AppendText(temp + " ");
            }
        }

        public bool isInteger(Decimal num)
        {
            if ((num % 1) == 0) return true;
            else
            return false;
        }
           public BigInteger selectD(BigInteger e, BigInteger n)
        {
            BigInteger d = 0;
            for (BigInteger i = 2; i < 500; i++)
            {
                Decimal temp = (Decimal)((i * n + 1) / e);
                if (isInteger(temp) == true)
                {
                    String tempd = Convert.ToString(temp);
                    bool _d = BigInteger.TryParse(tempd, out d);
                }
                else
                {
                    continue;
                }
            }
            return d;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = " ";
            tbPublicKey.Text = " ";
            tbPrivateKey.Text = " ";
            tbSelecte.Text = " ";
            tbdRecommend.Text = " ";
            tbeRecommend.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          rbPrivate.Enabled =  rbPublic.Enabled = false;
          String c = tbText3.Text ;
          tbResult.Text = Convert.ToString(c);
       
        }

        public void getCipherText(String m)
        {
            String c=" ";
            for (int i = 0; i < m.Length; i++)
            {
                if (Char.IsLetter(m[i]))
                {
                    c += m[i];
                }
                else continue;
            }
            
        }
        public void DecryptRSA(String m,BigInteger d, BigInteger n )
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                default: ctrl.BackColor = Color.Green;
                    break;
            }
            
            String p = tbPP.Text;
            String g = tbGG.Text;
            BigInteger _p, _g;            
            bool __p = BigInteger.TryParse(p, out _p);
            bool __g = BigInteger.TryParse(g, out _g);
            if (checkSNT(_p) == 1 && _g<_p)
            {
                MessageBox.Show("You can use these numbers!");
            }
            else
            {
                MessageBox.Show("Please check p and g again!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                default: ctrl.BackColor = Color.Green;
                    break;
            }
            Random r = new Random();
            BigInteger ran1 = new BigInteger(r.Next(128, 256 ));
            BigInteger ran2 = new BigInteger(r.Next(128,256));
            tba.Text = Convert.ToString(ran1);
            tbb.Text = Convert.ToString(ran2);
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                default: ctrl.BackColor = Color.Green;
                    break;
            }
            Random r = new Random();
            BigInteger ran1;
            do{
                ran1 = new BigInteger(r.Next(128, 256));
            }while(checkSNT(ran1) == 0);
            
            BigInteger ran2 = new BigInteger(r.Next(2, 100));

            tbPP.Text = Convert.ToString(ran1);
            tbGG.Text = Convert.ToString(ran2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                default: ctrl.BackColor = Color.Green;
                    break;
            }
            BigInteger _a, _b, _rA, _rB, _g, _p;
            bool __a = BigInteger.TryParse(tba.Text, out _a);
            bool __g = BigInteger.TryParse(tbGG.Text, out _g);
            bool __b = BigInteger.TryParse(tbb.Text, out _b);
            bool __p = BigInteger.TryParse(tbPP.Text, out _p);
            _rA = BigInteger.Pow(_g, (int)_a) % _p;
            _rB = BigInteger.Pow(_g, (int)_b) % _p;
            tbAA.Text = Convert.ToString(_rA);
            tbBB.Text = Convert.ToString(_rB);
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                default: ctrl.BackColor = Color.Green;
                    break;
            }
            BigInteger _a, _b, _rA, _rB, _g, _p, _A, _B;
            bool __a = BigInteger.TryParse(tba.Text, out _a);
            bool __g = BigInteger.TryParse(tbGG.Text, out _g);
            bool __b = BigInteger.TryParse(tbb.Text, out _b);
            bool __p = BigInteger.TryParse(tbPP.Text, out _p);
            bool __A = BigInteger.TryParse(tbAA.Text, out _A);
            bool __B = BigInteger.TryParse(tbBB.Text, out _B);
            _rA = BigInteger.Pow(_B, (int)_a) % _p;
            _rB = BigInteger.Pow(_A, (int)_b) % _p;
            tbS1.Text = Convert.ToString(_rA);
            tbS2.Text = Convert.ToString(_rB);
        }

        private void tbPP_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
