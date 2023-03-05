using EventsList.Models;

namespace EventsList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly CityEventCategory[] cityEventCategories = new CityEventCategory[]
        {
            new CityEventCategory("Для детей", "Assets/Images/Header/Children.png", "Children"),
            new CityEventCategory("Спорт", "Assets/Images/Header/Sport.png", "Sport"),
            new CityEventCategory("Культура", "Assets/Images/Header/Culture.png", "Culture"),
            new CityEventCategory("Экскурсии", "Assets/Images/Header/Excursion.png", "Excursion"),
            new CityEventCategory("Образ жизни", "Assets/Images/Header/Lifestyle.png", "Lifestyle"),
            new CityEventCategory("Вечеринки", "Assets/Images/Header/Party.png", "Party"),
            new CityEventCategory("Образование", "Assets/Images/Header/Education.png", "Education"),
            new CityEventCategory("Онлайн", "Assets/Images/Header/Online.png", "Online"),
            new CityEventCategory("Шоу", "Assets/Images/Header/Show.png", "Show"),
        };
        public CityEventCategory[] CityEventCategories { get => cityEventCategories; }
    }
}