using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Settings
    {
        private static Settings _instance;
        private static readonly object _sync = new object();

        private Settings()
        {
        }

        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new Settings();
                        }
                    }
                }

                return _instance;
            }
        }

        public string GetConfig(string configPath)
        {
            string fileContet = "";
            try
            {
                using (StreamReader sr = new StreamReader(configPath))
                {
                    fileContet = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return fileContet;
        }
    }
}
