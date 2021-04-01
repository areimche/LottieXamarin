using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Example.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListViewPage : ContentPage
    {
        public ObservableCollection<INotifyPropertyChanged> Items { get; set; }

        public MyListViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Items = new ObservableCollection<INotifyPropertyChanged>
            {
                new DemoCellViewModel{Title="Item 1",Animation="lottiefiles_com_Camera.json"},
                new DemoCellViewModel{Title="Item 2",Animation="lottiefiles_com_Emoji_Shock.json"},
                new DemoCellViewModel{Title="Item 3",Animation="lottiefiles_com_Emoji_Tongue.json"},
                new DemoCellViewModel{Title="Item 4",Animation="lottiefiles_com_Emoji_Wink.json"},
                new DemoCellViewModel{Title="Item 5",Animation="lottiefiles_com_Beating_Heart.json"},
                new DemoCellViewModel{Title="Item 6",Animation="lottiefiles_com_Favorite_Star.json"},
                new DemoCellViewModel{Title="Item 7",Animation="lottiefiles_com_Camera.json"},
                new DemoCellViewModel{Title="Item 8",Animation="lottiefiles_com_Emoji_Shock.json"},
                new DemoCellViewModel{Title="Item 9",Animation="lottiefiles_com_Emoji_Tongue.json"},
                new DemoCellViewModel{Title="Item 10",Animation="lottiefiles_com_Emoji_Wink.json"},
                new DemoCellViewModel{Title="Item 11",Animation="lottiefiles_com_Beating_Heart.json"},
                new DemoCellViewModel{Title="Item 12",Animation="lottiefiles_com_Favorite_Star.json"},
                new DemoCellViewModel{Title="Item 13",Animation="lottiefiles_com_Camera.json"},
                new DemoCellViewModel{Title="Item 14",Animation="lottiefiles_com_Emoji_Shock.json"},
                new DemoCellViewModel{Title="Item 15",Animation="lottiefiles_com_Emoji_Tongue.json"},
                new DemoCellViewModel{Title="Item 16",Animation="lottiefiles_com_Emoji_Wink.json"},
                new DemoCellViewModel{Title="Item 17",Animation="lottiefiles_com_Beating_Heart.json"},
                new DemoCellViewModel{Title="Item 18",Animation="lottiefiles_com_Favorite_Star.json"},
                new DemoCellViewModel{Title="Item 19",Animation="lottiefiles_com_Camera.json"},
                new DemoCellViewModel{Title="Item 20",Animation="lottiefiles_com_Emoji_Shock.json"},
                new DemoCellViewModel{Title="Item 21",Animation="lottiefiles_com_Emoji_Tongue.json"},
                new DemoCellViewModel{Title="Item 22",Animation="lottiefiles_com_Emoji_Wink.json"},
                new DemoCellViewModel{Title="Item 23",Animation="lottiefiles_com_Beating_Heart.json"},
                new DemoCellViewModel{Title="Item 24",Animation="lottiefiles_com_Favorite_Star.json"}
            };

            MyCollectionView.ItemsSource = Items;
        }
    }

    public class DemoCellViewModel : BaseViewModel
    {
        private string _animation;

        private string _title;

        public DemoCellViewModel()
        {
        }

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        public string Animation
        {
            get => _animation;
            set => Set(ref _animation, value);
        }
    }
}
