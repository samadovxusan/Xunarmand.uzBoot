using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using File = System.IO.File;

namespace FoodBoot.Writ_json
{
    static class Writ_Json
    {
       static string paht = @"D:\\C#projects\\NajotTalim\\Bootcamp_N11\\FoodBoot\\FoodBoot\\Path\\Users.txt";
        public static void Write(Contact contact)
        {
            var data = File.ReadAllText(paht);
            var listuser = JsonConvert.DeserializeObject<List<Contact>>(data);
            var find = listuser.FirstOrDefault(x => x.UserId == contact.UserId);

            if (find is null)
            {
                listuser.Add(contact);
                File.WriteAllText(paht, JsonConvert.SerializeObject(listuser , Formatting.Indented));
            }

        }


    }
}
