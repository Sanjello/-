using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace ShkolaDatabase
{
    public partial class Form1 : Form
    {
        List<Shkola> ShkolaList;
        BindingSource BindSource;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            ShkolaList = new List<Shkola>();
            BindSource = new BindingSource();

            BindSource.DataSource = ShkolaList;
            tabl_data.DataSource = BindSource;
            tabl_data.Columns["LastName"].HeaderText = "Прізвище";
            tabl_data.Columns["Sex"].HeaderText = "Стать";
            tabl_data.Columns["ClassNumber"].HeaderText = "Клас";
            tabl_data.Columns["Rating1"].HeaderText = "Оцінка_1";
            tabl_data.Columns["Rating2"].HeaderText = "Оцінка_2";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string sex = comboBox1.Text;
            double number = (double)numericUpDown1.Value;
            double r1 = (double)numericUpDown2.Value;
            double r2 = (double)numericUpDown3.Value;
            Shkola shkola = new Shkola(name, sex, number, r1, r2);
            try
            {
                BindSource.Add(shkola);
            }
            catch
            {

                MessageBox.Show("Введіть всі данні");
            }

        }
      
        

        private void saveasbinery_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter br = new BinaryFormatter();
                using(FileStream stream = new FileStream(saveFileDialog.FileName,FileMode.OpenOrCreate))
                {
                    br.Serialize(stream,ShkolaList);
                }
            }
        }

        private void saveasxml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xmls = new XmlSerializer(typeof(List<Shkola>));
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmls.Serialize(stream, ShkolaList);
                }
            }
        }

        private void saveasjson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Shkola>));
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, ShkolaList);
                }
            }
        }
        private void openasbinaery_Click(object sender, EventArgs e)
        {
            tabl_data.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    ShkolaList = binaryFormatter.Deserialize(file) as List<Shkola>;
                    if (ShkolaList != null)
                    {
                        for (int i = 0; i < ShkolaList.Count; i++)
                        {
                            BindSource.Add(ShkolaList[i]);
                        }
                    }
                }
            }
        }

        private void openasxml_Click(object sender, EventArgs e)
        {
            tabl_data.Rows.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xmlFormatter = new XmlSerializer(typeof(List<Shkola>));

                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    ShkolaList = xmlFormatter.Deserialize(file) as List<Shkola>;
                    if (ShkolaList != null)
                    {
                        for (int i = 0; i < ShkolaList.Count; i++)
                        {
                            BindSource.Add(ShkolaList[i]);
                        }
                    }
                }
            }
        }

        private void openasjson_Click(object sender, EventArgs e)
        {
            tabl_data.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Shkola>));
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    ShkolaList = jsonFormatter.ReadObject(file) as List<Shkola>;
                    if (ShkolaList != null)
                    {
                        for (int i = 0; i < ShkolaList.Count; i++)
                        {
                            BindSource.Add(ShkolaList[i]);
                        }
                    }
                }
            }
        }

        private void girl_but_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < ShkolaList.Count; i++)
            {
                if (ShkolaList[i].ClassNumber == (double)c_girl_num.Value)
                {
                    if (ShkolaList[i].Sex == "Жіноча")
                    {
                        temp++;
                    }
                }
            }
            girls_count_tb.Text = temp.ToString();
        }

        private void rating_but_Click(object sender, EventArgs e)
        {
            double rat = 0;
            double count = 0;
            for (int i = 0; i < ShkolaList.Count; i++)
            {
                if(ShkolaList[i].ClassNumber == (double)num_class_nd.Value)
                {
                    rat += ShkolaList[i].Rating1+ ShkolaList[i].Rating2;
                    count++;
                }
            }
            rezult.Text = Math.Round((rat / count),2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < tabl_data.RowCount; i++)
            {
                chart1.Series[0].Points.AddY(tabl_data.Rows[i].Cells["Rating1"].Value);
            }
        }
    }
}
