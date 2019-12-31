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
using Celestial;
using CelestialBodyGraphics;

namespace Celestial
{
    public class Planet : CelestialBody
    {
        // C-tors
        public Planet(string name, double distance, int moons = 0)
        {
            Name = name;
            Distance = distance;
            Moons = moons;
        }

        public Planet() { }

        // Properties
        public int Moons { get; set; }

        public override string ToString()
        {
            return String.Format(base.ToString() + "\nNumber of Moons: " + Moons);
        }

        public override void drawBody(Form form)
        {
            BodyColor = Color.LightSlateGray;

            base.drawBody(form);

            //BodyColor = Color.Blue;

            //BodyGraphic graphic = new BodyGraphic(BodyColor);
            //graphic.Location = new Point(10, Y);
            //graphic.Size = new Size(80, 80);
            //graphic.Type = BodyType;
            //form.Controls.Add(graphic);
        }
    }
}
