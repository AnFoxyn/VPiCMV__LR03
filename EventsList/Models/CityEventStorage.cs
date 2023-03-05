using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace EventsList.Models
{
    public class CityEventStorage
    {
        private static readonly CityEventStorage me = new();
        public static CityEventStorage Me { get => me; }

        public CityEvent[] events;
        public string Error = "";

        private CityEventStorage() { events = Loader(); }

        private static string Val(XAttribute? a) => a == null ? "" : a.Value;
        private CityEvent[] Loader()
        {
            List<CityEvent> list = new();
            XDocument xdoc;
            try { xdoc = XDocument.Load("../../../CityEventStorage.xml"); }
            catch (Exception ex) { Error = ex.Message; return list.ToArray(); }

            XElement? events = xdoc.Element("Events");

            if (events == null) { Error = "Не найден корневой тег Events"; return list.ToArray(); }

            foreach (XElement Event in events.Elements("Event"))
            {
                XElement? image = Event.Element("Image");
                XElement? header = Event.Element("Header");
                XElement? date = Event.Element("Date");
                XElement? description = Event.Element("Description");
                XElement? price = Event.Element("Price");
                XElement? categories = Event.Element("Category");

                if (header == null || image == null || date == null || categories == null) continue;

                string setImage = Val(image.Attribute("data"));
                string setHeader = Val(header.Attribute("data"));
                string setDate = Val(date.Attribute("data"));
                string setDescription = description == null ? "" : Val(header.Attribute("data"));
                string setPrice = price == null ? "" : Val(price.Attribute("data")) + " ₽";
                List<string> setCategories = new();
                foreach (XElement cat in categories.Elements("CategoryItem")) setCategories.Add(Val(cat.Attribute("data")));
                string setGetCategory = Val(categories.Attribute("get"));

                list.Add(new CityEvent(setImage, setHeader, setDate, setDescription, setPrice, setCategories.ToArray(), setGetCategory));
            }
            return list.ToArray();
        }
    }
}
