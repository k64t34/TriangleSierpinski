using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TriangleSierpinski
{
    enum hTextAlignment { None,Left,Right };
    enum vTextAlignment { None,Up,Down};
    public partial class Form1 : Form
    {
        public Bitmap Img;
        public Graphics Canvas;
        public Pen pen = new Pen(Color.Blue);
        public Font font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Regular);
        public SolidBrush brush = new SolidBrush(Color.Black);
        //StringFormat Textformat = new StringFormat();
        public int Ax, Ay, Bx, By, Cx, Cy, StartX, StartY, CurentX, CurentY;
        int LoopRefreshCount = 10;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            status_button_start = false;
        }

        public bool status_button_start;
        public delegate void delegatePictureBoxRefresh();
        public delegatePictureBoxRefresh PictureBoxRefresh;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status_button_start=false;
            PictureBoxRefresh = new delegatePictureBoxRefresh(ControlPic.Refresh);
            #region Transofrm start picture            
            Img = new Bitmap(ControlPic.Width, ControlPic.Height);
            Canvas = Graphics.FromImage(Img);
            Canvas.DrawImage(ControlPic.Image,0,0);
            ControlPic.Image = Img;
            //Textformat.Alignment = StringAlignment.Near;

            #endregion
            //Canvas = Graphics.FromImage(ControlPic.Image);

            DrawAxis();
        }
        private void DrawAxis() {
            #region Draw axis name $ size
            int axis_shift = 5;
            Canvas.DrawLine(pen, 0, axis_shift, ControlPic.Width - 1, axis_shift);
            Canvas.DrawLine(pen, ControlPic.Width - 2 * axis_shift, 0, ControlPic.Width - 1, axis_shift);
            Canvas.DrawLine(pen, ControlPic.Width - 2 * axis_shift, axis_shift + axis_shift, ControlPic.Width - 1, axis_shift);
            MyDrawString(Canvas, "X", font, brush, ControlPic.Width, axis_shift, hTextAlignment.Left, vTextAlignment.Down);
            MyDrawString(Canvas, ControlPic.Width.ToString(), font, brush, ControlPic.Width, axis_shift + axis_shift + (int)font.SizeInPoints, hTextAlignment.Left, vTextAlignment.Down);
            //Draw axis Y
            Canvas.DrawLine(pen, axis_shift, 0, axis_shift, ControlPic.Height);
            Canvas.DrawLine(pen, 0, ControlPic.Height - 2 * axis_shift, axis_shift, ControlPic.Height - 1);
            Canvas.DrawLine(pen, axis_shift + axis_shift, ControlPic.Height - 2 * axis_shift, axis_shift, ControlPic.Height - 1);
            MyDrawString(Canvas, "Y", font, brush, axis_shift, ControlPic.Height, hTextAlignment.Right, vTextAlignment.Up);
            MyDrawString(Canvas, ControlPic.Height.ToString(), font, brush, axis_shift, ControlPic.Height - axis_shift - axis_shift - (int)font.SizeInPoints, hTextAlignment.Right, vTextAlignment.Up);
            //Draw start axis
            Canvas.DrawString("0", font, brush, axis_shift, axis_shift);
            #endregion
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (status_button_start) 
            {
                status_button_start = false;
                button_start.BackColor = Color.Lime;
                button_start.Text = "Старт";
                Thread.Sleep(1000);
                ControlPic.Refresh();
            }
            else
            {
                Img = new Bitmap(ControlPic.Width, ControlPic.Height);
                Canvas = Graphics.FromImage(Img);
                ControlPic.Image = Img;
                DrawAxis();
                status_button_start = true;
                button_start.BackColor = Color.Red;
                button_start.Text = "Стоп";

                Ax = Convert.ToInt32(textBox_PointAx.Text);
                Ay = Convert.ToInt32(textBox_PointAy.Text);
                Bx = Convert.ToInt32(textBox_PointBx.Text);
                By = Convert.ToInt32(textBox_PointBy.Text);
                Cx = Convert.ToInt32(textBox_PointCx.Text);
                Cy = Convert.ToInt32(textBox_PointCy.Text);
                StartX = Convert.ToInt32(textBox_PointStartX.Text);
                StartY = Convert.ToInt32(textBox_PointStartY.Text);
                LoopRefreshCount = Convert.ToInt32(textBox_LoopRefreshCount.Text);

                Canvas.DrawLine(pen, Ax, Ay, Bx, By);
                Canvas.DrawLine(pen, Bx, By, Cx, Cy);
                Canvas.DrawLine(pen, Cx, Cy, Ax, Ay);
                Canvas.DrawString("A", font, brush, Ax, Ay);
                Canvas.DrawString("B", font, brush, Bx, By);
                Canvas.DrawString("C", font, brush, Cx, Cy);

                
                ControlPic.Refresh();
                Loop();
            }
        }
        async void Loop()
        {
            await Task.Run(() =>
            {
                int LoopCounter = 0;
                
                int LoopRefreshCounter = 0;
                Random rnd = new Random();
                int X= StartX, Y=StartY,Xnew,Ynew,Px=0,Py=0;
                int TrianglePoint;                

                while (status_button_start) 
                {
                    //Select triangle point
                    TrianglePoint=rnd.Next(3);
                    if (TrianglePoint == 0)         { Px = Ax; Py = Ay; }
                    else if (TrianglePoint == 1)    { Px = Bx; Py = By; }
                    else if (TrianglePoint == 2)    { Px = Cx; Py = Cy; }
                    //Calculate new point
                    Xnew = Decimal.ToInt32((Px + X) / 2);
                    Ynew = Decimal.ToInt32((Py + Y) / 2);
                    Img.SetPixel(X, Y, Color.Black);                    
                    X = Xnew; Y = Ynew;
                    Img.SetPixel(X, Y, Color.Red);
                    

                    LoopRefreshCounter++;
                    if (LoopRefreshCounter == LoopRefreshCount)
                    {
                        LoopRefreshCounter = 0;
                        LoopCounter += LoopRefreshCount;
                        Invoke((MethodInvoker)(()=>
                        { label_LoopCounter.Text = LoopCounter.ToString(); }                        
                        ));
                        Invoke((MethodInvoker)(() =>
                        { ControlPic.Refresh(); }
                        ));

                        //Invoke(PictureBoxRefresh);
                    }
                }
            }
            );
        }
        private void MyDrawString(Graphics Canvas,String Text,Font font,Brush brush,int X,int Y, hTextAlignment hAlignment,vTextAlignment vAlignment) {
            RectangleF drawRect;
            Size proposedSize = new Size(0, 0);            
            proposedSize = TextRenderer.MeasureText(Text, font);
            if (hAlignment == hTextAlignment.Left) X -= proposedSize.Width;
            else if (hAlignment == hTextAlignment.Right) X += 0;// proposedSize.Width;
            if (vAlignment == vTextAlignment.Down) Y += 0;// proposedSize.Height;
            else if (vAlignment == vTextAlignment.Up) Y -= proposedSize.Height;
            drawRect = new RectangleF(X,Y,proposedSize.Width, proposedSize.Height);
            Canvas.DrawString(Text, font, brush, drawRect);

        }
    }
}
