using System.ComponentModel;

namespace workshopProsit3
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private string _inputText = "";
        private string _upperString = "";

        public string InputText
        {
            get { return _inputText; }
            set
            {
                if (_inputText != value)
                {
                    _inputText = value;
                    OnPropertyChanged(nameof(InputText));
                    ConvertToUpper();
                }
            }
        }

        public string UpperString
        {
            get { return _upperString; }
            private set
            {
                if (_upperString != value)
                {
                    _upperString = value;
                    OnPropertyChanged(nameof(UpperString));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void ConvertToUpper()
        {
            Model model = new Model();
            UpperString = model.ConvertToUpper(InputText);
        }

        // Les bindings ne savent pas quand la valeur change, Invoke de PropertyChanged
        // permet de dire de se mettre à jour avec la nouvelle valeur
        // C'est pour ça qu'on lance OnPropertyChanged quand le set n'est pas le même
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
