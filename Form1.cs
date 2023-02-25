/*
Talha Yay (394762)–Tokenlarýn tanýmlanmasý ve hata ayýklama
Derya Çoban (394795)–GUI tasarýmý ve verilen deðerlere göre çizimi yaptýrma.
Sefa Subaþý (401058)–Okunan programýn tokenlara ayrýlmasý.

 */


using Nakov.TurtleGraphics;
using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Text;

namespace Drawing_Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void backward(int adim)
        {
            Turtle.Backward(adim);//Turtle kütüphanesinin geri çizen fonksiyonu.

        }
        void forward(int adim)
        {
            Turtle.Forward(adim);//Turtle kütüphanesinin ileri çizen fonksiyonu.

        }
        void Rotate(int adim)
        {
            Turtle.Rotate(adim);//Turtle kütüphanesinin dereceli döndüre fonksiyonu.
        }
        void size(int x)
        {
            Turtle.PenSize = x;//Turtle kütüphanesinin kalemini kalýnlýðýný ayarlayan elemaný.
        }
        void color(string x)
        {
            Turtle.PenColor = Color.FromName(x);//Turtle kütüphanesinin kalemini rengini ayarlayan elemaný.
        }

        bool final=false;//Çizim bitmesini için bekletmeye yarayan deðiþken.
        void painting(int loop,string[] data)//Bloklarýn içindeki her bir veri deðeri buradaki deðiþken karþýlðýna atýlýr ve iþlenir.
        {
            bool dongu1 = false, dongu2 = false, dongu3 = false, dongu4 = false, dongu5 = false;//Döngüleri aktif etmek için deðiþkenler oluþturuldu.
            //Bloktaki deðerlerin karþýlýðý olacak deðiþkenlerin tanýmlanmasý.
            int l1 = 0, f1 = 0, r1 = 0, l2 = 0, f2 = 0, r2 = 0, l3 = 0, f3 = 0, r3 = 0, l4 = 0, f4 = 0, r4 = 0, l5 = 0, f5 = 0, r5 = 0,size1=0,size2=0,size3=0,size4=0,size5=0;
            string color1=" ",color2 = " ", color3 = " ", color4 = " ", color5 = " ";
            for (int i = 0; i < loop; i++)//Her bir blok tek tek çýkarýlýr.
            {
                if (i == 0)//eðer eþitlik saðlanýyorsa döngü vardýr.
                {
                    dongu1 = true;//döngü aktif edilir.
                    string data1 = data[0];//data dan gelen ilk blok deðiþkene atýlýr.
                    Regex regex = new Regex(@"F|R|L|\d+|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");//bloðun tokenlara tanýmlanmasý.
                    MatchCollection tokensMatches = regex.Matches(data1);//tokenlarý eþleþmesi.
                    string[] dizi1 = new string[tokensMatches.Count];//tokenlar için yeni dizi
                    for (int o = 0; o < tokensMatches.Count; o++)//tokenlar tek tek diziye eklenir.
                        dizi1[o] = tokensMatches[o].Value;

                    for (int a = 0; a < dizi1.Length; a++)//tokenlarn karýþýlýðýna düþen deðerler deðiþkenlere atýlýr.
                    {
                        if (dizi1[a] == "L")
                            l1 = Convert.ToInt32(dizi1[a + 1]);
                        if (dizi1[a] == "F")
                            f1 = Convert.ToInt32(dizi1[a + 1]);
                        if (dizi1[a] == "R")
                            r1 = Convert.ToInt32(dizi1[a + 1]);
                        if (dizi1[a] == "COLOR ")
                            color1 = dizi1[a + 1];
                        if (dizi1[a] == "PEN")
                            size1 = Convert.ToInt32(dizi1[a + 1]);

                    }
                    //MessageBox.Show(l1.ToString() + " " +f1.ToString() + " "+ r1.ToString());
                }

                else if (i == 1)
                {
                    dongu2 = true;
                    string data2 = data[1];
                    Regex regex2 = new Regex(@"F|R|L|\d+|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");
                    MatchCollection tokensMatches2 = regex2.Matches(data2);
                    string[] dizi2 = new string[tokensMatches2.Count];
                    for (int t = 0; t < tokensMatches2.Count; t++)
                        dizi2[t] = tokensMatches2[t].Value;
                    for (int a = 0; a < dizi2.Length; a++)
                    {
                        if (dizi2[a] == "L")
                            l2 = Convert.ToInt32(dizi2[a + 1]);
                        if (dizi2[a] == "F")
                            f2 = Convert.ToInt32(dizi2[a + 1]);
                        if (dizi2[a] == "R")
                            r2 = Convert.ToInt32(dizi2[a + 1]);
                        if (dizi2[a] == "COLOR ")
                            color2 = dizi2[a + 1];
                        if (dizi2[a] == "PEN")
                            size2 = Convert.ToInt32(dizi2[a + 1]);

                    }
                }
                else if (i == 2)
                {
                    dongu3 = true;
                    string data3 = data[2];
                    Regex regex3 = new Regex(@"F|R|L|\d+|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");
                    MatchCollection tokensMatches3 = regex3.Matches(data3);
                    string[] dizi3 = new string[tokensMatches3.Count];
                    for (int t = 0; t < tokensMatches3.Count; t++)
                        dizi3[t] = tokensMatches3[t].Value;
                    for (int a = 0; a < dizi3.Length; a++)
                    {
                        if (dizi3[a] == "L")
                            l3 = Convert.ToInt32(dizi3[a + 1]);
                        if (dizi3[a] == "F")
                            f3 = Convert.ToInt32(dizi3[a + 1]);
                        if (dizi3[a] == "R")
                            r3 = Convert.ToInt32(dizi3[a + 1]);
                        if (dizi3[a] == "COLOR ")
                            color3 = dizi3[a + 1];
                        if (dizi3[a] == "PEN")
                            size3 = Convert.ToInt32(dizi3[a + 1]);

                    }
                }
                else if (i == 3)
                {
                    dongu4 = true;
                    string data4 = data[3];
                    Regex regex4 = new Regex(@"F|R|L|\d+|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");
                    MatchCollection tokensMatches4 = regex4.Matches(data4);
                    string[] dizi4 = new string[tokensMatches4.Count];
                    for (int t = 0; t < tokensMatches4.Count; t++)
                        dizi4[t] = tokensMatches4[t].Value;
                    for (int a = 0; a < dizi4.Length; a++)
                    {
                        if (dizi4[a] == "L")
                            l4 = Convert.ToInt32(dizi4[a + 1]);
                        if (dizi4[a] == "F")
                            f4 = Convert.ToInt32(dizi4[a + 1]);
                        if (dizi4[a] == "R")
                            r4 = Convert.ToInt32(dizi4[a + 1]);
                        if (dizi4[a] == "COLOR ")
                            color4 = dizi4[a + 1];
                        if (dizi4[a] == "PEN")
                            size4 = Convert.ToInt32(dizi4[a + 1]);

                    }
                }
                else if (i == 4)
                {
                    dongu5 = true;
                    string data5 = data[4];
                    Regex regex5 = new Regex(@"F|R|L|\d+|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");
                    MatchCollection tokensMatches5 = regex5.Matches(data5);
                    string[] dizi5 = new string[tokensMatches5.Count];
                    for (int t = 0; t < tokensMatches5.Count; t++)
                        dizi5[t] = tokensMatches5[t].Value;
                    for (int a = 0; a < dizi5.Length; a++)
                    {
                        if (dizi5[a] == "L")
                            l5 = Convert.ToInt32(dizi5[a + 1]);
                        if (dizi5[a] == "F")
                            f5 = Convert.ToInt32(dizi5[a + 1]);
                        if (dizi5[a] == "R")
                            r5 = Convert.ToInt32(dizi5[a + 1]);
                        if (dizi5[a] == "COLOR ")
                            color5 = dizi5[a + 1];
                        if (dizi5[a] == "PEN")
                            size5 = Convert.ToInt32(dizi5[a + 1]);

                    }
                }
            }

            int temp2 = l2, temp3 = l3, temp4 = l4, temp5 = l5;//her bir döngünün deðeri yedek olarak saklanmatadýr. Bunun sebebi döngü devamlýlýðý saðlamak içindir.
            //Aktif olan döngüler bloklarýnda bulunana deðerlere göre çalýþýp çizim yapacaklardýr.
            while (dongu1==true && l1>0)
            {
                l2 = temp2;
                if (f1 > 0)
                    forward(f1);//1. bloktaki F tokenýn deðerini gerçeklemektedir.
                if(r1>0)
                    Rotate(r1);//1. bloktaki R tokenýn deðerini gerçeklemektedir.
                if (color1 != " ")
                    color(color1);//1. bloktaki COLOR tokenýn deðerini gerçeklemektedir.
                if (size1 > 0)
                    size(size1);//1. bloktaki PEN tokenýn deðerini gerçeklemektedir.
                l1--;
                while (dongu2==true && l2 > 0)
                {
                    l3 = temp3;
                    if (f2 > 0)
                        forward(f2);
                    if (r2 > 0)
                        Rotate(r2);
                    if (color2 != " ")
                        color(color2);
                    if(size2>0)
                        size(size2);
                    l2--;
                    while (dongu3 == true && l3 > 0)
                    {
                        l4 = temp4;
                        if (f3 > 0)
                            forward(f3);
                        if (r3 > 0)
                            Rotate(r3);
                        if (color3 != " ")
                            color(color3);
                        if (size3 > 0)
                            size(size3);
                        l3--;
                        while (dongu4 == true && l4 > 0)
                        {
                            l5 = temp5;
                            if (f4 > 0)
                                forward(f4);
                            if (r4 > 0)
                                Rotate(r4);
                            if (color4 != " ")
                                color(color4);
                            if (size4 > 0)
                                size(size4);
                            l4--;
                            while (dongu5 == true && l5 > 0)
                            {
                                if (f5 > 0)
                                    forward(f5);
                                if (r5 > 0)
                                    Rotate(r5);
                                if (color5 != " ")
                                    color(color5);
                                if (size5 > 0)
                                    size(size5);
                                l5--;
                            }
                        }
                    }

                }
            }
            final = true;
        }


        string str = "";
        int loop=0;
        string[] data;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex<0)
                MessageBox.Show("Lütfen dizim seçiniz!");
            else
            {
            MessageBox.Show(str);
            Regex regex = new Regex(@"F|R|L|\d+|[[]|[]]|COLOR |PEN|BLUE|GREEN|YELLOW|ORANGE|PURPLE|BLACK|WHITE|PINK|GRAY");//Ýstenilen tokenlar regexe tanýmlandý.
            MatchCollection tokensMatches = regex.Matches(str);//Regex ile belirlenen tokenlar gelen dizi ile eþleþtirilir ve eþleþen tokenlar ayrýlýr.
            List<string> tokens = new List<string>();
            foreach (Match x in tokensMatches)//her bir token tokens listesine eklenir.
            {
                tokens.Add(x.Value);
                if (x.Value == "L")
                    loop++;
            }
            data = new string[loop];//Dizimizi bloklara ayýrmak için yeni dizi oluþturuyoruz.
            int kosegensayac = 0,loopsayac=0;
            for (int j=0; j<loop; j++)//Ayrýlan tokenlar bloklara ayýrlýdýðý yer.
            {
                    kosegensayac = 0;
                    loopsayac = 0;
                    for (int k=0; k<=tokens.Count-1; k++)// L ve [ karakterlerini 2 defa gördüðünde döngüyü kýrar. tokens dizisinden okuduðu elemanlarý data dizisine ekler ve tokens dizisinden alýnan elmanlar silinir.
                    {
                        if (tokens[0] == "[")
                            kosegensayac++;
                        if (kosegensayac == 2)
                            break;
                        if (tokens[0] == "L")
                            loopsayac++;
                        if (loopsayac == 2)
                            break;

                        data[j] += tokens[0];//Dizi elamanlarý ait olduðu bloða eklenir.
                        tokens.RemoveAt(0);//data dizisine eklenen elemanlar silinir.


                    }
                    kosegensayac = 0;
                    loopsayac = 0;
                    int y = 0;
                    for (y=tokens.Count-1; y >= 0; y--)//saðdan sola tarama yapýlýr.
                    {
                        if (tokens[y] == "]")
                            kosegensayac++;
                        if (kosegensayac == 2)
                            break;
                        if (tokens[y] == "L")
                            loopsayac++;
                        if (loopsayac == 2)
                            break;
                       
                    }
                    for (int k = tokens.Count - (tokens.Count-1 - y); k < tokens.Count; k++)//Eleman ait olduðu bloða yerleþir.
                        data[j] += tokens[k];

                   tokens.RemoveRange(tokens.Count - (tokens.Count - 1 - y), tokens.Count - 1 - y);//yerleþtirilen elemanlar tokens listesinden silinir.
                }


                foreach (string x in data)//Hata kontrolü yapýlýr.
                {
                    MessageBox.Show(x);
                    if (x == null)//Dizide boþ eleman varsa çizim durdurulur.
                    {
                        label2.Text = "HATALI DÝZÝM ÝÇERMEKTEDÝR!";
                        final = true;
                        break;
                    }
                }
                    

             
            //Turtle çizim kütüphanesi projemize uygun hale getirilmiþtir.
            Turtle.Delay = 1;
            Turtle.ShowTurtle = false;
            Turtle.PenColor = colorDialog1.Color;
            Turtle.PenSize = Convert.ToInt32(comboBox1.Text);
                Turtle.Backward();
                Turtle.Y = 100;
            


                //for (i = 0; i < 36; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        forward(100);
                //        Rotate(90);

                //    }
                //    Rotate(10);
                //}



                //for (int i =0; i<str.Length;i++)
                //{
                //    if (str[i] == 'L' || str[i] == 'F' || str[i] == 'R' || str[i] == '[' || str[i] == ']')
                //    {
                //        dizi[j] += str[i];
                //        j++;
                //    }
                //}

                //foreach (string x in tokens)
                //    MessageBox.Show(x);


                //var aTokens = new List<string>();
                //var tekrar = new List<int>();
                //string dizim = textBox1.Text;
                //string rakam = "0123456789";
                //string sayi = "";
                //bool x = false;
                //for(int i=0; i<dizim.Length; i++)
                //{
                //    switch(dizim[i])
                //    {
                //        case 'F':
                //            aTokens.Add(dizim[i].ToString());
                //            for(int t=2; t<10;t++)
                //            {
                //                for(int j=0;j<10;j++)
                //                {
                //                    if (dizim[i+t] == rakam[j])
                //                    {
                //                        sayi += rakam[j];
                //                        i++;
                //                        x= true;
                //                        break;
                //                    }
                //                    x= false;
                //                }
                //                if (x == false)
                //                    break;

                //            }

                //            break;
                //        case 'R':

                //            break;
                //        case 'L':

                //            break;

                //        case 'C':
                //            if (dizim[i + 1] == 'O' && dizim[i + 2] == 'L' && dizim[i + 3] == 'O' && dizim[i + 4] == 'R')
                //            {

                //            }
                //            break;

                //        case 'P':
                //            if (dizim[i + 1] == 'E' && dizim[i + 2] == 'N')
                //            {

                //            }
                //            break;
                //    }
                //    MessageBox.Show(sayi);
                //    tekrar.Add(Convert.ToInt32(sayi));
                //    sayi = "";



                //} 
                button1.Visible = false;
                button3.Visible = true;                
                if (label2.Text == "")//Label kontorl edilerek hata olup olmamasý denetlenir. Fonksiyon bu duruma göre çaðrýlýr.
                    painting(loop, data);


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\derya\OneDrive\Masaüstü\Drawing_Robot\dizi.txt", Encoding.UTF8);//txt ten alýnan veriler bir diziye line line eklenir

            foreach (string x in lines)//dizideki her eleman listbox a item olarak eklenir.
            {
                listBox1.Items.Add(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Program ilk haline getiren reset butonudur.
        {
            if (final == true)
            {
                button1.Visible = true;
                button3.Visible = false;
                label2.Text = "";
                Turtle.Reset();
                loop = 0;
                data = null;
                final = false;
            }
            else
                MessageBox.Show("Lütfen Çizimin Bitmesini Bekleyiniz...");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = listBox1.SelectedItem.ToString();

        }

    }
}