using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.Models
{
    public class Login:INotifyPropertyChanged
    {
        private string userName;
        public string UserName 
        {
            get=>userName; 
            set 
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
