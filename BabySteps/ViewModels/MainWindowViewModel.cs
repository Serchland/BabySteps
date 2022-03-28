using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace BabySteps.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            _items = new ObservableCollection<Item>() { new Item() { Id = "0", Name = "Madrid" }, new Item() { Id = "0", Name = "Paris" }, new Item() { Id = "0", Name = "Roma" }, new Item() { Id = "0", Name = "Berlín" } };
        }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private DelegateCommand _selectedCommand;
        public DelegateCommand SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            int i = 0;
        }
    }

    public class Item: BindableBase
    {
        public Item()
        {
            _additionalItems = new ObservableCollection<string>() { "1", "2", "3" };
        }

        private DelegateCommand _selectedCommand;
        public DelegateCommand SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            int i = 0;
        }


        private string _id;
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private ObservableCollection<string> _additionalItems;
        public ObservableCollection<string> AdditionItems
        {
            get { return _additionalItems; }
            set { SetProperty(ref _additionalItems, value); }
        }
    }
}
