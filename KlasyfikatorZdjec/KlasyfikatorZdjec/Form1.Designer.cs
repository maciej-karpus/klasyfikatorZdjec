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
            this.exifClassifyByDateButton = new System.Windows.Forms.Button();
            this.exifClassifyByDateEditButton = new System.Windows.Forms.Button();
            this.exifClassificationLabel = new System.Windows.Forms.Label();
            this.exifClassifyByResolutionButton = new System.Windows.Forms.Button();
            this.exifClassifyByResolutionEditButton = new System.Windows.Forms.Button();
            this.startClassificationButton = new System.Windows.Forms.Button();
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
            this.directoryPicker.Size = new System.Drawing.Size(97, 23);
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
            this.refreshImagesButton.Location = new System.Drawing.Point(231, 63);
            this.refreshImagesButton.Name = "refreshImagesButton";
            this.refreshImagesButton.Size = new System.Drawing.Size(99, 23);
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
            // exifClassifyByDateButton
            // 
            this.exifClassifyByDateButton.Location = new System.Drawing.Point(12, 134);
            this.exifClassifyByDateButton.Name = "exifClassifyByDateButton";
            this.exifClassifyByDateButton.Size = new System.Drawing.Size(121, 23);
            this.exifClassifyByDateButton.TabIndex = 8;
            this.exifClassifyByDateButton.Text = "Data wykonania";
            this.exifClassifyByDateButton.UseVisualStyleBackColor = true;
            // 
            // exifClassifyByDateEditButton
            // 
            this.exifClassifyByDateEditButton.Location = new System.Drawing.Point(139, 134);
            this.exifClassifyByDateEditButton.Name = "exifClassifyByDateEditButton";
            this.exifClassifyByDateEditButton.Size = new System.Drawing.Size(51, 23);
            this.exifClassifyByDateEditButton.TabIndex = 9;
            this.exifClassifyByDateEditButton.Text = "Edycja";
            this.exifClassifyByDateEditButton.UseVisualStyleBackColor = true;
            // 
            // exifClassificationLabel
            // 
            this.exifClassificationLabel.AutoSize = true;
            this.exifClassificationLabel.Location = new System.Drawing.Point(9, 118);
            this.exifClassificationLabel.Name = "exifClassificationLabel";
            this.exifClassificationLabel.Size = new System.Drawing.Size(156, 13);
            this.exifClassificationLabel.TabIndex = 10;
            this.exifClassificationLabel.Text = "Klasyfikacja poprzez metadane:";
            // 
            // exifClassifyByResolutionButton
            // 
            this.exifClassifyByResolutionButton.Location = new System.Drawing.Point(12, 163);
            this.exifClassifyByResolutionButton.Name = "exifClassifyByResolutionButton";
            this.exifClassifyByResolutionButton.Size = new System.Drawing.Size(121, 23);
            this.exifClassifyByResolutionButton.TabIndex = 11;
            this.exifClassifyByResolutionButton.Text = "Rozdzielczość";
            this.exifClassifyByResolutionButton.UseVisualStyleBackColor = true;
            // 
            // exifClassifyByResolutionEditButton
            // 
            this.exifClassifyByResolutionEditButton.Location = new System.Drawing.Point(139, 163);
            this.exifClassifyByResolutionEditButton.Name = "exifClassifyByResolutionEditButton";
            this.exifClassifyByResolutionEditButton.Size = new System.Drawing.Size(51, 23);
            this.exifClassifyByResolutionEditButton.TabIndex = 12;
            this.exifClassifyByResolutionEditButton.Text = "Edycja";
            this.exifClassifyByResolutionEditButton.UseVisualStyleBackColor = true;
            // 
            // startClassificationButton
            // 
            this.startClassificationButton.Location = new System.Drawing.Point(93, 272);
            this.startClassificationButton.Name = "startClassificationButton";
            this.startClassificationButton.Size = new System.Drawing.Size(140, 23);
            this.startClassificationButton.TabIndex = 13;
            this.startClassificationButton.Text = "Rozpocznij klasyfikację";
            this.startClassificationButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 462);
            this.Controls.Add(this.startClassificationButton);
            this.Controls.Add(this.exifClassifyByResolutionEditButton);
            this.Controls.Add(this.exifClassifyByResolutionButton);
            this.Controls.Add(this.exifClassificationLabel);
            this.Controls.Add(this.exifClassifyByDateEditButton);
            this.Controls.Add(this.exifClassifyByDateButton);
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
        private System.Windows.Forms.Button exifClassifyByDateButton;
        private System.Windows.Forms.Button exifClassifyByDateEditButton;
        private System.Windows.Forms.Label exifClassificationLabel;
        private System.Windows.Forms.Button exifClassifyByResolutionButton;
        private System.Windows.Forms.Button exifClassifyByResolutionEditButton;
        private System.Windows.Forms.Button startClassificationButton;
    }
}

