using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace XamarinPropertyChanged
{
    public class MainPageViewModel : BaseViewModel
    {
        private List<string> items = new List<string>();

        public List<string> Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            LoadData();
        }

        async void LoadData()
        {
            await Task.Delay(500);
            Items = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }
    }
}
