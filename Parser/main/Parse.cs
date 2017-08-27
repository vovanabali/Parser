using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xNet;

namespace Parser.main
{

    public class Parse
    {

        static readonly string site = "https://steamcommunity.com/id/<инентификатор>/inventory/json/730/2";

        public Task<string> getJson(Bot bot)
        {
            return Task.Run(()=> {
                string json = null; List<string> destroiI = new List<string>();
                using (var request = new HttpRequest())
                {
                    bool errors = true;
                    int iterErrors = 0;

                    while (true)
                    {
                        try
                        {
                            if (Properties.Settings.Default.itterator > mainForm.proxi.Count) Properties.Settings.Default.itterator = 0;
                            request.UserAgent = Http.ChromeUserAgent();
                            //Прокси
                            if (mainForm.proxi != null && mainForm.proxi.Count != 0) request.Proxy = Socks5ProxyClient.Parse(mainForm.proxi[Properties.Settings.Default.itterator]);
                            // Отправляем запрос.
                            HttpResponse response = request.Get(bot.parsURL);
                            // Принимаем тело сообщения в виде строки.
                            json = response.ToString();
                            Properties.Settings.Default.itterator++;
                            Properties.Settings.Default.Save();
                            errors = false;
                            if (!errors) break;
                        }
                        catch (Exception ex)
                        {
                            switch (ex.Message)
                            {
                                case "Не удалось соединиться с HTTP-сервером 'steamcommunity.com'":
                                    if (Properties.Settings.Default.itterator >= mainForm.proxi.Count)
                                    {
                                        Properties.Settings.Default.itterator = 0;
                                        Properties.Settings.Default.Save();
                                    }
                                    else
                                    {
                                        destroiI.Add(mainForm.proxi[Properties.Settings.Default.itterator]);
                                        errors = true;
                                        iterErrors++;
                                        if (iterErrors > mainForm.proxi.Count) break;
                                    }
                                    break;
                                default: break;
                            }
                        }
                    }
                }
                foreach (string item in destroiI)
                {
                    mainForm.proxi.Remove(item);
                }
                new loadAndSave().saveProxi(mainForm.proxi);
                return json;
            });
        }

        public Task<List<Item>> getItems(string json)
        {
            return Task.Run(()=> {
                if (json != null)
                {
                    Bot bot = JsonConvert.DeserializeObject<Bot>(json);
                    List<Item> items = new List<Item>();
                    foreach (var r1 in bot.rgDescriptions.Values)
                    {
                        Item item = new Item();
                        item.name = r1.name;
                        switch (r1.tags[0].name)
                        {
                            case "Rifle": item.type = "Rifle"; break;
                            case "Key": item.type= "Key"; break;
                            case "Knife": item.type= "Knife"; break;
                            case "Gloves": item.type= "Gloves"; break;
                            case "Container": item.type= "Container"; break;
                            case "Collectible": item.type= "Collectible"; break;
                            case "Graffiti": item.type = "Graffiti"; break;
                            case "Sticker": item.type = "Sticker"; break;
                            default: item.type = "Rifle"; break;
                        }
                        item.market_name = r1.market_name;
                        item.market_hash_name = r1.market_hash_name;
                        try
                        {
                            item.exterior = r1.descriptions[0].value.Split(':')[1];
                        }
                        catch (Exception)
                        {
                            item.exterior = "Предмет не имееет качества";
                        }
                        items.Add(item);
                    }
                    return items;
                }
                else
                    return null;
            });
        }
    }
}
