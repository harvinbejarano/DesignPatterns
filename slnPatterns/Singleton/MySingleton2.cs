using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MySingleton2
    {
        private static MySingleton2 _instance = null;
        private static readonly object padlock = new object();

        private MySingleton2()
        {

        }

        public MySingleton2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySingleton2();
                        }
                    }
                }

                return _instance;
            }
        }


        public static string ReadFile(string path)
        {
            string text = "";
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd(); 
            }

            return text;
        }

    }
}
