using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginWindow.Model;

namespace LoginWindow
{
    public class ViewModel : User
    {
        public ViewModel()
        {
            FirstName = "Kil-Dong";
            LastName = "Hong";
        }
    }
}
