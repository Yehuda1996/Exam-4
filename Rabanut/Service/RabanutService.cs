using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Rabanut.Configuration.Connection;

namespace Rabanut.Service
{
    internal static class RabanutService
    {
        public static void CreateXMLIfNotExist()
        {
            if (!File.Exists(rabanutPath))
            {
                XDocument document = XDocument.Parse(@"<Queries></Queries>");
                document.Save(rabanutPath);
            }
        }

        public static void AddQuery(string Day, string DayMonth, string Month, string Year, string Result)
        {
            XDocument document = XDocument.Load(rabanutPath);
            XElement? queries = document.Descendants("Queries").FirstOrDefault();
            if (queries == null)
            {
                return;
            }
            XElement? query = new(
                "Query",
                new XElement("Day", Day),
                new XElement("DayMonth", DayMonth),
                new XElement("Month", Month),
                new XElement("Year", Year),
                new XElement("Result", Result)
                );
            queries.Add(query);
            document.Save(rabanutPath);

        }
    }
}
