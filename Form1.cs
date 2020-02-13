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

namespace Snils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Cargo
        {
            public string fam { get; set; }
            public string im { get; set; }
            public string ot { get; set; }
            public string dr { get; set; }
            public string resp { get; set; }
            public string rn { get; set; }
            public string np { get; set; }
            public string ul { get; set; }
            public string dom { get; set; }
            public string kv { get; set; }
            public string korp { get; set; }

            public void piece(string line)
            {
                string[] parts = line.Split(',');  //Разделитель в CVS файле.
                fam = parts[0];
                im = parts[1];
                ot = parts[2];
                dr = parts[3];
                resp = parts[4];
                rn = parts[5];
                np = parts[6];
                ul = parts[7];
                dom = parts[8];
                kv = parts[9];
                korp = parts[10];
            }



            public static List<Cargo> ReadFile(string filename)
            {
                List<Cargo> res = new List<Cargo>();
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Cargo p = new Cargo();
                        p.piece(line);
                        res.Add(p);
                    }
                }

                return res;
            }
        }
        private void saveSnils_Click(object sender, EventArgs e)
        {
            List<Cargo> CSV_Struct = new List<Cargo>();
            CSV_Struct = Cargo.ReadFile("test.csv");
            for (int i = 0; i <= CSV_Struct.Count - 1; i++)
            {
                Image image = Image.FromFile("IT0016.jpg");
                using (Graphics g = Graphics.FromImage(image))
                {
                    Font font1 = new Font("Arial Black", 16, FontStyle.Regular);
                    Font font = new Font("Arial", 14, FontStyle.Regular);
                    SolidBrush Brush2 = new SolidBrush(Color.Black);
                    g.DrawString(CSV_Struct[i].im, font1, Brush2, new Point(315, 120));
                    g.DrawString(CSV_Struct[i].ot, font, Brush2, new Point(115, 145));
                    g.DrawString(CSV_Struct[i].resp, font, Brush2, new Point(115, 165));
                    g.DrawString(CSV_Struct[i].rn, font, Brush2, new Point(115, 185));
                    g.DrawString(CSV_Struct[i].np, font, Brush2, new Point(115, 185));
                    g.DrawString(CSV_Struct[i].ul, font, Brush2, new Point(115, 185));
                    g.DrawString(CSV_Struct[i].dom, font, Brush2, new Point(115, 185));
                }
                image.Save("/img/"+CSV_Struct[i].im+ CSV_Struct[i].ot+"snils.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}
