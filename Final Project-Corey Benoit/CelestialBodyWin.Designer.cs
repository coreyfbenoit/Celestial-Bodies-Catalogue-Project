namespace Final_Project_Corey_Benoit
{
    partial class CelestialBodyWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeFilterBox = new System.Windows.Forms.ComboBox();
            this.TypeFilterLabel = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.BodySelectionBox = new System.Windows.Forms.GroupBox();
            this.NewBodyBox = new System.Windows.Forms.GroupBox();
            this.AddBodyButton = new System.Windows.Forms.Button();
            this.MoonsNumBox = new System.Windows.Forms.NumericUpDown();
            this.MoonsNumLabel = new System.Windows.Forms.Label();
            this.StarGroupLabel = new System.Windows.Forms.Label();
            this.StarGroupBox = new System.Windows.Forms.ComboBox();
            this.SunDistanceLabel = new System.Windows.Forms.Label();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.SunDistanceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NewStarTypeLabel = new System.Windows.Forms.Label();
            this.NewTypeLabel = new System.Windows.Forms.Label();
            this.NewStarTypeBox = new System.Windows.Forms.ComboBox();
            this.NewTypeBox = new System.Windows.Forms.ComboBox();
            this.BodySelectionBox.SuspendLayout();
            this.NewBodyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoonsNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeFilterBox
            // 
            this.TypeFilterBox.FormattingEnabled = true;
            this.TypeFilterBox.Location = new System.Drawing.Point(130, 31);
            this.TypeFilterBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeFilterBox.Name = "TypeFilterBox";
            this.TypeFilterBox.Size = new System.Drawing.Size(180, 29);
            this.TypeFilterBox.TabIndex = 1;
            this.TypeFilterBox.SelectedIndexChanged += new System.EventHandler(this.TypeFilterBox_SelectedIndexChanged);
            // 
            // TypeFilterLabel
            // 
            this.TypeFilterLabel.AutoSize = true;
            this.TypeFilterLabel.Location = new System.Drawing.Point(40, 39);
            this.TypeFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeFilterLabel.Name = "TypeFilterLabel";
            this.TypeFilterLabel.Size = new System.Drawing.Size(82, 21);
            this.TypeFilterLabel.TabIndex = 2;
            this.TypeFilterLabel.Text = "Type Filter";
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(218, 44);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(0, 21);
            this.TestLabel.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(167, 96);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(135, 40);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // BodySelectionBox
            // 
            this.BodySelectionBox.BackColor = System.Drawing.SystemColors.Control;
            this.BodySelectionBox.Controls.Add(this.TypeFilterBox);
            this.BodySelectionBox.Controls.Add(this.FilterButton);
            this.BodySelectionBox.Controls.Add(this.TypeFilterLabel);
            this.BodySelectionBox.Location = new System.Drawing.Point(658, 44);
            this.BodySelectionBox.Name = "BodySelectionBox";
            this.BodySelectionBox.Size = new System.Drawing.Size(318, 154);
            this.BodySelectionBox.TabIndex = 7;
            this.BodySelectionBox.TabStop = false;
            this.BodySelectionBox.Text = "Display Bodies";
            // 
            // NewBodyBox
            // 
            this.NewBodyBox.BackColor = System.Drawing.SystemColors.Control;
            this.NewBodyBox.Controls.Add(this.AddBodyButton);
            this.NewBodyBox.Controls.Add(this.MoonsNumBox);
            this.NewBodyBox.Controls.Add(this.MoonsNumLabel);
            this.NewBodyBox.Controls.Add(this.StarGroupLabel);
            this.NewBodyBox.Controls.Add(this.StarGroupBox);
            this.NewBodyBox.Controls.Add(this.SunDistanceLabel);
            this.NewBodyBox.Controls.Add(this.NewNameLabel);
            this.NewBodyBox.Controls.Add(this.SunDistanceBox);
            this.NewBodyBox.Controls.Add(this.NameBox);
            this.NewBodyBox.Controls.Add(this.NewStarTypeLabel);
            this.NewBodyBox.Controls.Add(this.NewTypeLabel);
            this.NewBodyBox.Controls.Add(this.NewStarTypeBox);
            this.NewBodyBox.Controls.Add(this.NewTypeBox);
            this.NewBodyBox.Location = new System.Drawing.Point(658, 297);
            this.NewBodyBox.Name = "NewBodyBox";
            this.NewBodyBox.Size = new System.Drawing.Size(310, 334);
            this.NewBodyBox.TabIndex = 8;
            this.NewBodyBox.TabStop = false;
            this.NewBodyBox.Text = "New Body";
            // 
            // AddBodyButton
            // 
            this.AddBodyButton.Location = new System.Drawing.Point(206, 271);
            this.AddBodyButton.Name = "AddBodyButton";
            this.AddBodyButton.Size = new System.Drawing.Size(96, 34);
            this.AddBodyButton.TabIndex = 13;
            this.AddBodyButton.Text = "Add Body";
            this.AddBodyButton.UseVisualStyleBackColor = true;
            this.AddBodyButton.Click += new System.EventHandler(this.AddBodyButton_Click);
            // 
            // MoonsNumBox
            // 
            this.MoonsNumBox.Enabled = false;
            this.MoonsNumBox.Location = new System.Drawing.Point(184, 200);
            this.MoonsNumBox.Name = "MoonsNumBox";
            this.MoonsNumBox.Size = new System.Drawing.Size(120, 29);
            this.MoonsNumBox.TabIndex = 12;
            this.MoonsNumBox.UseWaitCursor = true;
            // 
            // MoonsNumLabel
            // 
            this.MoonsNumLabel.AutoSize = true;
            this.MoonsNumLabel.Enabled = false;
            this.MoonsNumLabel.Location = new System.Drawing.Point(34, 204);
            this.MoonsNumLabel.Name = "MoonsNumLabel";
            this.MoonsNumLabel.Size = new System.Drawing.Size(138, 21);
            this.MoonsNumLabel.TabIndex = 11;
            this.MoonsNumLabel.Text = "Number of Moons";
            // 
            // StarGroupLabel
            // 
            this.StarGroupLabel.AutoSize = true;
            this.StarGroupLabel.Enabled = false;
            this.StarGroupLabel.Location = new System.Drawing.Point(76, 239);
            this.StarGroupLabel.Name = "StarGroupLabel";
            this.StarGroupLabel.Size = new System.Drawing.Size(101, 21);
            this.StarGroupLabel.TabIndex = 10;
            this.StarGroupLabel.Text = "Constellation";
            // 
            // StarGroupBox
            // 
            this.StarGroupBox.Enabled = false;
            this.StarGroupBox.FormattingEnabled = true;
            this.StarGroupBox.Location = new System.Drawing.Point(184, 236);
            this.StarGroupBox.Name = "StarGroupBox";
            this.StarGroupBox.Size = new System.Drawing.Size(121, 29);
            this.StarGroupBox.TabIndex = 9;
            // 
            // SunDistanceLabel
            // 
            this.SunDistanceLabel.AutoSize = true;
            this.SunDistanceLabel.Location = new System.Drawing.Point(14, 168);
            this.SunDistanceLabel.Name = "SunDistanceLabel";
            this.SunDistanceLabel.Size = new System.Drawing.Size(164, 21);
            this.SunDistanceLabel.TabIndex = 8;
            this.SunDistanceLabel.Text = "Distance from the Sun";
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(122, 132);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(52, 21);
            this.NewNameLabel.TabIndex = 7;
            this.NewNameLabel.Text = "Name";
            // 
            // SunDistanceBox
            // 
            this.SunDistanceBox.Location = new System.Drawing.Point(206, 165);
            this.SunDistanceBox.Name = "SunDistanceBox";
            this.SunDistanceBox.Size = new System.Drawing.Size(100, 29);
            this.SunDistanceBox.TabIndex = 5;
            this.SunDistanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SunDistanceBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(206, 129);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 29);
            this.NameBox.TabIndex = 4;
            // 
            // NewStarTypeLabel
            // 
            this.NewStarTypeLabel.AutoSize = true;
            this.NewStarTypeLabel.Enabled = false;
            this.NewStarTypeLabel.Location = new System.Drawing.Point(104, 99);
            this.NewStarTypeLabel.Name = "NewStarTypeLabel";
            this.NewStarTypeLabel.Size = new System.Drawing.Size(75, 21);
            this.NewStarTypeLabel.TabIndex = 3;
            this.NewStarTypeLabel.Text = "Star Type";
            // 
            // NewTypeLabel
            // 
            this.NewTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.NewTypeLabel.Name = "NewTypeLabel";
            this.NewTypeLabel.Size = new System.Drawing.Size(100, 23);
            this.NewTypeLabel.TabIndex = 14;
            // 
            // NewStarTypeBox
            // 
            this.NewStarTypeBox.Enabled = false;
            this.NewStarTypeBox.FormattingEnabled = true;
            this.NewStarTypeBox.Location = new System.Drawing.Point(184, 95);
            this.NewStarTypeBox.Name = "NewStarTypeBox";
            this.NewStarTypeBox.Size = new System.Drawing.Size(121, 29);
            this.NewStarTypeBox.TabIndex = 1;
            // 
            // NewTypeBox
            // 
            this.NewTypeBox.FormattingEnabled = true;
            this.NewTypeBox.Location = new System.Drawing.Point(184, 60);
            this.NewTypeBox.Name = "NewTypeBox";
            this.NewTypeBox.Size = new System.Drawing.Size(121, 29);
            this.NewTypeBox.TabIndex = 0;
            this.NewTypeBox.SelectedIndexChanged += new System.EventHandler(this.NewTypeBox_SelectedIndexChanged);
            // 
            // CelestialBodyWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(988, 830);
            this.Controls.Add(this.NewBodyBox);
            this.Controls.Add(this.BodySelectionBox);
            this.Controls.Add(this.TestLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CelestialBodyWin";
            this.Text = "CelestialBodyWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CelestialBodyWin_FormClosing);
            this.Load += new System.EventHandler(this.CelestialBodyWin_Load);
            this.BodySelectionBox.ResumeLayout(false);
            this.BodySelectionBox.PerformLayout();
            this.NewBodyBox.ResumeLayout(false);
            this.NewBodyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoonsNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TypeFilterBox;
        private System.Windows.Forms.Label TypeFilterLabel;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.GroupBox BodySelectionBox;
        private System.Windows.Forms.GroupBox NewBodyBox;
        private System.Windows.Forms.TextBox SunDistanceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NewStarTypeLabel;
        private System.Windows.Forms.Label NewTypeLabel;
        private System.Windows.Forms.ComboBox NewStarTypeBox;
        private System.Windows.Forms.ComboBox NewTypeBox;
        private System.Windows.Forms.Label SunDistanceLabel;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.Label MoonsNumLabel;
        private System.Windows.Forms.Label StarGroupLabel;
        private System.Windows.Forms.ComboBox StarGroupBox;
        private System.Windows.Forms.NumericUpDown MoonsNumBox;
        private System.Windows.Forms.Button AddBodyButton;
    }
}

