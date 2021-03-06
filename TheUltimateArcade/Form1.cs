﻿/// Designed By: Sam Wyatt
/// October 19 2016
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class theUltimateArcade : Form
    {
        public theUltimateArcade()
        {
            InitializeComponent();
            // Initialize the user-defined button, 
            // including defining handler for Click message, 
            // location and size.

            //snake game button
            myButtonObject myButton1 = new myButtonObject();
            EventHandler myHandler = new EventHandler(myButton1_Click);
            myButton1.Click += myHandler;
            //myButton1.MouseHover += myHandler;
            myButton1.Location = new System.Drawing.Point(120, 360);
            myButton1.Size = new System.Drawing.Size(101, 101);
            this.Controls.Add(myButton1);

            //pong game button
            myButtonObject myButton2 = new myButtonObject();
            EventHandler myHandler2 = new EventHandler(myButton2_Click);
            myButton2.Click += myHandler2;
            myButton2.Location = new System.Drawing.Point(330, 360);
            myButton2.Size = new System.Drawing.Size(101, 101);
            this.Controls.Add(myButton2);

            //pac man game button
            myButtonObject myButton3 = new myButtonObject();
            EventHandler myHandler3 = new EventHandler(myButton3_Click);
            myButton3.Click += myHandler3;
            myButton3.Location = new System.Drawing.Point(535, 360);
            myButton3.Size = new System.Drawing.Size(101, 101);
            this.Controls.Add(myButton3);

            timer1.Start();
        }

        public class myButtonObject : UserControl
        {
            // Draw the buttons. 
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Silver, 4);
                SolidBrush myBrush = new SolidBrush(Color.FromArgb(205, 0, 0));
                SolidBrush myBrush2 = new SolidBrush(Color.Red);

                Point[] shape = { new Point(10, 10), new Point(10, 0), new Point(90, 0), new Point(90, 10), new Point(100, 10),
                new Point(100,90), new Point(90,90), new Point(90, 100), new Point(10, 100), new Point(10,90), new Point(0, 90),
                new Point(0,10)};
                graphics.FillPolygon(myBrush, shape);
                graphics.DrawPolygon(myPen, shape);
                myPen.Dispose();
                myBrush.Dispose();
            }
        }
        
        private void myButton1_Click(object sender, EventArgs e)
        {
            Process.Start("Snake Game.exe");
            timer1.Stop();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            Process.Start("Pong.exe");
            timer1.Stop();
        }
                       
        private void myButton3_Click(object sender, EventArgs e)
        {
            Process.Start("AnimatedGameSummative.exe");
            timer1.Stop();
        }

        private void theUltimateArcade_Paint(object sender, PaintEventArgs e)
        {
            Graphics draw = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkSlateGray);
            Pen pen = new Pen(Color.Red, 3);
            Pen pen2 = new Pen(Color.Silver, 3);

            draw.FillRectangle(brush, 30, 20, 685, 325);
            draw.DrawRectangle(pen, 30, 20, 685, 325);

            draw.DrawRectangle(pen2, 85, 100, 170, 141);
            draw.DrawRectangle(pen2, 290, 100, 180, 141);
            draw.DrawRectangle(pen2, 495, 100, 170, 141);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (titleLabel.ForeColor == Color.DarkSlateGray)
            {
                titleLabel.ForeColor = Color.Silver;
                timer1.Interval = 750;
            }

            else
            {
                titleLabel.ForeColor = Color.DarkSlateGray;
                timer1.Interval = 750;
            }
        }
    }
}
