namespace AutoDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.autoGrid = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberSignTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseModelForGeneralPrice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generalPriceTextBox = new System.Windows.Forms.TextBox();
            this.generalPriceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseModelForCalculateAmount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateAmountOfSevenSignsTextBox = new System.Windows.Forms.TextBox();
            this.calculateSevenNumbers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.autoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoGrid
            // 
            this.autoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoGrid.Location = new System.Drawing.Point(299, 12);
            this.autoGrid.Name = "autoGrid";
            this.autoGrid.Size = new System.Drawing.Size(518, 224);
            this.autoGrid.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(105, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // numberSignTextBox
            // 
            this.numberSignTextBox.Location = new System.Drawing.Point(105, 60);
            this.numberSignTextBox.Name = "numberSignTextBox";
            this.numberSignTextBox.Size = new System.Drawing.Size(144, 20);
            this.numberSignTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номерний знак";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Марка";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelTextBox.FormattingEnabled = true;
            this.modelTextBox.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Porshe",
            "Toyota",
            "Citroen",
            "Pezho",
            "Lada"});
            this.modelTextBox.Location = new System.Drawing.Point(105, 86);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(144, 21);
            this.modelTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(105, 113);
            this.priceTextBox.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(144, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ціна";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(105, 139);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(144, 20);
            this.adressTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Адреса";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(59, 165);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.adressTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numberSignTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 211);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // chooseModelForGeneralPrice
            // 
            this.chooseModelForGeneralPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseModelForGeneralPrice.FormattingEnabled = true;
            this.chooseModelForGeneralPrice.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Porshe",
            "Toyota",
            "Citroen",
            "Pezho",
            "Lada"});
            this.chooseModelForGeneralPrice.Location = new System.Drawing.Point(22, 43);
            this.chooseModelForGeneralPrice.Name = "chooseModelForGeneralPrice";
            this.chooseModelForGeneralPrice.Size = new System.Drawing.Size(144, 21);
            this.chooseModelForGeneralPrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Виберіть марку";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Загальна вартість";
            // 
            // generalPriceTextBox
            // 
            this.generalPriceTextBox.Location = new System.Drawing.Point(22, 96);
            this.generalPriceTextBox.Name = "generalPriceTextBox";
            this.generalPriceTextBox.Size = new System.Drawing.Size(144, 20);
            this.generalPriceTextBox.TabIndex = 19;
            // 
            // generalPriceButton
            // 
            this.generalPriceButton.Location = new System.Drawing.Point(57, 122);
            this.generalPriceButton.Name = "generalPriceButton";
            this.generalPriceButton.Size = new System.Drawing.Size(74, 22);
            this.generalPriceButton.TabIndex = 20;
            this.generalPriceButton.Text = "Визначити";
            this.generalPriceButton.UseVisualStyleBackColor = true;
            this.generalPriceButton.Click += new System.EventHandler(this.GeneralPriceButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generalPriceButton);
            this.groupBox2.Controls.Add(this.generalPriceTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chooseModelForGeneralPrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 169);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // chooseModelForCalculateAmount
            // 
            this.chooseModelForCalculateAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseModelForCalculateAmount.FormattingEnabled = true;
            this.chooseModelForCalculateAmount.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Porshe",
            "Toyota",
            "Citroen",
            "Pezho",
            "Lada"});
            this.chooseModelForCalculateAmount.Location = new System.Drawing.Point(16, 35);
            this.chooseModelForCalculateAmount.Name = "chooseModelForCalculateAmount";
            this.chooseModelForCalculateAmount.Size = new System.Drawing.Size(144, 21);
            this.chooseModelForCalculateAmount.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Виберіть марку";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "К-ть машин,в яких є 7 в номері";
            // 
            // calculateAmountOfSevenSignsTextBox
            // 
            this.calculateAmountOfSevenSignsTextBox.Location = new System.Drawing.Point(16, 89);
            this.calculateAmountOfSevenSignsTextBox.Name = "calculateAmountOfSevenSignsTextBox";
            this.calculateAmountOfSevenSignsTextBox.Size = new System.Drawing.Size(144, 20);
            this.calculateAmountOfSevenSignsTextBox.TabIndex = 25;
            // 
            // calculateSevenNumbers
            // 
            this.calculateSevenNumbers.Location = new System.Drawing.Point(49, 114);
            this.calculateSevenNumbers.Name = "calculateSevenNumbers";
            this.calculateSevenNumbers.Size = new System.Drawing.Size(74, 22);
            this.calculateSevenNumbers.TabIndex = 26;
            this.calculateSevenNumbers.Text = "Визначити";
            this.calculateSevenNumbers.UseVisualStyleBackColor = true;
            this.calculateSevenNumbers.Click += new System.EventHandler(this.CalculateSevenNumbers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.відкритиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsBinary,
            this.saveAsXML,
            this.saveAsJson});
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAsBinary,
            this.openAsXML,
            this.openAsJson});
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // openAsBinary
            // 
            this.openAsBinary.Name = "openAsBinary";
            this.openAsBinary.Size = new System.Drawing.Size(180, 22);
            this.openAsBinary.Text = "Binary";
            this.openAsBinary.Click += new System.EventHandler(this.OpenAsBinary_Click);
            // 
            // openAsXML
            // 
            this.openAsXML.Name = "openAsXML";
            this.openAsXML.Size = new System.Drawing.Size(180, 22);
            this.openAsXML.Text = "XML";
            this.openAsXML.Click += new System.EventHandler(this.OpenAsXML_Click);
            // 
            // openAsJson
            // 
            this.openAsJson.Name = "openAsJson";
            this.openAsJson.Size = new System.Drawing.Size(180, 22);
            this.openAsJson.Text = "Json";
            this.openAsJson.Click += new System.EventHandler(this.OpenAsJson_Click);
            // 
            // saveAsBinary
            // 
            this.saveAsBinary.Name = "saveAsBinary";
            this.saveAsBinary.Size = new System.Drawing.Size(180, 22);
            this.saveAsBinary.Text = "Binary";
            this.saveAsBinary.Click += new System.EventHandler(this.SaveAsBinary_Click);
            // 
            // saveAsXML
            // 
            this.saveAsXML.Name = "saveAsXML";
            this.saveAsXML.Size = new System.Drawing.Size(180, 22);
            this.saveAsXML.Text = "XML";
            this.saveAsXML.Click += new System.EventHandler(this.SaveAsXML_Click);
            // 
            // saveAsJson
            // 
            this.saveAsJson.Name = "saveAsJson";
            this.saveAsJson.Size = new System.Drawing.Size(180, 22);
            this.saveAsJson.Text = "Json";
            this.saveAsJson.Click += new System.EventHandler(this.SaveAsJson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calculateSevenNumbers);
            this.groupBox3.Controls.Add(this.calculateAmountOfSevenSignsTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chooseModelForCalculateAmount);
            this.groupBox3.Location = new System.Drawing.Point(191, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 160);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "Діаграма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(454, 242);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(306, 139);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autoGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView autoGrid;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberSignTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modelTextBox;
        private System.Windows.Forms.NumericUpDown priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox chooseModelForGeneralPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox generalPriceTextBox;
        private System.Windows.Forms.Button generalPriceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox chooseModelForCalculateAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox calculateAmountOfSevenSignsTextBox;
        private System.Windows.Forms.Button calculateSevenNumbers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsBinary;
        private System.Windows.Forms.ToolStripMenuItem saveAsXML;
        private System.Windows.Forms.ToolStripMenuItem saveAsJson;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAsBinary;
        private System.Windows.Forms.ToolStripMenuItem openAsXML;
        private System.Windows.Forms.ToolStripMenuItem openAsJson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

