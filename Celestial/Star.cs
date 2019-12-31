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
using System.Reflection;
using CelestialBodyGraphics;

namespace Celestial
{
    public enum StarType { RedGiant, WhiteDwarf, RedDwarf, Neutron, Supergiant }

    public class Star : CelestialBody
    {
        // C-tors
        public Star(string name, double distance, StarType type = StarType.RedDwarf)
        {
            Name = name;
            Distance = distance;
            Type = type;
            BodyType = BodyType.Star;
            setColor(type);
        }
        public Star() 
        {
            
        }

        // Properties
        public StarType Type { get; set; }

        private void setColor(StarType type)
        {
            // Set color based off of star type
            switch (type)
            {
                case StarType.RedGiant:
                    BodyColor = Color.OrangeRed;
                    break;
                case StarType.WhiteDwarf:
                    BodyColor = Color.LightSteelBlue;
                    break;
                case StarType.RedDwarf:
                    BodyColor = Color.DarkRed;
                    break;
                case StarType.Neutron:
                    BodyColor = Color.Purple;
                    break;
                case StarType.Supergiant:
                    BodyColor = Color.DarkCyan;
                    break;
            }
        }

        // Draw Star
        public override void drawBody(Form form)
        {
            setColor(Type);

            BodyGraphic graphic = new StarGraphic(BodyColor);
            graphic.Location = new Point(10, Y);
            graphic.Size = new Size(100, 100);
            graphic.Type = BodyType;
            form.Controls.Add(graphic);
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "\nStar Type: " + Type);
        }
    }
}
