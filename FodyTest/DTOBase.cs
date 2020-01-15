using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FodyTest
{
    public partial class DTOBase : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected internal ObjectState ObjectState = ObjectState.Unchanged;
        protected internal List<string> ModifiedProperties = new List<string>();

        protected void OnPropertyChanged(string propertyName, object before, object after) {
            ObjectState = ObjectState.Modified;

            if (!ModifiedProperties.Contains(propertyName))
                ModifiedProperties.Add(propertyName);

        }
    }
}
