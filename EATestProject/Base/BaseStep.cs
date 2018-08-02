using EAAutoFramework.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
   public class BaseStep:Base
    {
        public static void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
        }
    }
}
