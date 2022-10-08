using System.Collections.Generic;
using ReactiveUI;

namespace ReferenceIssue.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private Dictionary<uint, string> _someDictionary = new() 
        {
            [1] = "One",
            [2] = "Two"
        };

        public Dictionary<uint, string> SomeDictionary
        {
            get => _someDictionary;
            set => this.RaiseAndSetIfChanged(ref _someDictionary, value);
        } 
        
        public string _defaultValue = "One";
        public string DefaultValue 
        {
            get => _defaultValue;
            set => this.RaiseAndSetIfChanged(ref _defaultValue, value);
        }

        public void ChangeReference()
        {
            SomeDictionary = new() 
            {
                [1] = "One",
                [2] = "Two"
            };
        }
    }
}
