using System.Linq;

namespace Issue872
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var items = Enumerable.Range(1, 23).Select(i => new VM
            {
                Placeholder = $"placeholder{i}.png",
                Url = $"http://via.placeholder.com/2000x2000?text=aaa{i}"
            }).ToArray();

            list.ItemsSource = items;
        }
    }
}
