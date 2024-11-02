using DBContexts.Entity;
using DBContexts.Select;
using FoodBoot.Writ_json;
using QuestPDF.Infrastructure;
using System.Diagnostics;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

internal class Program
{
    public static long id_user;
    public static List<long> UserIds = new List<long>() {986905197};
    public static List<string> Savatcha = new List<string>() {};
    //public static List<long> Savatlist = new List<>() {};
    private static async Task Main(string[] args)
    {
        var botClient = new TelegramBotClient("6914260630:AAEqHMKLA3kFD_4Rcd8wMPqGOwa-GfBlWH8");


        using CancellationTokenSource cts = new();

        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
        };
        botClient.StartReceiving(
          updateHandler: HandleUpdateAsync,
          pollingErrorHandler: HandlePollingErrorAsync,
          receiverOptions: receiverOptions,
          cancellationToken: cts.Token
      );
        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();
        cts.Cancel();
        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
    var Handlar = update.Type switch
    {
        UpdateType.Message => HandleMessageAsync(botClient, update, cancellationToken),
        UpdateType.EditedMessage => HandleEditMessageAsync(botClient, update, cancellationToken),
        UpdateType.CallbackQuery => HandleCallbackQueryAsync(botClient, update, cancellationToken),
        _ => HandleMessageAsync(botClient, update, cancellationToken)

    };
        try
        {
            await Handlar;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error chiqadi: {ex.Message}");
        };
}

