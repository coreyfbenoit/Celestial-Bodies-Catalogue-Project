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
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelestialBodyGraphics;

namespace Celestial
{
    abstract public class CelestialBody
    {
        protected Point[] points;

        // Properties
        public string Name { get; set; }
        public double Distance { get; set; }
        public int Y { get; set; }  // Used to set y coordinate in form
        public Color BodyColor { get; set; }
        public BodyType BodyType { get; set; }

        // Methods
        public virtual void drawBody(Form form)
        {
            BodyGraphic graphic = new BodyGraphic(BodyColor);
            graphic.Location = new Point(10, Y);
            graphic.Size = new Size(100, 100);
            graphic.Type = BodyType;
            form.Controls.Add(graphic);
        }

        public override string ToString()
        {
            return String.Format("{0}\nDistance from sun: {1} ly", Name, Distance);
        }
    }
}
