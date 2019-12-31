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
    public partial class PlanetGraphic : BodyGraphic
    {
        public PlanetGraphic(Color color)
            :base(color)
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //Point[] points = {
            //       new Point(6, 10),
            //       new Point(15, 5),
            //       new Point(25, 10),
            //       new Point(40, 5),
            //       new Point(50, 15),
            //       new Point(100, 18)};

            //Pen pen = new Pen(Color.FromArgb(50, 0, 0, 255), 20.0f);
            //pe.Graphics.DrawCurve(pen, points);

            // Draw body
            SolidBrush bodyBrush = new SolidBrush(BodyColor);
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            pe.Graphics.FillEllipse(bodyBrush, rect);
        }

        public Color BodyColor { get; set; }
    }
}
