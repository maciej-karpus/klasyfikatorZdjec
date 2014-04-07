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
            this.formatEditButton = new System.Windows.Forms.Button();
            this.resolutionEditButton = new System.Windows.Forms.Button();
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
            this.cameraEditButton = new System.Windows.Forms.Button();
            this.mainColourEditButton = new System.Windows.Forms.Button();
            this.geoEditButton = new System.Windows.Forms.Button();
            this.peopleEditButton = new System.Windows.Forms.Button();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.mainColourComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blackWhiteCheckBox = new System.Windows.Forms.CheckBox();
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
            this.listView.Size = new System.Drawing.Size(389, 437);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // directoryPicker
            // 
            this.directoryPicker.Location = new System.Drawing.Point(12, 63);
            this.directoryPicker.Name = "directoryPicker";
            this.directoryPicker.Size = new System.Drawing.Size(81, 23);
            this.directoryPicker.TabIndex = 4;
            this.directoryPicker.Text = "Zmień lokacje";
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
            this.refreshImagesButton.Location = new System.Drawing.Point(262, 63);
            this.refreshImagesButton.Name = "refreshImagesButton";
            this.refreshImagesButton.Size = new System.Drawing.Size(68, 23);
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
            // formatEditButton
            // 
            this.formatEditButton.Location = new System.Drawing.Point(279, 138);
            this.formatEditButton.Name = "formatEditButton";
            this.formatEditButton.Size = new System.Drawing.Size(51, 23);
            this.formatEditButton.TabIndex = 9;
            this.formatEditButton.Text = "Edycja";
            this.formatEditButton.UseVisualStyleBackColor = true;
            // 
            // resolutionEditButton
            // 
            this.resolutionEditButton.Location = new System.Drawing.Point(279, 109);
            this.resolutionEditButton.Name = "resolutionEditButton";
            this.resolutionEditButton.Size = new System.Drawing.Size(51, 23);
            this.resolutionEditButton.TabIndex = 12;
            this.resolutionEditButton.Text = "Edycja";
            this.resolutionEditButton.UseVisualStyleBackColor = true;
            // 
            // startClassificationButton
            // 
            this.startClassificationButton.Location = new System.Drawing.Point(107, 63);
            this.startClassificationButton.Name = "startClassificationButton";
            this.startClassificationButton.Size = new System.Drawing.Size(140, 23);
            this.startClassificationButton.TabIndex = 13;
            this.startClassificationButton.Text = "Rozpocznij klasyfikację";
            this.startClassificationButton.UseVisualStyleBackColor = true;
            // 
            // resolutionCheckBox
            // 
            this.resolutionCheckBox.AutoSize = true;
            this.resolutionCheckBox.Location = new System.Drawing.Point(15, 113);
            this.resolutionCheckBox.Name = "resolutionCheckBox";
            this.resolutionCheckBox.Size = new System.Drawing.Size(94, 17);
            this.resolutionCheckBox.TabIndex = 14;
            this.resolutionCheckBox.Text = "Rozdzielczość";
            this.resolutionCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatCheckBox
            // 
            this.formatCheckBox.AutoSize = true;
            this.formatCheckBox.Location = new System.Drawing.Point(15, 142);
            this.formatCheckBox.Name = "formatCheckBox";
            this.formatCheckBox.Size = new System.Drawing.Size(58, 17);
            this.formatCheckBox.TabIndex = 15;
            this.formatCheckBox.Text = "Format";
            this.formatCheckBox.UseVisualStyleBackColor = true;
            // 
            // cameraCheckBox
            // 
            this.cameraCheckBox.AutoSize = true;
            this.cameraCheckBox.Location = new System.Drawing.Point(15, 171);
            this.cameraCheckBox.Name = "cameraCheckBox";
            this.cameraCheckBox.Size = new System.Drawing.Size(57, 17);
            this.cameraCheckBox.TabIndex = 16;
            this.cameraCheckBox.Text = "Aparat";
            this.cameraCheckBox.UseVisualStyleBackColor = true;
            // 
            // isoCheckBox
            // 
            this.isoCheckBox.AutoSize = true;
            this.isoCheckBox.Location = new System.Drawing.Point(15, 200);
            this.isoCheckBox.Name = "isoCheckBox";
            this.isoCheckBox.Size = new System.Drawing.Size(44, 17);
            this.isoCheckBox.TabIndex = 17;
            this.isoCheckBox.Text = "ISO";
            this.isoCheckBox.UseVisualStyleBackColor = true;
            // 
            // photosFromPolandCheckBox
            // 
            this.photosFromPolandCheckBox.AutoSize = true;
            this.photosFromPolandCheckBox.Location = new System.Drawing.Point(34, 252);
            this.photosFromPolandCheckBox.Name = "photosFromPolandCheckBox";
            this.photosFromPolandCheckBox.Size = new System.Drawing.Size(100, 17);
            this.photosFromPolandCheckBox.TabIndex = 18;
            this.photosFromPolandCheckBox.Text = "Zdjęcia z Polski";
            this.photosFromPolandCheckBox.UseVisualStyleBackColor = true;
            // 
            // belowSeaLevelCheckBox
            // 
            this.belowSeaLevelCheckBox.AutoSize = true;
            this.belowSeaLevelCheckBox.Location = new System.Drawing.Point(140, 252);
            this.belowSeaLevelCheckBox.Name = "belowSeaLevelCheckBox";
            this.belowSeaLevelCheckBox.Size = new System.Drawing.Size(128, 17);
            this.belowSeaLevelCheckBox.TabIndex = 19;
            this.belowSeaLevelCheckBox.Text = "Pod Poziomem Morza";
            this.belowSeaLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // peopleCheckBox
            // 
            this.peopleCheckBox.AutoSize = true;
            this.peopleCheckBox.Location = new System.Drawing.Point(15, 282);
            this.peopleCheckBox.Name = "peopleCheckBox";
            this.peopleCheckBox.Size = new System.Drawing.Size(57, 17);
            this.peopleCheckBox.TabIndex = 20;
            this.peopleCheckBox.Text = "Ludzie";
            this.peopleCheckBox.UseVisualStyleBackColor = true;
            // 
            // geoCheckBox
            // 
            this.geoCheckBox.AutoSize = true;
            this.geoCheckBox.Location = new System.Drawing.Point(15, 229);
            this.geoCheckBox.Name = "geoCheckBox";
            this.geoCheckBox.Size = new System.Drawing.Size(63, 17);
            this.geoCheckBox.TabIndex = 21;
            this.geoCheckBox.Text = "Geotagi";
            this.geoCheckBox.UseVisualStyleBackColor = true;
            // 
            // portraitCheckBox
            // 
            this.portraitCheckBox.AutoSize = true;
            this.portraitCheckBox.Location = new System.Drawing.Point(34, 305);
            this.portraitCheckBox.Name = "portraitCheckBox";
            this.portraitCheckBox.Size = new System.Drawing.Size(57, 17);
            this.portraitCheckBox.TabIndex = 22;
            this.portraitCheckBox.Text = "Portret";
            this.portraitCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainColourCheckBox
            // 
            this.mainColourCheckBox.AutoSize = true;
            this.mainColourCheckBox.Location = new System.Drawing.Point(15, 334);
            this.mainColourCheckBox.Name = "mainColourCheckBox";
            this.mainColourCheckBox.Size = new System.Drawing.Size(94, 17);
            this.mainColourCheckBox.TabIndex = 23;
            this.mainColourCheckBox.Text = "Wiodący kolor";
            this.mainColourCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Location = new System.Drawing.Point(140, 305);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(79, 17);
            this.groupCheckBox.TabIndex = 24;
            this.groupCheckBox.Text = "Grupa ludzi";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(126, 427);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 25;
            this.filterButton.Text = "Filtruj";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // cameraEditButton
            // 
            this.cameraEditButton.Location = new System.Drawing.Point(279, 167);
            this.cameraEditButton.Name = "cameraEditButton";
            this.cameraEditButton.Size = new System.Drawing.Size(51, 23);
            this.cameraEditButton.TabIndex = 26;
            this.cameraEditButton.Text = "Edycja";
            this.cameraEditButton.UseVisualStyleBackColor = true;
            // 
            // mainColourEditButton
            // 
            this.mainColourEditButton.Location = new System.Drawing.Point(279, 330);
            this.mainColourEditButton.Name = "mainColourEditButton";
            this.mainColourEditButton.Size = new System.Drawing.Size(51, 23);
            this.mainColourEditButton.TabIndex = 29;
            this.mainColourEditButton.Text = "Edycja";
            this.mainColourEditButton.UseVisualStyleBackColor = true;
            // 
            // geoEditButton
            // 
            this.geoEditButton.Location = new System.Drawing.Point(279, 225);
            this.geoEditButton.Name = "geoEditButton";
            this.geoEditButton.Size = new System.Drawing.Size(51, 23);
            this.geoEditButton.TabIndex = 28;
            this.geoEditButton.Text = "Edycja";
            this.geoEditButton.UseVisualStyleBackColor = true;
            // 
            // peopleEditButton
            // 
            this.peopleEditButton.Location = new System.Drawing.Point(279, 278);
            this.peopleEditButton.Name = "peopleEditButton";
            this.peopleEditButton.Size = new System.Drawing.Size(51, 23);
            this.peopleEditButton.TabIndex = 30;
            this.peopleEditButton.Text = "Edycja";
            this.peopleEditButton.UseVisualStyleBackColor = true;
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "małe",
            "średnie",
            "duże"});
            this.resolutionComboBox.Location = new System.Drawing.Point(140, 109);
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
            this.formatComboBox.Location = new System.Drawing.Point(140, 138);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 21);
            this.formatComboBox.TabIndex = 32;
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(140, 167);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(121, 21);
            this.cameraComboBox.TabIndex = 33;
            // 
            // mainColourComboBox
            // 
            this.mainColourComboBox.FormattingEnabled = true;
            this.mainColourComboBox.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Żółty",
            "Czarny",
            "Biały"});
            this.mainColourComboBox.Location = new System.Drawing.Point(140, 353);
            this.mainColourComboBox.Name = "mainColourComboBox";
            this.mainColourComboBox.Size = new System.Drawing.Size(121, 21);
            this.mainColourComboBox.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = " - ";
            // 
            // blackWhiteCheckBox
            // 
            this.blackWhiteCheckBox.AutoSize = true;
            this.blackWhiteCheckBox.Location = new System.Drawing.Point(34, 357);
            this.blackWhiteCheckBox.Name = "blackWhiteCheckBox";
            this.blackWhiteCheckBox.Size = new System.Drawing.Size(86, 17);
            this.blackWhiteCheckBox.TabIndex = 38;
            this.blackWhiteCheckBox.Text = "Czarno-białe";
            this.blackWhiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 462);
            this.Controls.Add(this.blackWhiteCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mainColourComboBox);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.peopleEditButton);
            this.Controls.Add(this.mainColourEditButton);
            this.Controls.Add(this.geoEditButton);
            this.Controls.Add(this.cameraEditButton);
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
            this.Controls.Add(this.resolutionEditButton);
            this.Controls.Add(this.formatEditButton);
            this.Controls.Add(this.chosenDirectoryLabel);
            this.Controls.Add(this.refreshImagesButton);
            this.Controls.Add(this.chosenDirectoryBox);
            this.Controls.Add(this.directoryPicker);
            this.Controls.Add(this.listView);
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
        private System.Windows.Forms.Button formatEditButton;
        private System.Windows.Forms.Button resolutionEditButton;
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
        private System.Windows.Forms.Button cameraEditButton;
        private System.Windows.Forms.Button mainColourEditButton;
        private System.Windows.Forms.Button geoEditButton;
        private System.Windows.Forms.Button peopleEditButton;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.ComboBox mainColourComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox blackWhiteCheckBox;
    }
}

