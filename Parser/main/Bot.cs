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
        public Dictionary<string, RgInventory> rgInventory { get; set; }
        public Dictionary<string,RgDescriptions> rgDescriptions { get; set; }

        public Bot() { }

        public Bot(string name, string url)
        {
            this.name = name;
            this.url = url;
            this.id = getId(url);
        }

        public Bot(string name, string url, string siteName)
        {
            this.name = name;
            this.url = url;
            this.id = getId(url);
            this.siteName = siteName;
        }

        //https://steamcommunity.com/id/weans/inventory/json/730/2
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
