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
            }).ToArray();

            list.ItemsSource = items;
        }
    }
}
