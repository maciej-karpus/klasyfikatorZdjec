using System.Collections.Generic;
using System.Windows.Forms;
namespace KlasyfikatorZdjec
{
     partial class Form2
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
               this.goButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // goButton
               // 
               this.goButton.Location = new System.Drawing.Point(228, 327);
               this.goButton.Name = "goButton";
               this.goButton.Size = new System.Drawing.Size(75, 23);
               this.goButton.TabIndex = 0;
               this.goButton.Text = "Zatwierdź";
               this.goButton.UseVisualStyleBackColor = true;
               this.goButton.Click += new System.EventHandler(this.goButton_Click);
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(527, 362);
               this.Controls.Add(this.goButton);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "Form2";
               this.Text = "Ustawienia";
               this.ResumeLayout(false);

          }

          #endregion

          private Button goButton;
     }
}