using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasyfikatorZdjec
{
     public partial class Form2 : Form
     {
          Form1 parent;
          private List<SettingForm> settingForms;
       
          public Form2(Form1 parent)
          {
               this.parent = parent;
               this.settingForms = new List<SettingForm>();
               populateSettingForms(Settings.getSettingList());
               InitializeComponent();
               this.ShowDialog();
          }

          public void populateSettingForms(List<Setting> settingList)
          {
               //Dla każdego ustawienia dodaj rubyki w dialogu
               int i = 10;
               foreach(Setting setting in settingList)
               {
                    settingForms.Add(new SettingForm(setting, i, this));
                    i += 25;
               }
               var tmp = Settings.findSettingByKey(SettingKey.DOMINATING_RED_KEY);
          }

          private void saveSettings()
          {
               foreach (SettingForm form in settingForms)
               {
                    Settings.editSettingByKey(form.getSettingKey(), form.getLowerBound(), form.getUpperBound());
               }
          }

          private void goButton_Click(object sender, EventArgs e)
          {
               saveSettings();
               this.Close();
          }

          class SettingForm
          {
               private SettingKey key;
               private TextBox lowerValue;
               private Label fromLabel;
               private Label toLabel;
               private TextBox upperValue;
               private Label descriptionLabel;

               public SettingForm(Setting setting, int positionX, Form2 parent)
               {
                    key = setting.getKey();
                    descriptionLabel = new Label();
                    descriptionLabel.Location = new System.Drawing.Point(10, positionX);
                    descriptionLabel.Text = setting.getDescription();
                    descriptionLabel.Size = new System.Drawing.Size(150, 20);
                    
                    fromLabel = new Label();
                    fromLabel.Location = new System.Drawing.Point(170, positionX);
                    fromLabel.Text = "od:";
                    fromLabel.Size = new System.Drawing.Size(20, 20);

                    toLabel = new Label();
                    toLabel.Location = new System.Drawing.Point(320, positionX);
                    toLabel.Text = "do:";
                    toLabel.Size = new System.Drawing.Size(20, 20);

                    lowerValue = new TextBox();
                    lowerValue.Location = new System.Drawing.Point(200, positionX);
                    lowerValue.Size = new System.Drawing.Size(100, 20);
                    if (!setting.isLowerBoundLocked())
                         lowerValue.Text = setting.getLowerBound().ToString();
                    else 
                         lowerValue.Enabled = false;

                    upperValue = new TextBox();
                    upperValue.Location = new System.Drawing.Point(340, positionX);
                    upperValue.Size = new System.Drawing.Size(100, 20);
                    if (!setting.isUpperBoundLocked())
                         upperValue.Text = setting.getUpperBound().ToString();
                    else
                         upperValue.Enabled = false;

                    parent.Controls.Add(descriptionLabel);
                    parent.Controls.Add(fromLabel);
                    parent.Controls.Add(toLabel);
                    parent.Controls.Add(lowerValue);
                    parent.Controls.Add(upperValue);
               }

               //TODO: Sprawdzanie poprawności danych
               public Double getLowerBound() 
               {
                    if (lowerValue.Enabled) return Double.Parse(lowerValue.Text);
                    else return 0;
               }

               public Double getUpperBound()
               {
                    if (upperValue.Enabled) return Double.Parse(upperValue.Text);
                    else return 0;
               }

               public SettingKey getSettingKey()
               {
                    return key;
               }
          }
     }
}
