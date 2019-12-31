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
    public enum BodyType { Star, Planet, Nebula }
    public partial class BodyGraphic : Control
    {
        public BodyGraphic(Color color)
        {
            InitializeComponent();
            BodyColor = color;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Draw body
            SolidBrush bodyBrush = new SolidBrush(BodyColor);
            Rectangle rect = new Rectangle(0, 0, 90, 90);
            pe.Graphics.FillEllipse(bodyBrush, rect);
        }

        public Color BodyColor { get; set; }

        public BodyType Type { get; set; }
    }
}
