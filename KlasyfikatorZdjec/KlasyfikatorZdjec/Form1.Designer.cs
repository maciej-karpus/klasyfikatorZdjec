namespace KlasyfikatorZdjec
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.directoryPicker = new System.Windows.Forms.Button();
            this.chosenDirectoryBox = new System.Windows.Forms.TextBox();
            this.refreshImagesButton = new System.Windows.Forms.Button();
            this.chosenDirectoryLabel = new System.Windows.Forms.Label();
            this.startClassificationButton = new System.Windows.Forms.Button();
            this.resolutionCheckBox = new System.Windows.Forms.CheckBox();
            this.formatCheckBox = new System.Windows.Forms.CheckBox();
            this.cameraCheckBox = new System.Windows.Forms.CheckBox();
            this.isoCheckBox = new System.Windows.Forms.CheckBox();
            this.photosFromPolandCheckBox = new System.Windows.Forms.CheckBox();
            this.belowSeaLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.peopleCheckBox = new System.Windows.Forms.CheckBox();
            this.geoCheckBox = new System.Windows.Forms.CheckBox();
            this.portraitCheckBox = new System.Windows.Forms.CheckBox();
            this.mainColourCheckBox = new System.Windows.Forms.CheckBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.blackWhiteCheckBox = new System.Windows.Forms.CheckBox();
            this.photosFromAbroadCheckBox = new System.Windows.Forms.CheckBox();
            this.overSeaLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.isoComboBox = new System.Windows.Forms.ComboBox();
               this.settingsEditor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(336, 13);
            this.listView.Name = "listView";
               this.listView.Size = new System.Drawing.Size(389, 460);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // directoryPicker
            // 
               this.directoryPicker.Location = new System.Drawing.Point(15, 63);
            this.directoryPicker.Name = "directoryPicker";
               this.directoryPicker.Size = new System.Drawing.Size(134, 23);
            this.directoryPicker.TabIndex = 4;
               this.directoryPicker.Text = "Zmień lokację";
            this.directoryPicker.UseVisualStyleBackColor = true;
            this.directoryPicker.Click += new System.EventHandler(this.directoryPicker_Click);
            // 
            // chosenDirectoryBox
            // 
            this.chosenDirectoryBox.Enabled = false;
            this.chosenDirectoryBox.Location = new System.Drawing.Point(12, 37);
            this.chosenDirectoryBox.Name = "chosenDirectoryBox";
            this.chosenDirectoryBox.Size = new System.Drawing.Size(318, 20);
            this.chosenDirectoryBox.TabIndex = 5;
            // 
            // refreshImagesButton
            // 
               this.refreshImagesButton.Location = new System.Drawing.Point(190, 63);
            this.refreshImagesButton.Name = "refreshImagesButton";
               this.refreshImagesButton.Size = new System.Drawing.Size(140, 23);
            this.refreshImagesButton.TabIndex = 6;
            this.refreshImagesButton.Text = "Odśwież";
            this.refreshImagesButton.UseVisualStyleBackColor = true;
            this.refreshImagesButton.Click += new System.EventHandler(this.refreshImagesButton_Click);
            // 
            // chosenDirectoryLabel
            // 
            this.chosenDirectoryLabel.AutoSize = true;
            this.chosenDirectoryLabel.Location = new System.Drawing.Point(12, 13);
            this.chosenDirectoryLabel.Name = "chosenDirectoryLabel";
            this.chosenDirectoryLabel.Size = new System.Drawing.Size(109, 13);
            this.chosenDirectoryLabel.TabIndex = 7;
            this.chosenDirectoryLabel.Text = "Wybrany folder zdjęć:";
            // 
            // startClassificationButton
            // 
               this.startClassificationButton.Location = new System.Drawing.Point(190, 92);
            this.startClassificationButton.Name = "startClassificationButton";
            this.startClassificationButton.Size = new System.Drawing.Size(140, 23);
            this.startClassificationButton.TabIndex = 13;
            this.startClassificationButton.Text = "Rozpocznij klasyfikację";
            this.startClassificationButton.UseVisualStyleBackColor = true;
            this.startClassificationButton.Click += new System.EventHandler(this.startClassificationButton_Click);
            // 
            // resolutionCheckBox
            // 
            this.resolutionCheckBox.AutoSize = true;
               this.resolutionCheckBox.Location = new System.Drawing.Point(30, 145);
            this.resolutionCheckBox.Name = "resolutionCheckBox";
            this.resolutionCheckBox.Size = new System.Drawing.Size(94, 17);
            this.resolutionCheckBox.TabIndex = 14;
            this.resolutionCheckBox.Text = "Rozdzielczość";
            this.resolutionCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatCheckBox
            // 
            this.formatCheckBox.AutoSize = true;
               this.formatCheckBox.Location = new System.Drawing.Point(30, 174);
            this.formatCheckBox.Name = "formatCheckBox";
            this.formatCheckBox.Size = new System.Drawing.Size(58, 17);
            this.formatCheckBox.TabIndex = 15;
            this.formatCheckBox.Text = "Format";
            this.formatCheckBox.UseVisualStyleBackColor = true;
            // 
            // cameraCheckBox
            // 
            this.cameraCheckBox.AutoSize = true;
               this.cameraCheckBox.Location = new System.Drawing.Point(30, 203);
            this.cameraCheckBox.Name = "cameraCheckBox";
            this.cameraCheckBox.Size = new System.Drawing.Size(57, 17);
            this.cameraCheckBox.TabIndex = 16;
            this.cameraCheckBox.Text = "Aparat";
            this.cameraCheckBox.UseVisualStyleBackColor = true;
            // 
            // isoCheckBox
            // 
            this.isoCheckBox.AutoSize = true;
               this.isoCheckBox.Location = new System.Drawing.Point(30, 232);
            this.isoCheckBox.Name = "isoCheckBox";
            this.isoCheckBox.Size = new System.Drawing.Size(44, 17);
            this.isoCheckBox.TabIndex = 17;
            this.isoCheckBox.Text = "ISO";
            this.isoCheckBox.UseVisualStyleBackColor = true;
            // 
            // photosFromPolandCheckBox
            // 
            this.photosFromPolandCheckBox.AutoSize = true;
               this.photosFromPolandCheckBox.Location = new System.Drawing.Point(49, 284);
            this.photosFromPolandCheckBox.Name = "photosFromPolandCheckBox";
            this.photosFromPolandCheckBox.Size = new System.Drawing.Size(100, 17);
            this.photosFromPolandCheckBox.TabIndex = 18;
            this.photosFromPolandCheckBox.Text = "Zdjęcia z Polski";
            this.photosFromPolandCheckBox.UseVisualStyleBackColor = true;
            // 
            // belowSeaLevelCheckBox
            // 
            this.belowSeaLevelCheckBox.AutoSize = true;
               this.belowSeaLevelCheckBox.Location = new System.Drawing.Point(49, 307);
            this.belowSeaLevelCheckBox.Name = "belowSeaLevelCheckBox";
            this.belowSeaLevelCheckBox.Size = new System.Drawing.Size(54, 17);
            this.belowSeaLevelCheckBox.TabIndex = 19;
            this.belowSeaLevelCheckBox.Text = "Niziny";
            this.belowSeaLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // peopleCheckBox
            // 
            this.peopleCheckBox.AutoSize = true;
               this.peopleCheckBox.Location = new System.Drawing.Point(30, 333);
            this.peopleCheckBox.Name = "peopleCheckBox";
            this.peopleCheckBox.Size = new System.Drawing.Size(57, 17);
            this.peopleCheckBox.TabIndex = 20;
            this.peopleCheckBox.Text = "Ludzie";
            this.peopleCheckBox.UseVisualStyleBackColor = true;
            // 
            // geoCheckBox
            // 
            this.geoCheckBox.AutoSize = true;
               this.geoCheckBox.Location = new System.Drawing.Point(30, 261);
            this.geoCheckBox.Name = "geoCheckBox";
            this.geoCheckBox.Size = new System.Drawing.Size(63, 17);
            this.geoCheckBox.TabIndex = 21;
            this.geoCheckBox.Text = "Geotagi";
            this.geoCheckBox.UseVisualStyleBackColor = true;
            // 
            // portraitCheckBox
            // 
            this.portraitCheckBox.AutoSize = true;
               this.portraitCheckBox.Location = new System.Drawing.Point(49, 356);
            this.portraitCheckBox.Name = "portraitCheckBox";
            this.portraitCheckBox.Size = new System.Drawing.Size(57, 17);
            this.portraitCheckBox.TabIndex = 22;
            this.portraitCheckBox.Text = "Portret";
            this.portraitCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainColourCheckBox
            // 
            this.mainColourCheckBox.AutoSize = true;
               this.mainColourCheckBox.Location = new System.Drawing.Point(30, 385);
            this.mainColourCheckBox.Name = "mainColourCheckBox";
            this.mainColourCheckBox.Size = new System.Drawing.Size(94, 17);
            this.mainColourCheckBox.TabIndex = 23;
            this.mainColourCheckBox.Text = "Wiodący kolor";
            this.mainColourCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
               this.groupCheckBox.Location = new System.Drawing.Point(155, 356);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(79, 17);
            this.groupCheckBox.TabIndex = 24;
            this.groupCheckBox.Text = "Grupa ludzi";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
               this.filterButton.Location = new System.Drawing.Point(144, 442);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 25;
            this.filterButton.Text = "Filtruj";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "małe",
            "średnie",
            "duże"});
               this.resolutionComboBox.Location = new System.Drawing.Point(155, 141);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(121, 21);
            this.resolutionComboBox.TabIndex = 31;
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "BMP",
            "GIF",
            "JPEG",
            "PNG",
            "Inne"});
               this.formatComboBox.Location = new System.Drawing.Point(155, 170);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 21);
            this.formatComboBox.TabIndex = 32;
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.FormattingEnabled = true;
               this.cameraComboBox.Location = new System.Drawing.Point(155, 199);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(121, 21);
            this.cameraComboBox.TabIndex = 33;
            // 
            // blackWhiteCheckBox
            // 
            this.blackWhiteCheckBox.AutoSize = true;
               this.blackWhiteCheckBox.Location = new System.Drawing.Point(49, 408);
            this.blackWhiteCheckBox.Name = "blackWhiteCheckBox";
            this.blackWhiteCheckBox.Size = new System.Drawing.Size(86, 17);
            this.blackWhiteCheckBox.TabIndex = 38;
            this.blackWhiteCheckBox.Text = "Czarno-białe";
            this.blackWhiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // photosFromAbroadCheckBox
            // 
            this.photosFromAbroadCheckBox.AutoSize = true;
               this.photosFromAbroadCheckBox.Location = new System.Drawing.Point(176, 284);
            this.photosFromAbroadCheckBox.Name = "photosFromAbroadCheckBox";
            this.photosFromAbroadCheckBox.Size = new System.Drawing.Size(121, 17);
            this.photosFromAbroadCheckBox.TabIndex = 39;
            this.photosFromAbroadCheckBox.Text = "Zdjęcia zagraniczne";
            this.photosFromAbroadCheckBox.UseVisualStyleBackColor = true;
            // 
            // overSeaLevelCheckBox
            // 
            this.overSeaLevelCheckBox.AutoSize = true;
               this.overSeaLevelCheckBox.Location = new System.Drawing.Point(176, 307);
            this.overSeaLevelCheckBox.Name = "overSeaLevelCheckBox";
            this.overSeaLevelCheckBox.Size = new System.Drawing.Size(63, 17);
            this.overSeaLevelCheckBox.TabIndex = 40;
            this.overSeaLevelCheckBox.Text = "Wyżyny";
            this.overSeaLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // isoComboBox
            // 
            this.isoComboBox.FormattingEnabled = true;
            this.isoComboBox.Items.AddRange(new object[] {
            "100 - 200",
            "200 - 800",
            "> 800"});
               this.isoComboBox.Location = new System.Drawing.Point(155, 232);
            this.isoComboBox.Name = "isoComboBox";
            this.isoComboBox.Size = new System.Drawing.Size(121, 21);
            this.isoComboBox.TabIndex = 41;
            // 
               // settingsEditor
               // 
               this.settingsEditor.Location = new System.Drawing.Point(15, 92);
               this.settingsEditor.Name = "settingsEditor";
               this.settingsEditor.Size = new System.Drawing.Size(134, 23);
               this.settingsEditor.TabIndex = 42;
               this.settingsEditor.Text = "Edytuj reguły";
               this.settingsEditor.UseVisualStyleBackColor = true;
               this.settingsEditor.Click += new System.EventHandler(this.settingsEditor_Click);
               // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(737, 485);
               this.Controls.Add(this.settingsEditor);
            this.ClientSize = new System.Drawing.Size(737, 462);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.isoComboBox);
            this.Controls.Add(this.overSeaLevelCheckBox);
            this.Controls.Add(this.photosFromAbroadCheckBox);
            this.Controls.Add(this.blackWhiteCheckBox);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.groupCheckBox);
            this.Controls.Add(this.mainColourCheckBox);
            this.Controls.Add(this.portraitCheckBox);
            this.Controls.Add(this.geoCheckBox);
            this.Controls.Add(this.peopleCheckBox);
            this.Controls.Add(this.belowSeaLevelCheckBox);
            this.Controls.Add(this.photosFromPolandCheckBox);
            this.Controls.Add(this.isoCheckBox);
            this.Controls.Add(this.cameraCheckBox);
            this.Controls.Add(this.formatCheckBox);
            this.Controls.Add(this.resolutionCheckBox);
            this.Controls.Add(this.startClassificationButton);
            this.Controls.Add(this.chosenDirectoryLabel);
            this.Controls.Add(this.refreshImagesButton);
            this.Controls.Add(this.chosenDirectoryBox);
            this.Controls.Add(this.directoryPicker);
            this.Controls.Add(this.listView);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button directoryPicker;
        private System.Windows.Forms.TextBox chosenDirectoryBox;
        private System.Windows.Forms.Button refreshImagesButton;
        private System.Windows.Forms.Label chosenDirectoryLabel;
        private System.Windows.Forms.Button startClassificationButton;
        private System.Windows.Forms.CheckBox resolutionCheckBox;
        private System.Windows.Forms.CheckBox formatCheckBox;
        private System.Windows.Forms.CheckBox cameraCheckBox;
        private System.Windows.Forms.CheckBox isoCheckBox;
        private System.Windows.Forms.CheckBox photosFromPolandCheckBox;
        private System.Windows.Forms.CheckBox belowSeaLevelCheckBox;
        private System.Windows.Forms.CheckBox peopleCheckBox;
        private System.Windows.Forms.CheckBox geoCheckBox;
        private System.Windows.Forms.CheckBox portraitCheckBox;
        private System.Windows.Forms.CheckBox mainColourCheckBox;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.CheckBox blackWhiteCheckBox;
        private System.Windows.Forms.CheckBox photosFromAbroadCheckBox;
        private System.Windows.Forms.CheckBox overSeaLevelCheckBox;
        private System.Windows.Forms.ComboBox isoComboBox;
        private System.Windows.Forms.Button settingsEditor;
        private System.Windows.Forms.TextBox textBox1;
    }
}

