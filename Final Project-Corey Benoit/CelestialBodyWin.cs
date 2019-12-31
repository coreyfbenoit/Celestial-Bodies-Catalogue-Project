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
using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using Celestial;
using CelestialBodyGraphics;
using System.Xml.Serialization;

namespace Final_Project_Corey_Benoit
{
    // Delegate for the filter actions
    delegate bool FilterAction(CelestialBody body);

    public partial class CelestialBodyWin : Form
    {
        private const string BodiesFilename = "bodies.dat";
        List<CelestialBody> bodiesList = new List<CelestialBody>();  // Backup to re-initialize after filtration
        CelestialBody[] bodiesDisplay;  // Used for filtration

        // Initialize celestial bodies when testing
        //CelestialBody[] testBodies = {
        //        new Star("TEST", 0.0),
        //        new Star("Test", 0.0, StarType.Supergiant),
        //        new Star("Test", 0.0, StarType.Neutron),
        //        new Planet("testy", 0.0, 2),
        //        new Nebula("testing", 0.0, Nebula.Constellation.Ophiuchus)
        //        };


        public CelestialBodyWin()
        {
            InitializeComponent();

            // Add option for all bodies in combo box & set as default selection
            TypeFilterBox.Items.Add("All");
            TypeFilterBox.SelectedItem = "All";

            // Add all celestial bodies to bodies combobox
            IEnumerable<BodyType> bodies = Enum.GetValues(typeof(BodyType)).Cast<BodyType>();
            foreach (BodyType body in bodies)
                TypeFilterBox.Items.Add(body);

            // Add all celestial bodies to new bodies combobox
            bodies = Enum.GetValues(typeof(BodyType)).Cast<BodyType>();
            foreach (BodyType body in bodies)
                NewTypeBox.Items.Add(body);

            // Add all star types to new star type combobox
            IEnumerable<StarType> stars = Enum.GetValues(typeof(StarType)).Cast<StarType>();
            stars = Enum.GetValues(typeof(StarType)).Cast<StarType>();
            foreach (StarType star in stars)
                NewStarTypeBox.Items.Add(star);

            // Add all constellation types to new constellation combobox
            IEnumerable<Nebula.Constellation> starGroups = Enum.GetValues(typeof(Nebula.Constellation)).Cast<Nebula.Constellation>();
            foreach (Nebula.Constellation group in starGroups)
                StarGroupBox.Items.Add(group);
        }

        // Load bodies
        private void LoadBodies()
        {
            FileStream bodyFile = null;

            try
            {
                bodyFile = new FileStream(BodiesFilename, FileMode.Open, FileAccess.Read);

                XmlSerializer bodyReader =
                    new XmlSerializer(
                        typeof(List<CelestialBody>),
                        new Type[] { typeof(Star), typeof(Planet), typeof(Nebula) });
                bodiesList = (List<CelestialBody>)bodyReader.Deserialize(bodyFile);

                bodiesDisplay = bodiesList.ToArray();
            }
            catch (SerializationException serEx)
            {
                MessageBox.Show("Error loading bodies: " + serEx.Message);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Error loading bodies: " + ioEx.Message);
            }
            finally
            {
                if (bodyFile != null)
                    bodyFile.Close();
            }
        }

        // Save bodies
        private void SaveBodies()
        {
            FileStream bodiesFile = null;

            try
            {
                bodiesFile = new FileStream(BodiesFilename, FileMode.Create, FileAccess.Write);

                XmlSerializer bodiesWriter =
                    new XmlSerializer(
                        bodiesList.GetType(),
                        new Type[] { typeof(Star), typeof(Planet), typeof(Nebula) });
                bodiesWriter.Serialize(bodiesFile, bodiesList);
            }
            catch (SerializationException serEx)
            {
                MessageBox.Show("Error saving bodies: " + serEx.Message);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Error saving bodies: " + ioEx.Message);
            }
            finally
            {
                if (bodiesFile != null)
                    bodiesFile.Close();
            }
        }

        // Add bodies & their labels to the form 
        private void ShowBodies()
        {
            int y = 5;
            Label label;
            try
            {
                foreach (CelestialBody body in bodiesDisplay)
                {
                    // Add body to form
                    body.Y = y;
                    body.drawBody(this);

                    // Add label to body in form
                    label = new Label();
                    label.Location = new Point(115, y + 15);
                    label.Text = body.ToString();
                    label.AutoSize = true;
                    label.ForeColor = Color.LightSkyBlue;
                    this.Controls.Add(label);

                    // Update displacement for graphics and labels
                    y += 105;
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Error saving bodies: " + ioEx.Message);
            }
            finally
            {

            }
        }

        private void SunDistanceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solution referenced from: https://www.youtube.com/watch?v=v64nmC1pmls
            // Ensures only decimals & floating point numbers can be entered into the box

            char c = e.KeyChar;

            if (c == 46 && SunDistanceBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(c) && c != 8 && c != 46)
                e.Handled = true;
        }

