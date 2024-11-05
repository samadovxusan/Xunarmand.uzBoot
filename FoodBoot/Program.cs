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
    public static List<long> UserIds = new List<long>() { 986905197 };
    public static List<string> Savatcha = new List<string>() { };
    public static List<string> Demaxod = new List<string>()
    {
        "https://backend.xunarmand.uz/images/oshxona1.png",
        "https://backend.xunarmand.uz/images/oshxona2.png",
        "https://backend.xunarmand.uz/images/2+qozon.png",
        "https://backend.xunarmand.uz/images/di1.png",
    };
    public static List<string> Profnastil = new List<string>()
    {
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 110719.png",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 110741.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 111629.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 111640.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 111813.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 111843.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 113819.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 092652.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 113836.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 113909.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 113938.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 114142.jpg",
        "https://backend.xunarmand.uz/images/Screenshot 2024-09-26 114216.jpg",

        
        
        
        
        
    };
    public static List<string> Turuba = new List<string>()
    {
        "https://backend.xunarmand.uz/images/mokri.png",
        "https://backend.xunarmand.uz/images/turba96kok.jpg",
        "https://backend.xunarmand.uz/images/turba96kok.jpg",
        "https://backend.xunarmand.uz/images/turba96oq2.jpg",
        "https://backend.xunarmand.uz/images/turba96qaymo.jpg",
        "https://backend.xunarmand.uz/images/turba96qizl.jpg",
        "https://backend.xunarmand.uz/images/turba96yashil.jpg",
        "https://backend.xunarmand.uz/images/vitrina.jpg",
        "https://backend.xunarmand.uz/images/vitrina2.jpg",
        "https://backend.xunarmand.uz/images/turbaba+shapka.jpg",
        "https://backend.xunarmand.uz/images/turbala.jpg",
        
        
    }; 

    public static List<string> Vintilatsa = new List<string>()
    {
        "https://backend.xunarmand.uz/images/1.png",
        "https://backend.xunarmand.uz/images/2.png",
        "https://backend.xunarmand.uz/images/3.png",
        "https://backend.xunarmand.uz/images/4.png",
        "https://backend.xunarmand.uz/images/5.png",
        "https://backend.xunarmand.uz/images/6.png",
        "https://backend.xunarmand.uz/images/7.png",
        "https://backend.xunarmand.uz/images/8.png",
        "https://backend.xunarmand.uz/images/9.png",
        "https://backend.xunarmand.uz/images/10.png",
        "https://backend.xunarmand.uz/images/11.png",
        "https://backend.xunarmand.uz/images/12.png",
        "https://backend.xunarmand.uz/images/13.png",
        "https://backend.xunarmand.uz/images/14.png",
        "https://backend.xunarmand.uz/images/15.png",
       
        
        
        
    };
    
    public static List<string> Aksesuar = new List<string>()
    {
        "https://backend.xunarmand.uz/images/bag.png",
        "https://backend.xunarmand.uz/images/domik.jpg",
        "https://backend.xunarmand.uz/images/haaa.jpg",
        "https://backend.xunarmand.uz/images/kak.jpg",
        "https://backend.xunarmand.uz/images/kakaa.jpg",
        "https://backend.xunarmand.uz/images/kalen+4.jpg",
        "https://backend.xunarmand.uz/images/kalen+turba.jpg",
        "https://backend.xunarmand.uz/images/kalenaa.jpg",
        "https://backend.xunarmand.uz/images/lang.jpg",
        "https://backend.xunarmand.uz/images/qwrwq.jpg",

        "https://backend.xunarmand.uz/images/shabka.jpg",
        "https://backend.xunarmand.uz/images/slif.jpg",
        "https://backend.xunarmand.uz/images/sliflar.jpg",
        "https://backend.xunarmand.uz/images/traynik.jpg",
        "https://backend.xunarmand.uz/images/traynik+2.jpg",
        "https://backend.xunarmand.uz/images/traynik+3.jpg",


        
        
        
    };
    public static List<string> Gumbaz = new List<string>()
    {
        "https://backend.xunarmand.uz/images/f_manapov.jpg",
        
    };
    
    
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
            }

            ;
        }

        async Task HandleCallbackQueryAsync(ITelegramBotClient botClient, Update update,
            CancellationToken cancellationToken)
        {
            if (update.CallbackQuery.Data == "c1")
            {
                string savat_cola = $"Coca Cola 0.5l \n  10.000 som";

                Savatcha.Add(savat_cola);


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
            Console.WriteLine(
                $"Received a '{update.Message.Text}' message in chat ,{update.Message.Chat.LastName} {update.Message.Chat.FirstName} {update.Message.Chat.Id} ");

            id_user = update.Message.Chat.Id;
            if (update.Message.Text == "/start")
            {
                ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                {
                    KeyboardButton.WithRequestContact("Share Contact"),
                });

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Salom Qalysiz Contack Kiriting?",
                    replyMarkup: replyKeyboardMarkup,
                    cancellationToken: cancellationToken);
            }

            if (update.Message.Type == MessageType.Contact && update.Message.Contact != null)
            {
                var id = UserIds.FirstOrDefault(x => x == update.Message.Chat.Id);
                if (id != 0)
                {
                    var replyKeyboard = new ReplyKeyboardMarkup(
                        new List<KeyboardButton[]>()
                        {
                            new KeyboardButton[]
                            {
                                new KeyboardButton("Menu"),
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
                        text: "Hushkelibsiz  Kategoriyni Tanlang",
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
                                new KeyboardButton("Menu"),
                                new KeyboardButton("Aloqa"),
                            },
                            new KeyboardButton[]
                            {
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
                                new KeyboardButton("Menu"),
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
                                new KeyboardButton("Menu"),
                                new KeyboardButton("Aloqa"),
                                new KeyboardButton("PayType"),
                            },
                        })
                    {
                        ResizeKeyboard = true,
                    };
                    Message sentMessage = await botClient.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: "Kategoriyani Tanlang",
                        replyMarkup: replyKeyboard,
                        cancellationToken: cancellationToken);
                }
            }

            if (update.Message.Text == "Turubalar")
            {
                Message sentMessage = await botClient.SendPhotoAsync(
                    chatId: update.Message.Chat.Id,
                    photo: InputFileUrl.FromUri("https://backend.xunarmand.uz/images/turba96qizl.png"),
                    caption: "Coca Cola 0.5l \n 10.000 \n Nechta olmoqchisz tanlang",
                    cancellationToken: cancellationToken);
            }

            if (update.Message.Text == "Demaxodlar")
            {
                try
                {
                    for (int i = 0; i < Demaxod.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:InputFileUrl.FromUri("https://backend.xunarmand.uz/images/di1.png"),
                            caption: "Pepsi 0.5l \n 10.000",
                            cancellationToken: cancellationToken);
                    }
                }
                catch (Exception ex)
                {
                    await botClient.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: $"Xato yuz berdi: {ex.Message}",
                        cancellationToken: cancellationToken);
                }
            }


            if (update.Message.Text == "Gumbazlar")
            {
                for(int i=0;i<Gumbaz.Count;i++)
                {
                    
                    Message sentMessage = await botClient.SendPhotoAsync(
                        chatId: update.Message.Chat.Id,
                        photo: InputFileUrl.FromUri("https://backend.xunarmand.uz/images/f_manapov.jpg"),
                        caption: "Pepsi 0.5l \n 10.000",
                        cancellationToken: cancellationToken);
                }
            }

            if (update.Message.Text == "Aksesuarlar")
            {
                Message sentMessage = await botClient.SendPhotoAsync(
                    chatId: update.Message.Chat.Id,
                    photo: InputFileUrl.FromUri(
                        "https://www.google.com/imgres?imgurl=https%3A%2F%2Fzamin.uz%2Fuploads%2Fposts%2F2018-01%2F1516629364_24_10-6-d0b8d0b7-61-810x608.jpg&imgrefurl=https%3A%2F%2Fzamin.uz%2Fuz%2Fjamiyat%2F30956-flesh-ichimligi-halolmi.html&docid=ARA8jp7GwchjkM&tbnid=cdF7dxatMwwuBM&vet=12ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA..i&w=620&h=465&ved=2ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA"),
                    caption: "Flash \n 10.000",
                    cancellationToken: cancellationToken);
            }

            if (update.Message.Text == "Profnastillar")
            {
                Message sentMessage = await botClient.SendPhotoAsync(
                    chatId: update.Message.Chat.Id,
                    photo: InputFileUrl.FromUri(
                        "https://www.google.com/imgres?imgurl=https%3A%2F%2Fzamin.uz%2Fuploads%2Fposts%2F2018-01%2F1516629364_24_10-6-d0b8d0b7-61-810x608.jpg&imgrefurl=https%3A%2F%2Fzamin.uz%2Fuz%2Fjamiyat%2F30956-flesh-ichimligi-halolmi.html&docid=ARA8jp7GwchjkM&tbnid=cdF7dxatMwwuBM&vet=12ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA..i&w=620&h=465&ved=2ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA"),
                    caption: "Flash \n 10.000",
                    cancellationToken: cancellationToken);
            }

            if (update.Message.Text == "Vintilatsiyalar")
            {
                Message sentMessage = await botClient.SendPhotoAsync(
                    chatId: update.Message.Chat.Id,
                    photo: InputFileUrl.FromUri(
                        "https://www.google.com/imgres?imgurl=https%3A%2F%2Fzamin.uz%2Fuploads%2Fposts%2F2018-01%2F1516629364_24_10-6-d0b8d0b7-61-810x608.jpg&imgrefurl=https%3A%2F%2Fzamin.uz%2Fuz%2Fjamiyat%2F30956-flesh-ichimligi-halolmi.html&docid=ARA8jp7GwchjkM&tbnid=cdF7dxatMwwuBM&vet=12ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA..i&w=620&h=465&ved=2ahUKEwis_NPMwI6EAxUQh68BHb4WCZkQM3oECDMQAA"),
                    caption: "Flash \n 10.000",
                    cancellationToken: cancellationToken);
            }

            //produc
            if (update.Message.Text == "Menu")
            {
                var replyKeyboard = new ReplyKeyboardMarkup(
                    new List<KeyboardButton[]>()
                    {
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Demaxodlar"),
                            new KeyboardButton("Turubalar"),
                        },
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Aksesuarlar"),
                            new KeyboardButton("Profnastillar"),
                        },
                        new KeyboardButton[]
                        {
                            new KeyboardButton("Vintilatsiyalar"),
                            new KeyboardButton("Gumbazlar"),
                            new KeyboardButton("Exit 💰"),
                        },
                    })
                {
                    ResizeKeyboard = true,
                };


                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Kategoriyani Tanlang",
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

            if (update.Message.Text == "Select file")
            {
                string pathsend = @"D:\C#projects\NajotTalim\Bootcamp_N11\FoodBoot\FoodBoot\pdfs\Users.pdf";
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
                    .GeneratePdf(Path.Combine(pdfsFolder, "Users.pdf"));

                await using Stream stream = System.IO.File.OpenRead(pathsend);
                await botClient.SendDocumentAsync(
                    chatId: update.Message.Chat.Id,
                    document: InputFile.FromStream(stream: stream, fileName: $"All_users2.pdf"),
                    caption: "Hamma foydalanuvchi haqida malumot"
                );
                stream.Dispose();
            }

            if (update.Message.Text == "Savat📥")
            {
                if (Savatcha.Count == 0)
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
                foreach (var item in Savatcha)
                {
                    Savatcha.Remove(item);
                }

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Savat tozalandi",
                    cancellationToken: cancellationToken);
            }
        }

        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception,
            CancellationToken cancellationToken)
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