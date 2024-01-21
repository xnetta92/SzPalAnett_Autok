namespace SzPalAnett_Autok
{
    partial class FormCars
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
            this.label_licplate = new System.Windows.Forms.Label();
            this.textBox_licplate = new System.Windows.Forms.TextBox();
            this.pictureBox_makelogo = new System.Windows.Forms.PictureBox();
            this.label_make = new System.Windows.Forms.Label();
            this.textBox_make = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.label_ManDate = new System.Windows.Forms.Label();
            this.numericUpDown_manDate = new System.Windows.Forms.NumericUpDown();
            this.label_validity = new System.Windows.Forms.Label();
            this.dateTimePicker_validity = new System.Windows.Forms.DateTimePicker();
            this.label_price = new System.Windows.Forms.Label();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.label_pricesymb = new System.Windows.Forms.Label();
            this.label_km = new System.Windows.Forms.Label();
            this.numericUpDown_km = new System.Windows.Forms.NumericUpDown();
            this.label_CC = new System.Windows.Forms.Label();
            this.numericUpDown_CC = new System.Windows.Forms.NumericUpDown();
            this.label_CCsymb = new System.Windows.Forms.Label();
            this.label_mass = new System.Windows.Forms.Label();
            this.numericUpDown_mass = new System.Windows.Forms.NumericUpDown();
            this.label_kmsymb = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.numericUpDown_Hp = new System.Windows.Forms.NumericUpDown();
            this.label_hpsymb = new System.Windows.Forms.Label();
            this.label_masssymb = new System.Windows.Forms.Label();
            this.button_action = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_makelogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_manDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_km)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hp)).BeginInit();
            this.SuspendLayout();
            // 
            // label_licplate
            // 
            this.label_licplate.AutoSize = true;
            this.label_licplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_licplate.Location = new System.Drawing.Point(42, 22);
            this.label_licplate.Name = "label_licplate";
            this.label_licplate.Size = new System.Drawing.Size(55, 16);
            this.label_licplate.TabIndex = 0;
            this.label_licplate.Text = "LicPlate";
            this.label_licplate.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_licplate
            // 
            this.textBox_licplate.Location = new System.Drawing.Point(12, 41);
            this.textBox_licplate.Name = "textBox_licplate";
            this.textBox_licplate.ReadOnly = true;
            this.textBox_licplate.Size = new System.Drawing.Size(132, 20);
            this.textBox_licplate.TabIndex = 1;
            this.textBox_licplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox_makelogo
            // 
            this.pictureBox_makelogo.Location = new System.Drawing.Point(12, 76);
            this.pictureBox_makelogo.Name = "pictureBox_makelogo";
            this.pictureBox_makelogo.Size = new System.Drawing.Size(132, 126);
            this.pictureBox_makelogo.TabIndex = 2;
            this.pictureBox_makelogo.TabStop = false;
            this.pictureBox_makelogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_make
            // 
            this.label_make.AutoSize = true;
            this.label_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_make.Location = new System.Drawing.Point(193, 47);
            this.label_make.Name = "label_make";
            this.label_make.Size = new System.Drawing.Size(41, 16);
            this.label_make.TabIndex = 3;
            this.label_make.Text = "Make";
            // 
            // textBox_make
            // 
            this.textBox_make.Location = new System.Drawing.Point(196, 66);
            this.textBox_make.Name = "textBox_make";
            this.textBox_make.Size = new System.Drawing.Size(114, 20);
            this.textBox_make.TabIndex = 4;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.Location = new System.Drawing.Point(394, 47);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(45, 16);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "Model";
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(397, 66);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(121, 20);
            this.textBox_model.TabIndex = 6;
            // 
            // label_ManDate
            // 
            this.label_ManDate.AutoSize = true;
            this.label_ManDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ManDate.Location = new System.Drawing.Point(193, 107);
            this.label_ManDate.Name = "label_ManDate";
            this.label_ManDate.Size = new System.Drawing.Size(62, 16);
            this.label_ManDate.TabIndex = 7;
            this.label_ManDate.Text = "ManDate";
            // 
            // numericUpDown_manDate
            // 
            this.numericUpDown_manDate.Location = new System.Drawing.Point(196, 130);
            this.numericUpDown_manDate.Name = "numericUpDown_manDate";
            this.numericUpDown_manDate.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_manDate.TabIndex = 8;
            // 
            // label_validity
            // 
            this.label_validity.AutoSize = true;
            this.label_validity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_validity.Location = new System.Drawing.Point(394, 111);
            this.label_validity.Name = "label_validity";
            this.label_validity.Size = new System.Drawing.Size(51, 16);
            this.label_validity.TabIndex = 9;
            this.label_validity.Text = "Validity";
            // 
            // dateTimePicker_validity
            // 
            this.dateTimePicker_validity.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_validity.Location = new System.Drawing.Point(397, 130);
            this.dateTimePicker_validity.Name = "dateTimePicker_validity";
            this.dateTimePicker_validity.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker_validity.TabIndex = 10;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.Location = new System.Drawing.Point(193, 176);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(38, 16);
            this.label_price.TabIndex = 11;
            this.label_price.Text = "Price";
            this.label_price.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Location = new System.Drawing.Point(196, 195);
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_price.TabIndex = 12;
            // 
            // label_pricesymb
            // 
            this.label_pricesymb.AutoSize = true;
            this.label_pricesymb.Location = new System.Drawing.Point(316, 199);
            this.label_pricesymb.Name = "label_pricesymb";
            this.label_pricesymb.Size = new System.Drawing.Size(30, 13);
            this.label_pricesymb.TabIndex = 13;
            this.label_pricesymb.Text = "EUR";
            // 
            // label_km
            // 
            this.label_km.AutoSize = true;
            this.label_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_km.Location = new System.Drawing.Point(193, 234);
            this.label_km.Name = "label_km";
            this.label_km.Size = new System.Drawing.Size(26, 16);
            this.label_km.TabIndex = 14;
            this.label_km.Text = "Km";
            this.label_km.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericUpDown_km
            // 
            this.numericUpDown_km.Location = new System.Drawing.Point(196, 253);
            this.numericUpDown_km.Name = "numericUpDown_km";
            this.numericUpDown_km.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_km.TabIndex = 15;
            // 
            // label_CC
            // 
            this.label_CC.AutoSize = true;
            this.label_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CC.Location = new System.Drawing.Point(394, 234);
            this.label_CC.Name = "label_CC";
            this.label_CC.Size = new System.Drawing.Size(75, 16);
            this.label_CC.TabIndex = 16;
            this.label_CC.Text = "EngineSize";
            // 
            // numericUpDown_CC
            // 
            this.numericUpDown_CC.Location = new System.Drawing.Point(397, 253);
            this.numericUpDown_CC.Name = "numericUpDown_CC";
            this.numericUpDown_CC.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_CC.TabIndex = 17;
            // 
            // label_CCsymb
            // 
            this.label_CCsymb.AutoSize = true;
            this.label_CCsymb.Location = new System.Drawing.Point(517, 255);
            this.label_CCsymb.Name = "label_CCsymb";
            this.label_CCsymb.Size = new System.Drawing.Size(27, 13);
            this.label_CCsymb.TabIndex = 18;
            this.label_CCsymb.Text = "cm3";
            // 
            // label_mass
            // 
            this.label_mass.AutoSize = true;
            this.label_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mass.Location = new System.Drawing.Point(193, 292);
            this.label_mass.Name = "label_mass";
            this.label_mass.Size = new System.Drawing.Size(40, 16);
            this.label_mass.TabIndex = 19;
            this.label_mass.Text = "Mass";
            // 
            // numericUpDown_mass
            // 
            this.numericUpDown_mass.Location = new System.Drawing.Point(196, 311);
            this.numericUpDown_mass.Name = "numericUpDown_mass";
            this.numericUpDown_mass.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_mass.TabIndex = 20;
            // 
            // label_kmsymb
            // 
            this.label_kmsymb.AutoSize = true;
            this.label_kmsymb.Location = new System.Drawing.Point(316, 255);
            this.label_kmsymb.Name = "label_kmsymb";
            this.label_kmsymb.Size = new System.Drawing.Size(21, 13);
            this.label_kmsymb.TabIndex = 21;
            this.label_kmsymb.Text = "km";
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hp.Location = new System.Drawing.Point(394, 292);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(81, 16);
            this.label_hp.TabIndex = 22;
            this.label_hp.Text = "Horsepower";
            // 
            // numericUpDown_Hp
            // 
            this.numericUpDown_Hp.Location = new System.Drawing.Point(397, 311);
            this.numericUpDown_Hp.Name = "numericUpDown_Hp";
            this.numericUpDown_Hp.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_Hp.TabIndex = 23;
            // 
            // label_hpsymb
            // 
            this.label_hpsymb.AutoSize = true;
            this.label_hpsymb.Location = new System.Drawing.Point(517, 313);
            this.label_hpsymb.Name = "label_hpsymb";
            this.label_hpsymb.Size = new System.Drawing.Size(22, 13);
            this.label_hpsymb.TabIndex = 24;
            this.label_hpsymb.Text = "HP";
            // 
            // label_masssymb
            // 
            this.label_masssymb.AutoSize = true;
            this.label_masssymb.Location = new System.Drawing.Point(316, 313);
            this.label_masssymb.Name = "label_masssymb";
            this.label_masssymb.Size = new System.Drawing.Size(19, 13);
            this.label_masssymb.TabIndex = 25;
            this.label_masssymb.Text = "kg";
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(12, 244);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(132, 35);
            this.button_action.TabIndex = 26;
            this.button_action.Text = "button1";
            this.button_action.UseVisualStyleBackColor = true;
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 390);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.label_masssymb);
            this.Controls.Add(this.label_hpsymb);
            this.Controls.Add(this.numericUpDown_Hp);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.label_kmsymb);
            this.Controls.Add(this.numericUpDown_mass);
            this.Controls.Add(this.label_mass);
            this.Controls.Add(this.label_CCsymb);
            this.Controls.Add(this.numericUpDown_CC);
            this.Controls.Add(this.label_CC);
            this.Controls.Add(this.numericUpDown_km);
            this.Controls.Add(this.label_km);
            this.Controls.Add(this.label_pricesymb);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.dateTimePicker_validity);
            this.Controls.Add(this.label_validity);
            this.Controls.Add(this.numericUpDown_manDate);
            this.Controls.Add(this.label_ManDate);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.textBox_make);
            this.Controls.Add(this.label_make);
            this.Controls.Add(this.pictureBox_makelogo);
            this.Controls.Add(this.textBox_licplate);
            this.Controls.Add(this.label_licplate);
            this.Name = "FormCars";
            this.Text = "FormCars";
            this.Load += new System.EventHandler(this.FormCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_makelogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_manDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_km)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_licplate;
        private System.Windows.Forms.TextBox textBox_licplate;
        private System.Windows.Forms.PictureBox pictureBox_makelogo;
        private System.Windows.Forms.Label label_make;
        private System.Windows.Forms.TextBox textBox_make;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Label label_ManDate;
        private System.Windows.Forms.NumericUpDown numericUpDown_manDate;
        private System.Windows.Forms.Label label_validity;
        private System.Windows.Forms.DateTimePicker dateTimePicker_validity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.Label label_pricesymb;
        private System.Windows.Forms.Label label_km;
        private System.Windows.Forms.NumericUpDown numericUpDown_km;
        private System.Windows.Forms.Label label_CC;
        private System.Windows.Forms.NumericUpDown numericUpDown_CC;
        private System.Windows.Forms.Label label_CCsymb;
        private System.Windows.Forms.Label label_mass;
        private System.Windows.Forms.NumericUpDown numericUpDown_mass;
        private System.Windows.Forms.Label label_kmsymb;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hp;
        private System.Windows.Forms.Label label_hpsymb;
        private System.Windows.Forms.Label label_masssymb;
        private System.Windows.Forms.Button button_action;
    }
}