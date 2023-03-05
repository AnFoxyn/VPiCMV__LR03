namespace EventsList.Models
{
    public class CityEvent
    {


        public string Image { get; }
        public string Header { get; }
        public string Date { get; }
        public string Description { get; }
        public string Price { get; }

        private string[] Categories;
        private string GetCategory;

        public bool CheckCategories(string checkCategory)
        {
            foreach (var categories in Categories)
                if (categories == checkCategory) return true;
            return GetCategory == checkCategory;
        }

        public CityEvent(string image, string header, string date, string description, string price, string[] categories, string getCategory)
        {
            Image = image;
            Header = header;
            Date = date;
            Description = description;
            Price = price;
            Categories = categories;
            GetCategory = getCategory;
        }
    }
}