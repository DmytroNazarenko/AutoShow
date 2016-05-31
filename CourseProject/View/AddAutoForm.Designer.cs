namespace CourseProject.View
{
    partial class AddAutoForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.engineCapacityTrackbar = new System.Windows.Forms.TrackBar();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.engineValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.engineCapacityTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(123, 265);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 39);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(151, 84);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(183, 20);
            this.modelBox.TabIndex = 2;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(151, 162);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(183, 20);
            this.colorBox.TabIndex = 4;
            // 
            // brandBox
            // 
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Items.AddRange(new object[] {
            "",
            "Acura",
            "Alfa Romeo",
            "Alpina",
            "Audi",
            "BAW",
            "Bentley",
            "BMW",
            "Brilliance",
            "BYD",
            "Cadillac",
            "Changan",
            "Chery",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "Daf",
            "Daihatsu",
            "Datsun",
            "Dodge",
            "Dongfeng",
            "FAW",
            "Ferrari",
            "Fiat",
            "Ford",
            "Ford USA",
            "Foton",
            "Freightliner",
            "Geely",
            "GMC",
            "Great Wall",
            "Haima",
            "Hino",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Iran Khodro",
            "Isuzu",
            "IVECO",
            "JAC",
            "Jaguar",
            "Jeep",
            "JMC",
            "Kia",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "LDV",
            "Lexus",
            "Lifan",
            "Lincoln",
            "Lotus",
            "MAN",
            "Maserati",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "MINI",
            "Mitsubishi",
            "Nissan",
            "Oldsmobile",
            "Opel",
            "Peugeot",
            "Pontiac",
            "Porsche",
            "Renault",
            "Rolls-Royce",
            "Rover",
            "Saab",
            "Scania",
            "Seat",
            "Skoda",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "Tianye",
            "Toyota",
            "Volkswagen",
            "Volvo",
            "ВАЗ",
            "ВИС",
            "ГАЗ",
            "ЗАЗ",
            "ЗИЛ",
            "ИЖ",
            "КАМАЗ",
            "КрАЗ",
            "МАЗ",
            "Москвич",
            "ПАЗ",
            "ТагАЗ",
            "УАЗ",
            "Урал"});
            this.brandBox.Location = new System.Drawing.Point(151, 51);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(183, 21);
            this.brandBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Объем двигателя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цвет";
            // 
            // engineCapacityTrackbar
            // 
            this.engineCapacityTrackbar.Location = new System.Drawing.Point(151, 111);
            this.engineCapacityTrackbar.Maximum = 90;
            this.engineCapacityTrackbar.Minimum = 5;
            this.engineCapacityTrackbar.Name = "engineCapacityTrackbar";
            this.engineCapacityTrackbar.Size = new System.Drawing.Size(183, 45);
            this.engineCapacityTrackbar.TabIndex = 11;
            this.engineCapacityTrackbar.Value = 5;
            this.engineCapacityTrackbar.Scroll += new System.EventHandler(this.engineCapacityTrackbar_Scroll);
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(151, 192);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(183, 20);
            this.distanceBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пробег";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Стоимость";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(151, 221);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(183, 20);
            this.priceBox.TabIndex = 13;
            // 
            // engineValue
            // 
            this.engineValue.AutoSize = true;
            this.engineValue.Location = new System.Drawing.Point(340, 124);
            this.engineValue.Name = "engineValue";
            this.engineValue.Size = new System.Drawing.Size(13, 13);
            this.engineValue.TabIndex = 15;
            this.engineValue.Text = "0";
            // 
            // AddAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(420, 316);
            this.Controls.Add(this.engineValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.engineCapacityTrackbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddAutoForm";
            ((System.ComponentModel.ISupportInitialize)(this.engineCapacityTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar engineCapacityTrackbar;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label engineValue;
    }
}