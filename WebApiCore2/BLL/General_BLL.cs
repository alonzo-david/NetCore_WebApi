using System.ComponentModel;

namespace WebApiCore2.BLL
{
    public class General_BLL
    {
        public enum enum_conection
        {
            DefaultConnection = 1,
        }
               

        public static string name_connection(General_BLL.enum_conection strBase)
        {            
            var wd = (enum_conection)5;
            return wd.ToString();
        }

        
    }
}
