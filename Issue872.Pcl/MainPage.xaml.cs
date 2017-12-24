using System.Linq;

namespace Issue872
{
    public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();

            VM[] vm = Enumerable.Range(1, 23).Select(i => new VM { I = i, File = $"disk{i}.png", Url = $"http://via.placeholder.com/2000x2000?text={i}" }).ToArray();
            vm[0].Url = "https://i.imgur.com/NnzxG4S.jpg";
            vm[1].Url = "https://i.imgur.com/w439mEw.jpg";
            vm[2].Url = "https://i.imgur.com/2XqQpwG.jpg";
            vm[3].Url = "https://i.imgur.com/tEVFZ2v.jpg";
            vm[4].Url = "https://i.imgur.com/cpIrOo1.jpg";

            list.ItemsSource = vm;
		}
    }
}
