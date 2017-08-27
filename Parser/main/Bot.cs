using Parser.main.BotClasses;
using System;
using System.Collections.Generic;

namespace Parser.main

{
    public class Bot
    {
        public string name { get; set; }
        public string url { get; set; }
        public string id { get; set; }
        public string siteName { get; set; }
        public bool success { get; set; }
        public string parsURL{ get; set; }
        public Dictionary<string, RgInventory> rgInventory { get; set; }
        public Dictionary<string,RgDescriptions> rgDescriptions { get; set; }

        public Bot() { }

        public Bot(string name, string url)
        {
            this.name = name;
            this.url = url;
            this.id = getId(url);
            currentParsUrl(url);
        }

        private void currentParsUrl(string url)
        {
            if (url.Contains("id"))
            {
                parsURL = "https://steamcommunity.com/id/"+id+"/inventory/json/730/2";
            }
            else
            {
                parsURL = "https://steamcommunity.com/profiles/"+id+"/inventory/json/730/2";
            }
        }

        public Bot(string name, string url, string siteName)
        {
            this.name = name;
            this.url = url;
            this.id = getId(url);
            this.siteName = siteName;
            currentParsUrl(url);
        }

        private string getId(string url)
        {
            try
            {
                return url.Split(new string[] { "id" }, StringSplitOptions.None)[1].Split('/')[1]; ;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
