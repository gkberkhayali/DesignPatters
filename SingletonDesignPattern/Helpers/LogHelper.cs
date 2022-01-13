using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Helpers
{
    public class LogHelper
    {
        private static LogHelper _logHelper;

        private LogHelper()
        {

        }

        public static LogHelper GetInstance()
        {
            if(_logHelper == null)
            {
                _logHelper = new LogHelper();   
            }

            return _logHelper;
        }

        public void WriteInformativeLog (string log)
        {
            Console.WriteLine(log);
        }

    }
}
