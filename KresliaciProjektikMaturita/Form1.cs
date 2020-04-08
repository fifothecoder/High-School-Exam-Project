using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KresliaciProjektikMaturita
{
    public partial class Form1 : Form {
        private const string QUADRATIC_TEXT = "Výsledok : ";
        private const string DAY_TEXT = "Daný deň ";
        private const string ANGLE_TEXT = "Uhol je : ";

        private const string FILE_OUTPUT_NAME = "output.txt";

        private Graphics __g__ = null;

        private Graphics Graph {
            get {
                if (__g__ == null) __g__ = pictureBox1.CreateGraphics();

                return __g__;
            }
            set => __g__ = value;
        }
        

        public Form1()
        {
            InitializeComponent();
            lQuadratic.Text = QUADRATIC_TEXT;
            numQA.Value = 2;
            numQB.Value = 5;
            numQC.Value = -3;

            lDayAnswer.Text = DAY_TEXT;
        }

        private void btnQuadratic_Click(object sender, EventArgs e) {
            decimal discriminant = 0;
            decimal a = numQA.Value;
            decimal b = numQB.Value;
            decimal c = numQC.Value;

            discriminant = (b * b) - (4 * a * c);

            if (a == 0) {
                lQuadratic.Text = "Daná rovnica nie je kvadratická!";
                return;
            }


            if (discriminant < 0) lQuadratic.Text = "Daná rovnica nemá žiadny reálny koreň!";
            else if (discriminant == 0) {
                decimal x = -b;
                x = x / (2 * a);

                //TODO:Do some rounding

                lQuadratic.Text = QUADRATIC_TEXT + $"Rovnica má jedno riešenie {{{x}}}.";
            }
            else {
                decimal x1 = -b + (decimal)Math.Sqrt((double)discriminant);
                decimal x2 = -b - (decimal)Math.Sqrt((double)discriminant);
                x1 = x1 / (2 * a);
                x2 = x2 / (2 * a);

                //TODO:Do some rounding

                lQuadratic.Text = QUADRATIC_TEXT + $"Rovnica má dve riešenia {{{x1}, {x2}}}.";
            }

        }

        private void btnDay_Click(object sender, EventArgs e) {

            lDayAnswer.Text = DAY_TEXT + (numDay.Value <= DateTime.DaysInMonth((int)numYear.Value, (int)numMonth.Value) ? "existuje" : "neexistuje");
        }

        private bool LoadText(out string[] pole) {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName)) {
                        List<string> lines = new List<string>();
                        while (!reader.EndOfStream)  lines.Add(reader.ReadLine());
                        pole = lines.ToArray();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Zlý súbor!");
                    pole = null;
                    return false;
                }

            }
        }

        private void SaveText(string path, string[] content) {
            using (StreamWriter writer = new StreamWriter(path)) {
                foreach (var line in content) writer.WriteLine(line);
            }
        }

        private void btnFileReverse_Click(object sender, EventArgs e) {
            if (!LoadText(out string[] pole)) return;

            pole = pole.Reverse().ToArray();

            SaveText(FILE_OUTPUT_NAME, pole);
        }

        private void btnFileRandom_Click(object sender, EventArgs e)
        {
            if (!LoadText(out string[] pole)) return;

            Random r = new Random();
            for (int i = 0; i < 1000; i++) {
                int first = r.Next(0, pole.Length);
                int second = r.Next(0, pole.Length);
                if (first == second) continue;

                string temp = pole[first];
                pole[first] = pole[second];
                pole[second] = temp;

            }

            SaveText(FILE_OUTPUT_NAME, pole);
        }

        private void btnFileClear_Click(object sender, EventArgs e)
        {
            if (!LoadText(out string[] pole)) return;

            List<string> output = new List<string>();

            foreach (var line in pole) {
                bool isEmpty = true;
                foreach (var c in line)  if (!char.IsSeparator(c)) isEmpty = false;
                
                if(!isEmpty)
                    output.Add(line);
            }

            SaveText(FILE_OUTPUT_NAME, output.ToArray());
        }

        private void btnAngle_Click(object sender, EventArgs e) {
            double hours = (double) numAngleHours.Value;
            double minutes = (double) numAngleMinutes.Value;

            if (hours > 11) hours -= 12;

            double angleOfHour = 0.5 * (60 * hours + minutes);
            double angleOfMin = 6 * minutes;

            double angleOfDifference = Math.Abs(angleOfHour - angleOfMin);
            if (angleOfDifference > 180) angleOfDifference = 360 - angleOfDifference;
            lAngleAnswer.Text = $"{ANGLE_TEXT}{angleOfDifference}°";
        }

        private void btnMotionPoint_Click(object sender, EventArgs e)
        {
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            int radius = 150, smallRadius = 10;
            //Graph.DrawEllipse(Pens.Black, center.X - (radius / 2), center.Y - (radius / 2), radius, radius);

            for (int i = 0; i < 360; i+=2) {

                float x = (float)Math.Cos(i * Math.PI / 180);
                float y = (float)Math.Sin(i * Math.PI / 180);

                Graph.FillRectangle(Brushes.WhiteSmoke, -1, -1, pictureBox1.Width, pictureBox1.Height);
                //Draw middle
                Graph.DrawLine(Pens.Black, center.X - 5, center.Y - 5, center.X + 5, center.Y + 5);
                Graph.DrawLine(Pens.Black, center.X - 5, center.Y + 5, center.X + 5, center.Y - 5);
                Graph.FillEllipse(Brushes.Black, center.X - radius / 2 * x - (smallRadius / 2), center.Y - radius / 2 * y - (smallRadius / 2), smallRadius, smallRadius);
                Thread.Sleep(30);

            }

            Graph.FillRectangle(Brushes.WhiteSmoke, -1, -1, pictureBox1.Width, pictureBox1.Height);

        }
        /// <summary>
        /// Simple function used to draw the enlarging circle.
        /// </summary>
        /// <param name="sender">WinForms parameter</param>
        /// <param name="e">WinForms parameter</param>
        private void btnCircle_Click(object sender, EventArgs e)
        {
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            int radius = 100;
            for (int i = 0; i < radius * 2; i+=2) {
                Graph.FillEllipse(Brushes.Orange, center.X - (i / 2), center.Y - (i / 2), i, i);
                //Draw middle
                Graph.DrawLine(Pens.Black, center.X - 5, center.Y - 5, center.X + 5, center.Y + 5);
                Graph.DrawLine(Pens.Black, center.X - 5, center.Y + 5, center.X + 5, center.Y - 5);
                Thread.Sleep(20);
            }
        }

        /// <summary>
        /// This function draws clock in the middle of the drawing plane. While set up to work with every minute and hour, there is a check to end it in the quarter.
        /// To prevent that behaviour, comment the if statement just before the Thread.Sleep() call.
        /// </summary>
        /// <param name="sender">WinForms parameter</param>
        /// <param name="e">WinForms parameter</param>
        private void btnClock_Click(object sender, EventArgs e)
        {
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            int radius = 200;
            Graph.FillRectangle(Brushes.WhiteSmoke, -1, -1, pictureBox1.Width, pictureBox1.Height);

            //Draw middle
            //Graph.DrawLine(Pens.Black, center.X - 5, center.Y - 5, center.X + 5, center.Y + 5);
            //Graph.DrawLine(Pens.Black, center.X - 5, center.Y + 5, center.X + 5, center.Y - 5);

            void DrawClock() {
                Graph.DrawEllipse(Pens.Black, center.X - (radius / 2), center.Y - (radius / 2), radius, radius);

                for (int i = 0; i < 60; i++)
                {
                    Point cur = GetGlobalCoordinates(i, radius);
                    cur.X = center.X - cur.X;
                    cur.Y = center.Y - cur.Y;

                    if(i % 5 == 0) Graph.FillEllipse(Brushes.Black, cur.X - 4, cur.Y - 4, 8, 8);
                    else Graph.FillEllipse(Brushes.Black, cur.X - 2, cur.Y - 2, 4, 4);
                }
                Graph.FillEllipse(Brushes.WhiteSmoke, center.X - radius / 2 + 10, center.Y - radius / 2 + 10, radius - 20, radius - 20);
            }

            int testTicks = 180;
            DrawClock();
            Pen hourPen     = new Pen(Color.Red, 4);
            Pen minutePen   = new Pen(Color.Green, 2);

            for (int hour = 0; hour < 12; hour++) {
                for (int min = 0; min < 60; min++, testTicks--) {
                    

                    Point h = GetHourCoordinates(hour, radius, min);
                    h.X = center.X - h.X;
                    h.Y = center.Y - h.Y;

                    Point m = GetMinuteCoordinates(min, radius);
                    m.X = center.X - m.X;
                    m.Y = center.Y - m.Y;

                    Graph.DrawLine(hourPen, center.X, center.Y, h.X, h.Y);
                    Graph.DrawLine(minutePen, center.X, center.Y, m.X, m.Y);

                    if (testTicks == 0) goto Out;

                    Thread.Sleep(100);
                    Graph.FillEllipse(Brushes.WhiteSmoke, center.X - radius / 2 + 10, center.Y - radius / 2 + 10, radius - 20, radius - 20);
                }
            }

            Out:;

        }
        
        //TODO:Update the functions relative to the circle center

        private Point GetGlobalCoordinates(int mark, int radius)
        {
            if (mark < 0 || mark > 60) throw new ArgumentOutOfRangeException("This mark does not exist!");

            int angle = mark * 6;

            double x = Math.Cos(Math.PI / 2 + angle * Math.PI / 180);
            double y = Math.Sin(Math.PI / 2 + angle * Math.PI / 180);

            return new Point((int)(x * radius / 2), (int)(y * radius / 2));
        }

        private Point GetMinuteCoordinates(int minute, int radius) {
            if (minute < 0 || minute > 60) throw new ArgumentOutOfRangeException("This mark does not exist!");

            int angle = minute * 6;

            double x = Math.Cos(Math.PI / 2 + angle * Math.PI / 180);
            double y = Math.Sin(Math.PI / 2 + angle * Math.PI / 180);

            return new Point((int)(x * radius / 2.5), (int)(y * radius / 2.5));
        }

        private Point GetHourCoordinates(int hour, int radius, int minute) {
            if (hour < 0 || hour > 23) throw new ArgumentOutOfRangeException("This mark does not exist!");
            if (hour > 11) hour -= 12;

            int angle = hour * 30 + minute / 2;

            double x = Math.Cos(Math.PI / 2 + angle * Math.PI / 180);
            double y = Math.Sin(Math.PI / 2 + angle * Math.PI / 180);

            return new Point((int)(x * radius / 4), (int)(y * radius / 4));
        }

    }
}
