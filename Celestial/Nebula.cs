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
    public class Nebula : CelestialBody
    {
        public enum Constellation { Orion, Ophiuchus }

    // C-tors
        public Nebula(string name, double distance, Constellation starGroup = Constellation.Orion)
        {
            Name = name;
            Distance = distance;
            StarGroup = starGroup;
            BodyType = BodyType.Nebula;
        }

        public Nebula() { }

        // Properties
        public Constellation StarGroup { get; set; }

        public override void drawBody(Form form)
        {
            BodyGraphic graphic = new NebulaGraphic(BodyColor);
            graphic.Location = new Point(10, Y);
            graphic.Size = new Size(100, 100);
            graphic.Type = BodyType;
            form.Controls.Add(graphic);
        }


        public override string ToString()
        {
            return String.Format(base.ToString() + "\nConstellation: {0}", StarGroup);
        }
    }
}
