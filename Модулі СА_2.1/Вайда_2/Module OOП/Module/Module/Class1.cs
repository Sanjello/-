using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Module
{
    public class Exporter
    {
        private int exporterCountry;

        public int Code { get; set; }
        public string Name { get; set; }
        public string ExporterCountry { get; set; }
        public int UnitsCount { get; set; }

        public Exporter(int code, string name, string exporterCountry, int unitsCount)
        {
            Code = code;
            Name = name;
            ExporterCountry = exporterCountry;
            UnitsCount = unitsCount;
        }

        public Exporter(int code, string name, int exporterCountry, int unitsCount)
        {
            Code = code;
            Name = name;
            this.exporterCountry = exporterCountry;
            UnitsCount = unitsCount;
        }

        public XmlElement ToXmlElement(XmlDocument doc)
        {
            XmlElement export = doc.CreateElement("export");
            export.InnerText = Name;
            export.SetAttribute("Code", Code.ToString());
            export.SetAttribute("Name", Name.ToString());
            export.SetAttribute("ExporterCountry", ExporterCountry.ToString());
            export.SetAttribute("UnitsCount", UnitsCount.ToString());
            return export;
        }

        public static Exporter FromXmlElement(XmlElement element)
        {
            string name = element.InnerText;
            int code = Convert.ToInt32(element.GetAttribute("Code"));
            int exporterCountry = Convert.ToInt32(element.GetAttribute("Exporter Country"));
            int UnitsCount = Convert.ToInt32(element.GetAttribute("UnitsCount"));
            return new Exporter(code, name, exporterCountry, UnitsCount);
        }
        public override string ToString()
        {
            return $"{Name}  {Code}  {UnitsCount}";
        }
    }
}
