using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;
using VierGewinnt.Core.Interfaces;
using VierGewinnt.WpfClient.Annotations;

namespace VierGewinnt.WpfClient
{
    public class FieldNotifyingDecorator : IField, INotifyPropertyChanged
    {
        private readonly IField _field;

        public FieldNotifyingDecorator([NotNull] IField field)
        {
            if (field == null) throw new ArgumentNullException(nameof(field));
            _field = field;
        }

        public GamePiece GamePiece
        {
            get => _field.GamePiece;
            set 
            {
                if(_field.GamePiece == value) return;
                _field.GamePiece = value;
                OnPropertyChanged();
            }
        }
        public int X => _field.X;
        public int Y => _field.Y;

        public override string ToString()
        {
            return _field.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