async Task HandleCallbackQueryAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if(update.CallbackQuery.Data == "c1")
            {
                string savat_cola = $"Coca Cola 0.5l \n  10.000 som";

                Savatcha.Add( savat_cola );


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e davom atamizmi",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c2")
            {
                string savat_cola = $"Coca Cola 0.5l \n  20.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c3")
            {
                string savat_cola = $"Coca Cola 0.5l \n  30.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c4")
            {
                string savat_cola = $"Coca Cola 0.5l \n  40.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c5")
            {
                string savat_cola = $"Coca Cola 0.5l \n  50.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c6")
            {
                string savat_cola = $"Coca Cola 0.5l \n  60.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c7")
            {
                string savat_cola = $"Coca Cola 0.5l \n  70.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c8")
            {
                string savat_cola = $"Coca Cola 0.5l \n  80.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c9")
            {
                string savat_cola = $"Coca Cola 0.5l \n  90.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c10")
            {
                string savat_cola = $"Coca Cola 0.5l \n  100.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }

            if (update.CallbackQuery.Data == "o2")
            {
                string savat_cola = $" Milliy osh \n  70.000 som ";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: " xosh yana nima olamiz",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "d3")
            {
                string savat_cola = $"Doda Milliy maxsulot \n  90.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "yana nima olamiz",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c4")
            {
                string savat_cola = $"Coca Cola 0.5l \n  40.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c5")
            {
                string savat_cola = $"Coca Cola 0.5l \n  50.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c6")
            {
                string savat_cola = $"Coca Cola 0.5l \n  60.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c7")
            {
                string savat_cola = $"Coca Cola 0.5l \n  70.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c8")
            {
                string savat_cola = $"Coca Cola 0.5l \n  80.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c9")
            {
                string savat_cola = $"Coca Cola 0.5l \n  90.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }
            if (update.CallbackQuery.Data == "c10")
            {
                string savat_cola = $"Coca Cola 0.5l \n  100.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: id_user,
                text: "e qoyil",
                cancellationToken: cancellationToken);
            }







        }

        Task HandleEditMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        async Task HandleMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Received a '{update.Message.Text}' message in chat ,{update.Message.Chat.LastName} {update.Message.Chat.FirstName} {update.Message.Chat.Id} ");

             id_user = update.Message.Chat.Id;
            if (update.Message.Text == "/start")
            {
                ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                {
                    KeyboardButton.WithRequestContact("Share Contact"),
});

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Who or Where are you?",
                    replyMarkup: replyKeyboardMarkup,
                    cancellationToken: cancellationToken);
            }
            if (update.Message.Type == MessageType.Contact && update.Message.Contact != null)
            {
                Writ_Json.Write(update.Message.Contact);
                Message sentMessage = await botClient.SendTextMessageAsync(
                 chatId: update.Message.Chat.Id,
                 text: "Emil kiriting",
                 cancellationToken: cancellationToken);
            }


            var index = update.Message.Text.IndexOf("@");
            if (index != -1)
            {
                var domain = update.Message.Text.Substring(index);
                if (domain == "@gmail.com")
                {

                    update.Message.Text.EmailSend();
                    Message sentMessage1 = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Emailingizga Code Jonatildi Shuni Kiriting ",
                    cancellationToken: cancellationToken);

                }
            }
            //Posword
            if (EmailSender.possword == update.Message.Text)
            {
                var id = UserIds.FirstOrDefault(x =>  x == update.Message.Chat.Id);
                if (id != 0)
                {
                        var replyKeyboard = new ReplyKeyboardMarkup(
                  new List<KeyboardButton[]>()
                  {
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Category"),
                            new KeyboardButton("Product"),
                            new KeyboardButton("PayType"),
                        },
                        new KeyboardButton[]
                        {
                            new KeyboardButton("OrderStatus"),
                            new KeyboardButton("Bu_Sni_Oz"),
                            new KeyboardButton("ALl Order Excel file"),
                            new KeyboardButton("All customer file")
                        },
                  })
                        {
                            ResizeKeyboard = true,
                        };

                        Message sentMessage = await botClient.SendTextMessageAsync(
                            chatId: update.Message.Chat.Id,
                            text: "Admin Hushkelibsiz",
                            replyMarkup: replyKeyboard,
                            cancellationToken: cancellationToken);
                }
                else
                {

                    var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
            {
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Foods"),
                            new KeyboardButton("Drincs"),
                        },
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Ice cream"),
                            new KeyboardButton("Savat📥"),
                            new KeyboardButton("All Order Pdf"),
                        },
            })
                    {
                        ResizeKeyboard = true,
                    };
                    Message sentMessage = await botClient.SendTextMessageAsync(
                     chatId: update.Message.Chat.Id,
                     text: "User Hushkelibsiz",
                     replyMarkup: replyKeyboard,
                     cancellationToken: cancellationToken);

                }
            }


            //exit
            if (update.Message.Text == "Exit 💰")

            {

                var id = UserIds.FirstOrDefault(x => x == update.Message.Chat.Id);
                if (id != 0)
                {

                    var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                        {
                     new KeyboardButton[]
                     {
                         new KeyboardButton("Category"),
                         new KeyboardButton("Product"),
                         new KeyboardButton("PayType"),
                     },
                     new KeyboardButton[]
                     {
                         new KeyboardButton("OrderStatus"),
                         new KeyboardButton("Bu_Sni_Oz"),
                         new KeyboardButton("ALl Order Excel file"),
                         new KeyboardButton("All customer file")
                     },

                        })
                    {
                        ResizeKeyboard = true,
                    };


                    Message sentMessage = await botClient.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: "Choose a response",
                        replyMarkup: replyKeyboard,
                        cancellationToken: cancellationToken);

                }
                else
                {

                    var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
            {
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Foods"),
                            new KeyboardButton("Drinks"),
                        },
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Ice cream"),
                        },
            })
                    {
                        ResizeKeyboard = true,
                    };
                    Message sentMessage = await botClient.SendTextMessageAsync(
                     chatId: update.Message.Chat.Id,
                     text: "Choose Respons",
                     replyMarkup: replyKeyboard,
                     cancellationToken: cancellationToken);
                }
            }

            //Category
            if (update.Message.Text == "Category")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
          new List<KeyboardButton[]>()
                {
                new KeyboardButton[]
                {
                    new KeyboardButton(" Drinks"),
                    new KeyboardButton("Foods"),
                    new KeyboardButton("Ice cream"),

                    new KeyboardButton("Exit 💰"),
                },
                })
                {
                    ResizeKeyboard = true,
                };

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);

            }

                    //drinc 
                    if( update.Message.Text == "Drinks")
            {
                var replyKeyboard = new ReplyKeyboardMarkup(
          new List<KeyboardButton[]>()
                {
                new KeyboardButton[]
                {
                    new KeyboardButton(" Coca_Cola"),
                    new KeyboardButton("Pepsi"),
                },
                 new KeyboardButton[]
                {
                    new KeyboardButton("Flesh"),
                    new KeyboardButton("Savat📥 "),
                    new KeyboardButton("Savat📥 tozalash" ),
                    new KeyboardButton("Exit 💰"),
                },
                })
                {
                    ResizeKeyboard = true,
                };

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);


            }
                    if(update.Message.Text == "Coca_Cola")
            {
                    InlineKeyboardMarkup inlineKeyboard = new(new[]
     {
                    // first row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "c1"),
                        InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "c2"),
                        InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "c3"),
                    },
                    // second row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "c4"),
                        InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "c5"),
                        InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "c6"),
                    },
                     new []
                    {
                        InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "c7"),
                        InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "c8"),
                        InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "c9"),
                        InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "c10"),
                    },
                });
                    
                Message sentMessage = await botClient.SendPhotoAsync(  
                    chatId: update.Message.Chat.Id,  
                    photo: InputFileUrl.FromUri("https://backend.xunarmand.uz/images/turba96qizl.png"),  
                    caption: "Coca Cola 0.5l \n 10.000 \n Nechta olmoqchisz tanlang",  
                    replyMarkup: inlineKeyboard,  
                    cancellationToken: cancellationToken);
            }
                    if (update.Message.Text == "Pepsi")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "p1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "p2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "p3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "p4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "p5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "p6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "p7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "p8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "p9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "p10"),
                },
            });



                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.usatoday.com%2Fgcdn%2Fmedia%2FUSATODAY%2FUSATODAY%2F2013%2F03%2F21%2Fap-pepsi-new-bottle-1_1.jpg&imgrefurl=https%3A%2F%2Fwww.usatoday.com%2Fstory%2Fmoney%2Fbusiness%2F2013%2F03%2F21%2Fpepsi-rolls-out-new-bottle-shape%2F2007449%2F&docid=vT690SaNBb4i3M&tbnid=bCnWEDmEsDkyhM&vet=12ahUKEwiooYqUwI6EAxUtbPUHHfgXAUgQM3oECBIQAA..i&w=1597&h=1600&ved=2ahUKEwiooYqUwI6EAxUtbPUHHfgXAUgQM3oECBIQAA "),
                   caption: "Pepsi 0.5l \n 10.000",
                   replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken); ; ; ;

            }
                    if (update.Message.Text == "Flesh")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "f1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "f2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "f3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "f4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "f5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "f6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "f7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "f8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "f9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "f10"),
                },
            });


                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fzamin.uz%2Fuploads%2Fposts%2F2018-01%2F1516629364_24_10-6-d0b8d0b7-61-810x608.jpg&imgrefurl=https%3A%2F%2Fzamin.uz%2Fuz%2Fjamiyat%2F30956-flesh-ichimligi-halolmi.html&docid=ARA8jp7GwchjkM&tbnid=cdF7dxatMwwuBM&vet=12ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA..i&w=620&h=465&ved=2ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA"),
                   caption: "Flash \n 10.000",
                    replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken);

            }


                    //Foods
                    if(update.Message.Text == "Foods")
            {
                var replyKeyboard = new ReplyKeyboardMarkup(
        new List<KeyboardButton[]>()
              {
                new KeyboardButton[]
                {
                    new KeyboardButton(" Osh"),
                    new KeyboardButton("Xonim"),
                },
                 new KeyboardButton[]
                {
                    new KeyboardButton("Shashlik"),
                    new KeyboardButton("Exit 💰"),
                    new KeyboardButton("Savat📥 tozalash" ),
                    new KeyboardButton("Savat📥"),
                },
              })
                {
                    ResizeKeyboard = true,
                };

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose ",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);
            }
                    if (update.Message.Text == "Osh")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "o1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "o2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "o3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "o4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "o5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "o6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "o7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "o8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "o9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "o10"),
                },
            });

                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                    photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fapps.bringo.uz%2Fpublic%2Fassets%2Fproducts%2F250x250%2F1007741_3602252181.jpg&imgrefurl=https%3A%2F%2Fbringo.uz%2Frestaurant%2Fpay-osh-ul-bobura&docid=ZuZQLZc_0ohyfM&tbnid=Ocp7YDzM3DKjVM&vet=12ahUKEwjJxpiywo6EAxWOgFYBHc1yAdoQM3oECBYQAA..i&w=350&h=350&ved=2ahUKEwjJxpiywo6EAxWOgFYBHc1yAdoQM3oECBYQAA"),
                   caption:  " Milliy Osh   \n Non + Salat  35.000 /nechta olasiz",
                    replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken); ; ; ;

            }
                    if (update.Message.Text == "Xonim")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "x1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "x2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "x3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "x4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "x5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "x6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "x7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "x8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "x9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "x10"),
                },
            });



                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=http%3A%2F%2Fpazanda.com%2Fwp-content%2Fuploads%2F2015%2F12%2Fimg_0902.jpg&imgrefurl=http%3A%2F%2Fpazanda.com%2Fuz%2F2015%2F12%2F02%2Ftoshkentcha-xonim%2F&docid=TREHvdiUQXLSSM&tbnid=_IrM9DbVZpphMM&vet=12ahUKEwjShN30wo6EAxWdk68BHccgCkcQM3oECDoQAA..i&w=630&h=473&ved=2ahUKEwjShN30wo6EAxWdk68BHccgCkcQM3oECDoQAA"),
                   caption: "Xonim  \n 1 Postsa 30.000 \n nechta  xarid qlasiz",
                    replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken); ; ; ;

            }
                    if (update.Message.Text == "Shashlik")
            {


                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "w1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "w2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "w3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "w4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "w5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "w6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "w7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "w8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "w9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "w10"),
                },
            });


                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fmeljoulwan.com%2Fwp-content%2Fuploads%2F2017%2F06%2Fshashlik.png&imgrefurl=http%3A%2F%2Fmeljoulwan.com%2F2017%2F06%2F12%2Fshashlik-shish-kebabs%2F&docid=V2_FOLglggOpcM&tbnid=TDE83FFAfyRfiM&vet=12ahUKEwisxeSlw46EAxVMnK8BHQRHCDwQM3oECEQQAA..i&w=702&h=897&ved=2ahUKEwisxeSlw46EAxVMnK8BHQRHCDwQM3oECEQQAA"),
                   caption: "Shashlik  \n shu turishi  40.000 \n nechta xarid qlasiz",
                    replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken);

            }

                    //Ice_Creams
                    if(update.Message.Text == "Ice cream")
            {
                    var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                  {
                new KeyboardButton[]
                {
                    new KeyboardButton(" Plombir"),
                    new KeyboardButton("Grand"),
                }, new KeyboardButton[]
                {
                    new KeyboardButton("Doda"),
                    new KeyboardButton("Exit 💰"),
                        new KeyboardButton("Savat📥"),
                     new KeyboardButton("Savat📥 tozalash" ),

                },
                  })
                    {
                        ResizeKeyboard = true,
                    };

                    Message sentMessage = await botClient.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: "Choose ",
                        replyMarkup: replyKeyboard,
                        cancellationToken: cancellationToken);
            }
                    if (update.Message.Text == "Plombir")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "pp1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "pp2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "pp3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "pp4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "pp5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "pp6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "pp7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "pp8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "pp9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "pp10"),
                },
            });


                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.drancor.com.tr%2Fwp-content%2Fuploads%2F2022%2F01%2Fplombir-vanilya1.jpg&imgrefurl=https%3A%2F%2Fwww.drancor.com.tr%2Fen%2Fdrancor-dondurma%2Fplombir-vanilla%2F&docid=iYPYrmhBYXZZGM&tbnid=bb69YbZpmJz_KM&vet=12ahUKEwj58Kf0xI6EAxWjjK8BHf1PA20QM3oECDYQAA..i&w=800&h=800&ved=2ahUKEwj58Kf0xI6EAxWjjK8BHf1PA20QM3oECDYQAA"),
                   caption: " Plombir \n   8.000 \n nechta xarid qlasiz ",
                    replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken); ; ; ;

            }
                    if (update.Message.Text == "Grand")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "g1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "g2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "g3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "g4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "g5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "g6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "g7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "g8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "g9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "g10"),
                },
            });


                Message sentMessage = await botClient.SendPhotoAsync(
                   chatId: update.Message.Chat.Id,
                   photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fweb.lebazar.uz%2Fresources%2Fproduct%2F2020%2F11%2F23%2Fmedium_1608709971002090404-00026.jpg&tbnid=c4JLsDao5hrpgM&vet=10CBYQxiAoBWoXChMI8PPem8WOhAMVAAAAAB0AAAAAEAc..i&imgrefurl=https%3A%2F%2Flebazar.uz%2Fstore%2Fkorzinka-uz-7%2Fsalom-22%2Fproduct%2Fmorojenoe-grand-s-shokoladnoy-glazure-120-g-200594&docid=PPZuKKFzc0yB4M&w=400&h=400&itg=1&q=grand%20musqaymoq&ved=0CBYQxiAoBWoXChMI8PPem8WOhAMVAAAAAB0AAAAAEAc"),
                   caption: "Grand  \n  10.000 \n nechta xarid qlasiz",
                   replyMarkup: inlineKeyboard,
                   cancellationToken: cancellationToken); ; ; ;

            }
                    if (update.Message.Text == "Doda")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
{
                // first row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "d1"),
                    InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "d2"),
                    InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "d3"),
                },
                // second row
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "d4"),
                    InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "d5"),
                    InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "d6"),
                },
                 new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "d7"),
                    InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "d8"),
                    InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "d9"),
                    InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "d10"),
                },
            });


                Message sentMessage = await botClient.SendPhotoAsync(
                     chatId: update.Message.Chat.Id,
                     photo: InputFileUrl.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fimkonplus.uz%2Fd%2Fimkon-doda-5.jpg&tbnid=4idwbLG_biRM0M&vet=10CA4QxiAoBmoXChMI8IWi18WOhAMVAAAAAB0AAAAAED4..i&imgrefurl=https%3A%2F%2Fimkonplus.uz%2Fabout&docid=KQ4WWequ8TslwM&w=2000&h=2000&itg=1&q=doda%20musqaymoq&ved=0CA4QxiAoBmoXChMI8IWi18WOhAMVAAAAAB0AAAAAED4"),
                     caption: "Doda \n  30.000  \n nechta xarid qlasiz",
                     replyMarkup: inlineKeyboard,
                     cancellationToken: cancellationToken); ; ; ;

            }




            //produc
            if (update.Message.Text == "Product")
            {
                var replyKeyboard = new ReplyKeyboardMarkup(
          new List<KeyboardButton[]>()
                {
                 new KeyboardButton[]
                 {
                     new KeyboardButton("Osh"),
                     new KeyboardButton("Xonim"),

                 },
                  new KeyboardButton[]
                 {
                     new KeyboardButton("Shashlik"),
                     new KeyboardButton("Coca_Cola"),

                 },
                  new KeyboardButton[]
                 {
                     new KeyboardButton("Plombir"),
                     new KeyboardButton("Grand"),

                 },
                     new KeyboardButton[]
                 {
                     new KeyboardButton("Doda"),
                     new KeyboardButton("Pepsi"),
                 },
                          new KeyboardButton[]
                 {
                     new KeyboardButton("Flesh"),
                     new KeyboardButton("Exit 💰"),

                 },
                 })
                 {
                     ResizeKeyboard = true,
                 };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);

            }
            if (update.Message.Text == "PayType")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
          new List<KeyboardButton[]>()
                {
            new KeyboardButton[]
            {
                new KeyboardButton("NAQD"),
                new KeyboardButton("CliCk"),
                new KeyboardButton("PAYMEq"),
                new KeyboardButton("Exit 💰"),
            },
                })
                {
                    ResizeKeyboard = true,
                };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);
            }
            if (update.Message.Text == "OrderStatus")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                {
            new KeyboardButton[]
            {
                new KeyboardButton("NEW"),
                new KeyboardButton("COMPLETED"),
                new KeyboardButton("DELIVERED"),
                new KeyboardButton("Exit 💰"),

            },
                })
                {
                    ResizeKeyboard = true,
                };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);

            }
            //Change  status
            if (update.Message.Text == "Bu_Sni_Oz")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                {
            new KeyboardButton[]
            {
                new KeyboardButton("Chenge Status"),
                new KeyboardButton("Exit 💰"),

            },
                })
                {
                    ResizeKeyboard = true,
                };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);

            }
            if (update.Message.Text == "ALl Order Excel file")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                {
            new KeyboardButton[]
            {
                new KeyboardButton("Select file"),
                new KeyboardButton("Exit 💰"),

            },
                })
                {
                    ResizeKeyboard = true,
                };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);

            }
            if (update.Message.Text == "All customer file")
            {

                var replyKeyboard = new ReplyKeyboardMarkup(
            new List<KeyboardButton[]>()
                {
            new KeyboardButton[]
            {
                new KeyboardButton("Select file"),
                new KeyboardButton("Exit 💰"),

            },
                })
                {
                    ResizeKeyboard = true,
                };
                    Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboard,
                    cancellationToken: cancellationToken);
            }
            if(update.Message.Text == "Select file")
            {
                string pathsend  = @"D:\C#projects\NajotTalim\Bootcamp_N11\FoodBoot\FoodBoot\pdfs\Users.pdf";
                string pahtuser = @"D:\C#projects\NajotTalim\Bootcamp_N11\FoodBoot\FoodBoot\Path\Users.txt";
                string path = @"D:\\C#projects\\NajotTalim\\Bootcamp_N11\\FoodBoot\\FoodBoot\\Path\\";
                DirectoryInfo projectDirectoryInfo =
                Directory.GetParent(Environment.CurrentDirectory).Parent.Parent;

                Console.WriteLine(projectDirectoryInfo.FullName);

                string pdfsFolder = Directory.CreateDirectory(
                     Path.Combine(projectDirectoryInfo.FullName, "pdfs")).FullName;

                QuestPDF.Settings.License = LicenseType.Community;
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(20));

                        page.Header()
                          .Text("Hello PDF!")
                          .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                        page.Content()
                          .PaddingVertical(1, Unit.Centimetre)
                          .Column(x =>
                          {
                              x.Spacing(20);

                        var data = System.IO.File.ReadAllText(pahtuser);
                              Console.WriteLine(data);
                              x.Item().Text(data);
                          });

                        page.Footer()
                          .AlignCenter()
                          .Text(x =>
                          {
                              x.Span("Page ");
                              x.CurrentPageNumber();
                          });
                    });
                })
                .GeneratePdf(Path.Combine(pdfsFolder, "Users.pdf" ));

                await using Stream stream = System.IO.File.OpenRead(pathsend);
                await botClient.SendDocumentAsync(
                    chatId: update.Message.Chat.Id,
                    document: InputFile.FromStream(stream: stream, fileName: $"All_users2.pdf"),
                    caption: "Hamma foydalanuvchi haqida malumot"
                    );
                stream.Dispose();



            }

            if(update.Message.Text == "Savat📥")
            {
                if(Savatcha.Count == 0)
                {

                    Message sentMessage2 = await botClient.SendTextMessageAsync(
                     chatId: update.Message.Chat.Id,
                     text: "Savat bosh  Narsa Xarid qling",
                     cancellationToken: cancellationToken);

                }
                foreach (var item in Savatcha)
                {

                 Message sentMessage = await botClient.SendTextMessageAsync(
                 chatId: update.Message.Chat.Id,
                 text: item,
                 cancellationToken: cancellationToken);
                }
            }

            if (update.Message.Text == "Savat📥 tozalash")
            {

                foreach(var item in Savatcha)
                {
                    Savatcha.Remove(item);
                }

                Message sentMessage = await botClient.SendTextMessageAsync(
                 chatId: update.Message.Chat.Id,
                 text: "Savat tozalandi",
                 cancellationToken: cancellationToken);
            }


        }
        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };
            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}

