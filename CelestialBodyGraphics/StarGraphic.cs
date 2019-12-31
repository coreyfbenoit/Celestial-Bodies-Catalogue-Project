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
    public partial class StarGraphic : BodyGraphic
    {
        public StarGraphic(Color color)
            :base(color)
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Draw star halo
            SolidBrush bodyBrush = new SolidBrush(Color.FromArgb(50, 255, 255, 0));
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            pe.Graphics.FillEllipse(bodyBrush, rect);
        }
    }
}
