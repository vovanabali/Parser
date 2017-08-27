using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Parser.main
{
    class loadAndSave
    {
        string st = @"Files\listBots.dat";
        string proxiFileName = @"Files\proxi.dat";
        string derBots = @"Files\Bots\";
        string derItems = @"Files\SerchItems\";
        
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

        public List<Bot> loadBotFromFile(string nameList)
        {
            List<Bot> bots;
            try
            {
                using (Stream stream = File.Open(derBots+nameList+".dat", FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default))
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

        public void saveBots(List<Bot> bots, string name)
        {
            string serialized = JsonConvert.SerializeObject(bots);
            using (Stream stream = File.Open(derBots+name+".dat", FileMode.Create, FileAccess.Write))
            using (StreamWriter wr = new StreamWriter(stream, System.Text.Encoding.Default))
            {
                wr.WriteLine(serialized);
                wr.Flush();
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
                wr.Flush();
            }
        }


        public void saveSerchItems(List<string> serchItems,string nameList)
        {
            string serialized = JsonConvert.SerializeObject(serchItems);
            if (!Directory.Exists("Files/SerchItems")) Directory.CreateDirectory("Files/SerchItems");
            using (Stream stream = File.Open("Files/SerchItems/"+nameList+ ".dat", FileMode.Create, FileAccess.Write))
            using (StreamWriter wr = new StreamWriter(stream, System.Text.Encoding.Default))
            {
                wr.WriteLine(serialized);
                wr.Flush();
            }
        }


        public List<string> loadSerchItems(string nameList)
        {
            List<string> serchItems = new List<string>();
            using (Stream stream = File.Open(derItems+ nameList + ".dat", FileMode.OpenOrCreate, FileAccess.Read))
            using (StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default))
            {
                string read = null; string json = "";
                while ((read = sr.ReadLine()) != null)
                {
                    json += read;
                }
                serchItems = JsonConvert.DeserializeObject<List<string>>(json);
            }
            return serchItems;
        }
    }
}
