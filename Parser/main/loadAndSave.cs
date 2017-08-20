using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Parser.main
{
    class loadAndSave
    {
        string st = @"Files\listBots.txt";
        string proxiFileName = @"Files\proxi.txt";
        
        public List<Bot> loadBotsFromFile(string fileName)
        {
            List<Bot> bots = new List<Bot>();
            using (Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(stream))
            {
                string read = null;
                while ((read = sr.ReadLine()) != null)
                {
                    string name = read.Split('|')[0];
                    string url = read.Split('|')[1];
                    bots.Add(new Bot(name, url));
                }
            }
            return bots;
        }

        public List<Bot> loadfromSerFile()
        {

            List<Bot> bots;
            try
            {
                using (Stream stream = File.Open(st, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader sr = new StreamReader(stream))
                {
                    string read = null; string json = "";
                    while ((read = sr.ReadLine()) != null)
                    {
                        json += read;
                    }
                    bots = JsonConvert.DeserializeObject<List<Bot>>(json);
                }
            }
            catch (System.Exception)
            {
                bots = null;
            }
            return bots;
        }

        public void saveBots(List<Bot> bots)
        {
            string serialized = JsonConvert.SerializeObject(bots);
            using (Stream stream = File.Open(st, FileMode.Create, FileAccess.Write))
            using (StreamWriter wr = new StreamWriter(stream, System.Text.Encoding.Default))
            {
                wr.WriteLine(serialized);
            }
        }
        
        public List<string> loadProxi(string fileName)
        {
            List<string> proxi = new List<string>();
            using (Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(stream))
            {
                string read = null;
                while ((read = sr.ReadLine()) != null)
                {
                    proxi.Add(read);
                }
            }
            return proxi;
        }

        public List<string> loadProxi()
        {
            List<string> proxi;
            FileInfo file = new FileInfo(proxiFileName);
            if (file.Exists)
            {
                using (Stream stream = File.Open(proxiFileName, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader sr = new StreamReader(stream))
                {
                    string read = null; string json = "";
                    while ((read = sr.ReadLine()) != null)
                    {
                        json += read;
                    }
                    proxi = JsonConvert.DeserializeObject<List<string>>(json);
                }
            }
            else
            {
                proxi = null;
            }
            return proxi;
        }

        public void saveProxi(List<string> proxi)
        {
            string serialized = JsonConvert.SerializeObject(proxi);
            using (Stream stream = File.Open(proxiFileName, FileMode.Create, FileAccess.Write))
            using (StreamWriter wr = new StreamWriter(stream, System.Text.Encoding.Default))
            {
                wr.WriteLine(serialized);
            }
        }
    }
}
