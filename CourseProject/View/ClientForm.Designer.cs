namespace CourseProject.View
{
    partial class ClientForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.selectedAutosLV = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maxEngineLabel = new System.Windows.Forms.Label();
            this.minEngineLabel = new System.Windows.Forms.Label();
            this.maxEngine = new System.Windows.Forms.TrackBar();
            this.minEngine = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.distance = new System.Windows.Forms.GroupBox();
            this.maxDistLabel = new System.Windows.Forms.Label();
            this.minDistLabel = new System.Windows.Forms.Label();
            this.maxDist = new System.Windows.Forms.TrackBar();
            this.minDist = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxVal = new System.Windows.Forms.Label();
            this.minVal = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.TrackBar();
            this.minPrice = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statisticButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEngine)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.distance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDist)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPrice)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Letter Gothic Std", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(41, 577);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(243, 48);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectedAutosLV
            // 
            this.selectedAutosLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.Model,
            this.Price,
            this.distanceHeader});
            this.selectedAutosLV.Location = new System.Drawing.Point(7, 22);
            this.selectedAutosLV.Margin = new System.Windows.Forms.Padding(4);
            this.selectedAutosLV.Name = "selectedAutosLV";
            this.selectedAutosLV.Size = new System.Drawing.Size(810, 603);
            this.selectedAutosLV.TabIndex = 5;
            this.selectedAutosLV.UseCompatibleStateImageBehavior = false;
            this.selectedAutosLV.View = System.Windows.Forms.View.Details;
            // 
            // Brand
            // 
            this.Brand.Text = "Марка";
            this.Brand.Width = 200;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 217;
            // 
            // distanceHeader
            // 
            this.distanceHeader.Text = "Пробег";
            this.distanceHeader.Width = 189;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(326, 633);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подбор по параметрам";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.maxEngineLabel);
            this.groupBox4.Controls.Add(this.minEngineLabel);
            this.groupBox4.Controls.Add(this.maxEngine);
            this.groupBox4.Controls.Add(this.minEngine);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 324);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(312, 116);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Объем двигателя";
            // 
            // maxEngineLabel
            // 
            this.maxEngineLabel.AutoSize = true;
            this.maxEngineLabel.Location = new System.Drawing.Point(226, 74);
            this.maxEngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxEngineLabel.Name = "maxEngineLabel";
            this.maxEngineLabel.Size = new System.Drawing.Size(52, 16);
            this.maxEngineLabel.TabIndex = 27;
            this.maxEngineLabel.Text = "0 куб.м";
            // 
            // minEngineLabel
            // 
            this.minEngineLabel.AutoSize = true;
            this.minEngineLabel.Location = new System.Drawing.Point(226, 22);
            this.minEngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minEngineLabel.Name = "minEngineLabel";
            this.minEngineLabel.Size = new System.Drawing.Size(52, 16);
            this.minEngineLabel.TabIndex = 26;
            this.minEngineLabel.Text = "0 куб.м";
            // 
            // maxEngine
            // 
            this.maxEngine.AutoSize = false;
            this.maxEngine.Location = new System.Drawing.Point(46, 74);
            this.maxEngine.Margin = new System.Windows.Forms.Padding(4);
            this.maxEngine.Maximum = 100;
            this.maxEngine.Minimum = 1;
            this.maxEngine.Name = "maxEngine";
            this.maxEngine.Size = new System.Drawing.Size(183, 41);
            this.maxEngine.TabIndex = 25;
            this.maxEngine.Value = 1;
            this.maxEngine.Scroll += new System.EventHandler(this.maxEngine_Scroll);
            // 
            // minEngine
            // 
            this.minEngine.AutoSize = false;
            this.minEngine.Location = new System.Drawing.Point(46, 22);
            this.minEngine.Margin = new System.Windows.Forms.Padding(4);
            this.minEngine.Maximum = 100;
            this.minEngine.Minimum = 1;
            this.minEngine.Name = "minEngine";
            this.minEngine.Size = new System.Drawing.Size(183, 45);
            this.minEngine.TabIndex = 24;
            this.minEngine.Value = 1;
            this.minEngine.Scroll += new System.EventHandler(this.minEngine_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "От";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "До";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.brandBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 46);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Марка";
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
            this.brandBox.Location = new System.Drawing.Point(7, 16);
            this.brandBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(298, 23);
            this.brandBox.TabIndex = 25;
            // 
            // distance
            // 
            this.distance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.distance.Controls.Add(this.maxDistLabel);
            this.distance.Controls.Add(this.minDistLabel);
            this.distance.Controls.Add(this.maxDist);
            this.distance.Controls.Add(this.minDist);
            this.distance.Controls.Add(this.label3);
            this.distance.Controls.Add(this.label7);
            this.distance.Location = new System.Drawing.Point(7, 200);
            this.distance.Margin = new System.Windows.Forms.Padding(4);
            this.distance.Name = "distance";
            this.distance.Padding = new System.Windows.Forms.Padding(4);
            this.distance.Size = new System.Drawing.Size(312, 116);
            this.distance.TabIndex = 28;
            this.distance.TabStop = false;
            this.distance.Text = "Пробег";
            // 
            // maxDistLabel
            // 
            this.maxDistLabel.AutoSize = true;
            this.maxDistLabel.Location = new System.Drawing.Point(226, 74);
            this.maxDistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxDistLabel.Name = "maxDistLabel";
            this.maxDistLabel.Size = new System.Drawing.Size(63, 16);
            this.maxDistLabel.TabIndex = 27;
            this.maxDistLabel.Text = "0 тыс. км";
            // 
            // minDistLabel
            // 
            this.minDistLabel.AutoSize = true;
            this.minDistLabel.Location = new System.Drawing.Point(226, 22);
            this.minDistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minDistLabel.Name = "minDistLabel";
            this.minDistLabel.Size = new System.Drawing.Size(63, 16);
            this.minDistLabel.TabIndex = 26;
            this.minDistLabel.Text = "0 тыс. км";
            // 
            // maxDist
            // 
            this.maxDist.AutoSize = false;
            this.maxDist.Location = new System.Drawing.Point(46, 74);
            this.maxDist.Margin = new System.Windows.Forms.Padding(4);
            this.maxDist.Maximum = 100;
            this.maxDist.Name = "maxDist";
            this.maxDist.Size = new System.Drawing.Size(183, 41);
            this.maxDist.TabIndex = 25;
            this.maxDist.Scroll += new System.EventHandler(this.maxDist_Scroll);
            // 
            // minDist
            // 
            this.minDist.AutoSize = false;
            this.minDist.Location = new System.Drawing.Point(46, 22);
            this.minDist.Margin = new System.Windows.Forms.Padding(4);
            this.minDist.Maximum = 100;
            this.minDist.Name = "minDist";
            this.minDist.Size = new System.Drawing.Size(183, 45);
            this.minDist.TabIndex = 24;
            this.minDist.Scroll += new System.EventHandler(this.minDist_Scroll_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "До";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.maxVal);
            this.groupBox2.Controls.Add(this.minVal);
            this.groupBox2.Controls.Add(this.maxPrice);
            this.groupBox2.Controls.Add(this.minPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(312, 116);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стоимость";
            // 
            // maxVal
            // 
            this.maxVal.AutoSize = true;
            this.maxVal.Font = new System.Drawing.Font("Lucida Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVal.Location = new System.Drawing.Point(237, 74);
            this.maxVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(26, 17);
            this.maxVal.TabIndex = 27;
            this.maxVal.Text = "0$";
            // 
            // minVal
            // 
            this.minVal.AutoSize = true;
            this.minVal.Font = new System.Drawing.Font("Lucida Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVal.Location = new System.Drawing.Point(237, 22);
            this.minVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minVal.Name = "minVal";
            this.minVal.Size = new System.Drawing.Size(26, 17);
            this.minVal.TabIndex = 26;
            this.minVal.Text = "0$";
            // 
            // maxPrice
            // 
            this.maxPrice.AutoSize = false;
            this.maxPrice.Location = new System.Drawing.Point(46, 74);
            this.maxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.maxPrice.Maximum = 100;
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(183, 41);
            this.maxPrice.TabIndex = 25;
            this.maxPrice.Scroll += new System.EventHandler(this.maxPrice_Scroll);
            // 
            // minPrice
            // 
            this.minPrice.AutoSize = false;
            this.minPrice.Location = new System.Drawing.Point(46, 22);
            this.minPrice.Margin = new System.Windows.Forms.Padding(4);
            this.minPrice.Maximum = 100;
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(183, 45);
            this.minPrice.TabIndex = 24;
            this.minPrice.Scroll += new System.EventHandler(this.minPrice_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "От";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "До";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.statisticButton);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(1176, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 190);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Действия";
            // 
            // statisticButton
            // 
            this.statisticButton.Location = new System.Drawing.Point(7, 113);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(149, 41);
            this.statisticButton.TabIndex = 2;
            this.statisticButton.Text = "Статистика";
            this.statisticButton.UseVisualStyleBackColor = true;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сделать заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.selectedAutosLV);
            this.groupBox6.Location = new System.Drawing.Point(345, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(825, 633);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выбранные авто";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1350, 660);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "Клиентский профиль";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEngine)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.distance.ResumeLayout(false);
            this.distance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPrice)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView selectedAutosLV;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar maxPrice;
        private System.Windows.Forms.TrackBar minPrice;
        private System.Windows.Forms.Label maxVal;
        private System.Windows.Forms.Label minVal;
        private System.Windows.Forms.GroupBox distance;
        private System.Windows.Forms.Label maxDistLabel;
        private System.Windows.Forms.Label minDistLabel;
        private System.Windows.Forms.TrackBar maxDist;
        private System.Windows.Forms.TrackBar minDist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label maxEngineLabel;
        private System.Windows.Forms.Label minEngineLabel;
        private System.Windows.Forms.TrackBar maxEngine;
        private System.Windows.Forms.TrackBar minEngine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader distanceHeader;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button statisticButton;
    }
}