using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace t_shirt_app
{
  public  class MainViewmodel: INotifyPropertyChanged
    {
        private string Name = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public string GetName()
        {
            return Name;
        }

    }
}
