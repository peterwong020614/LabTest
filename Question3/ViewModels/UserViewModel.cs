using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.ViewModels
{
    public partial class UserViewModel:ObservableObject
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        private string body;
        public string Body
        {
            get => body;
            set => SetProperty(ref body, value);
        }
    }
}
