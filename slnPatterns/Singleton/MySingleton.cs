using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MySingleton
    {
        private static MySingleton _instance = null;
        private static readonly object padlock = new object();

        private MySingleton()
        {

        }

        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public string ReadFile(string path)
        {
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
          

            return text;
        }


    }
}
