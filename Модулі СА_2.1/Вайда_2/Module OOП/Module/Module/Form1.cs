using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;

namespace Module
{
    public partial class Form1 : Form
    {
        List<Exporter> ExporterList;
        BindingSource BindSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExporterList = new List<Exporter>();
            BindSource = new BindingSource();
            var item1 = new Exporter(5048, "Chips Lays", "USA", 41);
            var item2 = new Exporter(5049, "Chips Luxe", "Ukraine", 89);
            var item3 = new Exporter(5050, "Milk Slovyanochka", "Vietnam", 100);
            var item4 = new Exporter(5051, "Coca Cola", "USA", 250);
            var item5 = new Exporter(5052, "Pepsi", "Camboja", 12);
            ExporterList.Add(item1);
            ExporterList.Add(item2);
            ExporterList.Add(item3);
            ExporterList.Add(item4);
            ExporterList.Add(item5);
            BindSource.DataSource = ExporterList;
            dataGridView1.DataSource = BindSource;
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["Code"].HeaderText = "Code";
            dataGridView1.Columns["ExporterCountry"].HeaderText = "ExporterCountry";
            dataGridView1.Columns["UnitsCount"].HeaderText = "UnitsCount";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindByCode_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells["Code"].Value) == a)
                {
                    MessageBox.Show(ExporterList[i].ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                BindSource.Clear();
                foreach (Exporter b in (List<Exporter>)bf.Deserialize(fs))
                {
                    BindSource.Add(b);
                }
                fs.Close();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ExporterList);
                fs.Close();
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private XmlElement createXmlExporterList(XmlDocument doc)
        {
            XmlElement subscriberList = doc.CreateElement("exporterList");
            foreach (var item in ExporterList)
                subscriberList.AppendChild(item.ToXmlElement(doc));
            return subscriberList;
        }

        private void toXMLToolStripMenuItem_Click(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);
            doc.AppendChild(createXmlExporterList(doc));
            doc.Save(fileName);
        }
    }
}
