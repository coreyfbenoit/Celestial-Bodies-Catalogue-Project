/*
 * Name: Corey Benoit
 * Final Project
 * Course: CSI255 (Fall 2019)
 * Date: 12/13/2019
 * Description: Lists celestial bodies. User may filter & add new bodies.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialBodyGraphics
{
    public partial class NebulaGraphic : BodyGraphic
    {
        public NebulaGraphic(Color color)
            : base(color)
        {
            InitializeComponent();
            BodyColor = color;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
            // Points array used to draw curve for nebula
            Point[] points = {
                   new Point(6, 10),
                   new Point(15, 5),
                   new Point(25, 10),
                   new Point(40, 5),
                   new Point(50, 15),
                   new Point(100, 18)};

            Pen pen = new Pen(Color.FromArgb(50, 0, 0, 255), 20.0f);
            pe.Graphics.DrawCurve(pen, points);

            // Offset points to draw second part of nebula
            // Offset points to draw second part of nebula
            int offset = 5;
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += 2;
                points[i].Y += offset;
                offset += 4;
            }
            pen = new Pen(Color.FromArgb(100, 20, 200, 0), 30.0f);
            pe.Graphics.DrawCurve(pen, points);

            // Draw body
            SolidBrush bodyBrush = new SolidBrush(Color.FromArgb(80, 200,20,100));
            Rectangle rect = new Rectangle(0, 0, 40, 25);
            pe.Graphics.FillEllipse(bodyBrush, rect);
        }
    }
}
