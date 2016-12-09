using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Framework.Core
{
    
        public class Logger
        {
            private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            public static void LogToFile(String message)
            {
                log.Info(message);
            }

        }
    }