        private void NewTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewTypeBox.SelectedItem.ToString() == "Star")
            {
                // Enable all star fields
                NewStarTypeBox.Enabled = true;
                NewStarTypeLabel.Enabled = true;

                // Disable non-star fields
                MoonsNumBox.Enabled = false;
                MoonsNumLabel.Enabled = false;
                StarGroupLabel.Enabled = false;
                StarGroupBox.Enabled = false;
            }
            else if (NewTypeBox.SelectedItem.ToString() == "Planet")
            {
                // Enable all planet fields
                MoonsNumBox.Enabled = true;
                MoonsNumLabel.Enabled = true;

                // Disable non-planet fields
                NewStarTypeBox.Enabled = false;
                NewStarTypeLabel.Enabled = false;
                StarGroupLabel.Enabled = false;
                StarGroupBox.Enabled = false;
            }
            else if (NewTypeBox.SelectedItem.ToString() == "Nebula")
            {
                // Enable all nebula fields
                StarGroupLabel.Enabled = true;
                StarGroupBox.Enabled = true;

                // Disable non-nebula fields
                NewStarTypeBox.Enabled = false;
                NewStarTypeLabel.Enabled = false;
                MoonsNumBox.Enabled = false;
                MoonsNumLabel.Enabled = false;
            }
        }

        private void AddBodyButton_Click(object sender, EventArgs e)
        {
            CelestialBody body;
            double distance = double.Parse(SunDistanceBox.Text);

            // Instantiates a new CelestialBody type based off of the selection in the new type box
            // then adds the body to the bodies list
            if (NewTypeBox.SelectedItem.ToString() == "Star")
            {
                var type = (StarType)Enum.Parse(typeof(StarType), NewStarTypeBox.Text);
                body = new Star(NameBox.Text, distance, type);
                bodiesList.Add(body);
            }
            else if (NewTypeBox.SelectedItem.ToString() == "Planet")
            {
                body = new Planet(NameBox.Text, distance, (int)MoonsNumBox.Value);
                bodiesList.Add(body);
            }
            else if (NewTypeBox.SelectedItem.ToString() == "Nebula")
            {
                var type = (Nebula.Constellation)Enum.Parse(typeof(Nebula.Constellation), StarGroupBox.Text);
                body = new Nebula(NameBox.Text, distance, type);
                bodiesList.Add(body);
            }
        }

        private void TypeFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CelestialBodyWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On closing the program, save bodies to xml file
            SaveBodies();
        }

        private void CelestialBodyWin_Load(object sender, EventArgs e)
        {
            // On loading the program, load bodies to list & show them in form
            LoadBodies();
            ShowBodies();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Re-initialize bodies to dislplay using the backup body list
            bodiesDisplay = bodiesList.ToArray();
            TypeFilterLabel.Text = bodiesDisplay[0].Name;

            // Filtration lambdas
            Predicate<CelestialBody> starFilter = x => x.GetType() == typeof(Star);
            Predicate<CelestialBody> planetFilter = x => x.GetType() == typeof(Planet);
            Predicate<CelestialBody> NebulaFilter = x => x.GetType() == typeof(Nebula);

            // Remove all body graphics from form
            foreach (Control item in this.Controls.OfType<BodyGraphic>())
                this.Controls.Remove(item);
            foreach (Control item in this.Controls.OfType<BodyGraphic>())
                this.Controls.Remove(item);

            // Remove all body labels from form
            foreach (Control item in this.Controls.OfType<Label>())
                this.Controls.Remove(item);
            foreach (Control item in this.Controls.OfType<Label>())
                this.Controls.Remove(item);
            foreach (Control item in this.Controls.OfType<Label>())
                this.Controls.Remove(item);

            // Filter array for displaying bodies using given lambdas. If all is selected, filter nothing
            string selected = TypeFilterBox.SelectedItem.ToString();
            switch (selected)
            {
                case "Star":
                    bodiesDisplay = Array.FindAll(bodiesDisplay, starFilter);
                    break;
                case "Planet":
                    bodiesDisplay = Array.FindAll(bodiesDisplay, planetFilter);
                    break;
                case "Nebula":
                    bodiesDisplay = Array.FindAll(bodiesDisplay, NebulaFilter);
                    break;
                case "All":
                    break;
            }

            // Add bodies to the form
            ShowBodies();
        }
    }
}
