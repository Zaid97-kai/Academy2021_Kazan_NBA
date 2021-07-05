using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Kazan2021_Academy_NBA
{
    public partial class Player
    {
        public int Experience
        {
            get
            {
                int years = DateTime.Now.Year - JoinYear.Year;
                return years;
            }
        }
    }
}
