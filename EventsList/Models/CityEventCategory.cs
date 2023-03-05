using System.Collections.ObjectModel;

namespace EventsList.Models
{
    public class CityEventCategory
    { 
        public string Category { get; }
        public string CategoryName { get; }
        public string CategoryIcon { get; }

        public ObservableCollection<CityEvent> Events
        {
            get
            {
                var Result = new ObservableCollection<CityEvent>();
                foreach (var Event in CityEventStorage.Me.events)
                    if (Event.CheckCategories(Category)) Result.Add(Event);
                return Result;
            }
        }

        public CityEventCategory(string categoryName, string categoryIcon, string category)
        {
            CategoryName = categoryName;
            CategoryIcon = categoryIcon;
            Category = category;
        }

    }
}