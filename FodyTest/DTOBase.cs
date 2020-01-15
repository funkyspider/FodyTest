using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FodyTest
{
    public partial class DTOBase : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected internal ObjectState _objectState = ObjectState.Unchanged;
        protected internal List<string> _modifiedProperties = new List<string>();

        protected void OnPropertyChanged(string propertyName, object before, object after) {
            _objectState = ObjectState.Modified;

            if (!_modifiedProperties.Contains(propertyName))
                _modifiedProperties.Add(propertyName);

        }
    }
}
