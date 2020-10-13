using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Auto> AutoList;
        BindingSource BindSource;
        Random rnd = new Random(DateTime.Now.Millisecond);
        private void Form1_Load(object sender, EventArgs e)
        {
            AutoList = new List<Auto>();
            BindSource = new BindingSource();
            for (int i = 0; i < 5; i++)
            {
                Auto a = new Auto("Petrenko", "AO 777 BN", "BMW", rnd.Next(0, 100000), "Universitetska,4");
                AutoList.Add(a);
            }
            BindSource.DataSource = AutoList;
            autoGrid.DataSource = BindSource;
            autoGrid.Columns["LastName"].HeaderText = "Прізвище";
            autoGrid.Columns["AutoNumber"].HeaderText = "Номерний знак";
            autoGrid.Columns["AutoModel"].HeaderText = "Марка";
            autoGrid.Columns["Price"].HeaderText = "Ціна";
            autoGrid.Columns["HomeAdress"].HeaderText = "Адреса";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string sign = numberSignTextBox.Text;
            string model = modelTextBox.SelectedItem.ToString();
            double price = (double)priceTextBox.Value;
            string adress = adressTextBox.Text;
            Auto auto = new Auto(name, sign, model, price, adress);
            try
            {
                BindSource.Add(auto);
            }
            catch
            {

                MessageBox.Show("Введіть всі данні");
            }
        }

        private void GeneralPriceButton_Click(object sender, EventArgs e)
        {
            double generalPrice = 0;
            for (int i = 0; i < autoGrid.RowCount; i++)
            {
                if (autoGrid.Rows[i].Cells["AutoModel"].Value.ToString() == chooseModelForGeneralPrice.SelectedItem.ToString())
                {
                    generalPrice += Convert.ToDouble(autoGrid.Rows[i].Cells["Price"].Value);
                }
            }
            generalPriceTextBox.Text = generalPrice.ToString();
        }

        private void CalculateSevenNumbers_Click(object sender, EventArgs e)
        {
            int temp = 0;
            char[] signArray;
            for (int i = 0; i < autoGrid.RowCount; i++)
            {
                try
                {
                    if (autoGrid.Rows[i].Cells["AutoModel"].Value.ToString() == chooseModelForCalculateAmount.SelectedItem.ToString())
                    {
                        signArray = autoGrid.Rows[i].Cells["AutoNumber"].Value.ToString().ToArray();
                        for (int j = 0; j < signArray.Length; j++)
                        {
                            if (signArray[j].ToString() == "7")
                            {
                                temp++;
                                break;
                            }

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Виберіть марку");

                }

            }
            calculateAmountOfSevenSignsTextBox.Text = temp.ToString();
        }

        private void SaveAsBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (var file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(file, AutoList);
                }
            }
        }

        private void OpenAsBinary_Click(object sender, EventArgs e)
        {
            autoGrid.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    AutoList = binaryFormatter.Deserialize(file) as List<Auto>;
                    if (AutoList != null)
                    {
                        for (int i = 0; i < AutoList.Count; i++)
                        {
                            BindSource.Add(AutoList[i]);
                        }
                    }
                }
            }
        }

        private void SaveAsXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xmlFormatter = new XmlSerializer(typeof(List<Auto>));
                using (var file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmlFormatter.Serialize(file, AutoList);
                }
            }
        }

        private void OpenAsXML_Click(object sender, EventArgs e)
        {
            autoGrid.Rows.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var xmlFormatter = new XmlSerializer(typeof(List<Auto>));

                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    AutoList = xmlFormatter.Deserialize(file) as List<Auto>;
                    if (AutoList != null)
                    {
                        for (int i = 0; i < AutoList.Count; i++)
                        {
                            BindSource.Add(AutoList[i]);
                        }
                    }
                }
            }
        }

        private void SaveAsJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Auto>));
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, AutoList);
                }
            }
        }

        private void OpenAsJson_Click(object sender, EventArgs e)
        {
            autoGrid.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Auto>));
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    AutoList = jsonFormatter.ReadObject(file) as List<Auto>;
                    if (AutoList != null)
                    {
                        for (int i = 0; i < AutoList.Count; i++)
                        {
                            BindSource.Add(AutoList[i]);
                        }
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < autoGrid.RowCount; i++)
            {
                chart1.Series[0].Points.AddY(autoGrid.Rows[i].Cells["Price"].Value);
            }
        }
    }
}
