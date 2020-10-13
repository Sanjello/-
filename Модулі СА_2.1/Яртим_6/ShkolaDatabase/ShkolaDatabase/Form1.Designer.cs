namespace ShkolaDatabase
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_add = new System.Windows.Forms.Button();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasbinery = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasxml = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasjson = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openasbinaery = new System.Windows.Forms.ToolStripMenuItem();
            this.openasxml = new System.Windows.Forms.ToolStripMenuItem();
            this.openasjson = new System.Windows.Forms.ToolStripMenuItem();
            this.girl_but = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabl_data = new System.Windows.Forms.DataGridView();
            this.rating_but = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rezult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_class_nd = new System.Windows.Forms.NumericUpDown();
            this.c_girl_num = new System.Windows.Forms.NumericUpDown();
            this.girls_count_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabl_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_class_nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_girl_num)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(80, 162);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(80, 18);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Class_num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rating_1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rating_2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox1.Location = new System.Drawing.Point(79, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(81, 95);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown2.TabIndex = 14;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(80, 121);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown3.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(319, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 178);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveasbinery,
            this.saveasxml,
            this.saveasjson});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveasbinery
            // 
            this.saveasbinery.Name = "saveasbinery";
            this.saveasbinery.Size = new System.Drawing.Size(107, 22);
            this.saveasbinery.Text = "Binery";
            this.saveasbinery.Click += new System.EventHandler(this.saveasbinery_Click);
            // 
            // saveasxml
            // 
            this.saveasxml.Name = "saveasxml";
            this.saveasxml.Size = new System.Drawing.Size(107, 22);
            this.saveasxml.Text = "Xml";
            this.saveasxml.Click += new System.EventHandler(this.saveasxml_Click);
            // 
            // saveasjson
            // 
            this.saveasjson.Name = "saveasjson";
            this.saveasjson.Size = new System.Drawing.Size(107, 22);
            this.saveasjson.Text = "Json";
            this.saveasjson.Click += new System.EventHandler(this.saveasjson_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openasbinaery,
            this.openasxml,
            this.openasjson});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openasbinaery
            // 
            this.openasbinaery.Name = "openasbinaery";
            this.openasbinaery.Size = new System.Drawing.Size(107, 22);
            this.openasbinaery.Text = "Binery";
            this.openasbinaery.Click += new System.EventHandler(this.openasbinaery_Click);
            // 
            // openasxml
            // 
            this.openasxml.Name = "openasxml";
            this.openasxml.Size = new System.Drawing.Size(107, 22);
            this.openasxml.Text = "Xml";
            this.openasxml.Click += new System.EventHandler(this.openasxml_Click);
            // 
            // openasjson
            // 
            this.openasjson.Name = "openasjson";
            this.openasjson.Size = new System.Drawing.Size(107, 22);
            this.openasjson.Text = "Json";
            this.openasjson.Click += new System.EventHandler(this.openasjson_Click);
            // 
            // girl_but
            // 
            this.girl_but.Location = new System.Drawing.Point(23, 347);
            this.girl_but.Name = "girl_but";
            this.girl_but.Size = new System.Drawing.Size(75, 23);
            this.girl_but.TabIndex = 19;
            this.girl_but.Text = "визначити";
            this.girl_but.UseVisualStyleBackColor = true;
            this.girl_but.Click += new System.EventHandler(this.girl_but_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "К-сть дівчат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name_tb);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 217);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // tabl_data
            // 
            this.tabl_data.AllowUserToAddRows = false;
            this.tabl_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabl_data.Location = new System.Drawing.Point(319, 189);
            this.tabl_data.Name = "tabl_data";
            this.tabl_data.Size = new System.Drawing.Size(469, 239);
            this.tabl_data.TabIndex = 22;
            // 
            // rating_but
            // 
            this.rating_but.Location = new System.Drawing.Point(206, 372);
            this.rating_but.Name = "rating_but";
            this.rating_but.Size = new System.Drawing.Size(75, 23);
            this.rating_but.TabIndex = 23;
            this.rating_but.Text = "визначити";
            this.rating_but.UseVisualStyleBackColor = true;
            this.rating_but.Click += new System.EventHandler(this.rating_but_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Введіть клас";
            // 
            // rezult
            // 
            this.rezult.Location = new System.Drawing.Point(192, 331);
            this.rezult.Name = "rezult";
            this.rezult.Size = new System.Drawing.Size(100, 20);
            this.rezult.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Середня оцінка";
            // 
            // num_class_nd
            // 
            this.num_class_nd.Location = new System.Drawing.Point(192, 297);
            this.num_class_nd.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_class_nd.Name = "num_class_nd";
            this.num_class_nd.Size = new System.Drawing.Size(100, 20);
            this.num_class_nd.TabIndex = 29;
            // 
            // c_girl_num
            // 
            this.c_girl_num.Location = new System.Drawing.Point(12, 297);
            this.c_girl_num.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.c_girl_num.Name = "c_girl_num";
            this.c_girl_num.Size = new System.Drawing.Size(100, 20);
            this.c_girl_num.TabIndex = 31;
            // 
            // girls_count_tb
            // 
            this.girls_count_tb.Location = new System.Drawing.Point(12, 321);
            this.girls_count_tb.Name = "girls_count_tb";
            this.girls_count_tb.Size = new System.Drawing.Size(100, 20);
            this.girls_count_tb.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Діаграма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girls_count_tb);
            this.Controls.Add(this.c_girl_num);
            this.Controls.Add(this.num_class_nd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rezult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rating_but);
            this.Controls.Add(this.tabl_data);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.girl_but);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabl_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_class_nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_girl_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasbinery;
        private System.Windows.Forms.ToolStripMenuItem saveasxml;
        private System.Windows.Forms.ToolStripMenuItem saveasjson;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openasbinaery;
        private System.Windows.Forms.ToolStripMenuItem openasxml;
        private System.Windows.Forms.ToolStripMenuItem openasjson;
        private System.Windows.Forms.Button girl_but;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tabl_data;
        private System.Windows.Forms.Button rating_but;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rezult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_class_nd;
        private System.Windows.Forms.NumericUpDown c_girl_num;
        private System.Windows.Forms.TextBox girls_count_tb;
        private System.Windows.Forms.Button button1;
    }
}

