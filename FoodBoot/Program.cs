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
       "https://backend.xunarmand.uz//images//2+qozon.png",
        "https://backend.xunarmand.uz//images//3+qozon.png",
        "https://backend.xunarmand.uz//images//di1.jpg",
        "https://backend.xunarmand.uz//images//kafeta.png",
        "https://backend.xunarmand.uz//images//oshxona+tandir.png",
        "https://backend.xunarmand.uz//images//vitrena.png",
    };
    public static List<string> Profnastil = new List<string>()
    {
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 110719.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 110741.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 111629.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 111640.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 111813.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 111843.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 113819.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 092652.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 113836.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 113909.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 113938.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 114142.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 114216.png",

        
        
        
        
        
    };
    public static List<string> Turuba = new List<string>()
    {
        "https://backend.xunarmand.uz//images//mokri.png",
        "https://backend.xunarmand.uz//images//turba96kok.png",
        "https://backend.xunarmand.uz//images//turba96oq2.png",
        "https://backend.xunarmand.uz//images//turba96qaymo.png",
        "https://backend.xunarmand.uz//images//turba96qizl.png",
        "https://backend.xunarmand.uz//images//turba96yashil.png",
        "https://backend.xunarmand.uz//images//vitrina.png",
        "https://backend.xunarmand.uz//images//vitrina2.png",
        "https://backend.xunarmand.uz//images//turbaba+shapka.png",
        "https://backend.xunarmand.uz//images//turbala.png",
        
        
    }; 

    public static List<string> Vintilatsa = new List<string>()
    {
        "https://backend.xunarmand.uz//images//10.png",
        "https://backend.xunarmand.uz//images//11.png",
        "https://backend.xunarmand.uz//images//12.png",
        "https://backend.xunarmand.uz//images//13.png",
        "https://backend.xunarmand.uz//images//14.png",
        "https://backend.xunarmand.uz//images//15.png",
        "https://backend.xunarmand.uz//images//1.png",
        "https://backend.xunarmand.uz//images//2.png",
        "https://backend.xunarmand.uz//images//3.png",
       

 
    };
    
    public static List<string> Aksesuar = new List<string>()
    {
        "https://backend.xunarmand.uz//images//bag.png",
        "https://backend.xunarmand.uz//images//domik.png",
        "https://backend.xunarmand.uz//images//haaa.png",
        "https://backend.xunarmand.uz//images//kak.png",
        "https://backend.xunarmand.uz//images//kakaa.png",
        "https://backend.xunarmand.uz//images//kalen+4.png",
        "https://backend.xunarmand.uz//images//kalen+turba.png",
        "https://backend.xunarmand.uz//images//kalenaa.png",
        "https://backend.xunarmand.uz//images//kalenadede.png",
        "https://backend.xunarmand.uz//images//kotta kalen.png",
        "https://backend.xunarmand.uz//images//lang.png",
        "https://backend.xunarmand.uz//images//qwrwq.png",
        "https://backend.xunarmand.uz//images//shabka.png",
        "https://backend.xunarmand.uz//images//slif.png",
        "https://backend.xunarmand.uz//images//traynik.png",
        "https://backend.xunarmand.uz//images//traynik+2.png",
        "https://backend.xunarmand.uz//images//traynik+3.png",
        "https://backend.xunarmand.uz//images//turbalar.png",
        "https://backend.xunarmand.uz//images//tutu.png",
        "https://backend.xunarmand.uz//images//Screenshot 2024-09-26 102841.png",
        "https://backend.xunarmand.uz//images//traynik+2.png",


        
        
        
    };
    public static List<string> Gumbaz = new List<string>()
    {
        "https://backend.xunarmand.uz//images//kran.jpg",
        "https://backend.xunarmand.uz//images//qoyliqmasjid.jpg",
        "https://backend.xunarmand.uz//images//dilime.jpg",
        "https://backend.xunarmand.uz//images//f_manapov.jpg",
        "https://backend.xunarmand.uz//images//gold.jpg",
        "https://backend.xunarmand.uz//images//misgumbza.jpg",
        "https://backend.xunarmand.uz//images//qoyliq.jpg",
        "https://backend.xunarmand.uz//images//ray.jpg",
        "https://backend.xunarmand.uz//images//raysentr.jpg",
        "https://backend.xunarmand.uz//images//suni yonidi masjid.jpg",
        "https://backend.xunarmand.uz//images//yangbozor_oq.jpg",
        
    };
    
    
    //public static List<long> Savatlist = new List<>() {};
    private static async Task Main(string[] args)

    {
        var botClient = new TelegramBotClient("8055760938:AAF53YO-qKvmAHnTuohg9l8Il3mTZVBYhgg");


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
            if (update.CallbackQuery.Data == "c10")
            {
                string savat_cola = $"Coca Cola 0.5l \n  100.000 som";

                Savatcha.Add(savat_cola);


                Message sentMessage1 = await botClient.SendTextMessageAsync(
                    chatId: id_user,
                    text: "e qoyil",
                    cancellationToken: cancellationToken);
            }
            
            if (update.CallbackQuery.Data == "location")
            {
                Message sendTextMessageAsync =await botClient.SendTextMessageAsync(
                    chatId: id_user,
                    text: "Bizning joy:Toshkent viloyati, Zangiota tumani"
                );
            }
            else if (update.CallbackQuery.Data == "phone")
            {
                Message sendTextMessageAsync =await botClient.SendTextMessageAsync(
                    chatId: id_user,
                    text: "Telefon: +998 33 011 71 11 Abduqodir."
                );
            }
            else if (update.CallbackQuery.Data == "map")
            {
                Message message = await botClient.SendLocationAsync(
                    chatId: id_user,
                    latitude: 41.224508,
                    longitude: 69.131200
                );
            }
            else if (update.CallbackQuery.Data == "maslaxat")
            {
                var message = await botClient.SendTextMessageAsync(
                    chatId: id_user,
                    text: "Sizga Tez Orada Aloqaga Chiqamiz. Bizga Ishonch Bildirganingiz Uchun Tashakkur! Yanada Qulayroq --> [Xunarmand.uz](https://xunarmand.uz)",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown
                );
            }
            else if (update.CallbackQuery.Data == "buyurtma")
            {
                var message = await botClient.SendTextMessageAsync(
                    chatId: id_user,
                    text: "Sizga Tez Orada Aloqaga Chiqamiz. Bizga Ishonch Bildirganingiz Uchun Tashakkur! Yanada Qulayroq --> [Xunarmand.uz](https://xunarmand.uz)",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown
                );

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
                    text: "Hush Kelibsiz Contactni Kiriting?",
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
                    Writ_Json.Write(update.Message.Contact);
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
                            },
                        })
                    {
                        ResizeKeyboard = true,
                    };
                    Message sentMessage = await botClient.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: "Hushkelibsiz",
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
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });

                try
                {
                    for (int i = 0; i < Turuba.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:new InputFileUrl(new Uri( Turuba[i])),
                            caption: "Bu turubalar TARNOV , SLIFLAR   uchun ishlatiladi.",
                            replyMarkup: inlineKeyboard,
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

            if (update.Message.Text == "Demaxodlar")
            {
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });
                try
                {
                    for (int i = 0; i < Demaxod.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:new InputFileUrl(new Uri( Demaxod[i])),
                            caption: "Bu Demaxodlar o'choq qozonlar uchun Kafega va Hovlilarga yasaladi",
                            replyMarkup: inlineKeyboard,
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
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });
                for(int i=0;i<Gumbaz.Count;i++)
                {
                    
                    Message sentMessage = await botClient.SendPhotoAsync(
                        chatId: update.Message.Chat.Id,
                        photo: InputFileUrl.FromUri(Gumbaz[i]),
                        caption: "Masjidlar uchun Loyixalash Qurish Tamirlash Gumbazlar",
                        replyMarkup: inlineKeyboard,
                        cancellationToken: cancellationToken);
                }
            }

            if (update.Message.Text == "Aksesuarlar")
            { 
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });
                try
                {
                    for (int i = 0; i < Aksesuar.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:new InputFileUrl(new Uri( Aksesuar[i])),
                            caption: "Bu Aksusuarlar Dokonimizda bor mahsulotlar",
                            replyMarkup: inlineKeyboard,
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

            if (update.Message.Text == "Profnastillar")
            {
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });
                try
                {
                    for (int i = 0; i < Profnastil.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:new InputFileUrl(new Uri( Profnastil[i])),
                            caption: "Toshkentda tom yopish uchun gofrokarton var Profnastil har xil maxsulotlardan foydalaniladi.",
                            replyMarkup: inlineKeyboard,
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

            if (update.Message.Text == "Vintilatsiyalar")
            {
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
                        InlineKeyboardButton.WithCallbackData("Maslaxat olish", "maslaxat"),
                        InlineKeyboardButton.WithCallbackData("Aloqa", "phone"),
                        
                    }
                });
                try
                {
                    for (int i = 0; i < Vintilatsa.Count; i++)
                    {
                        Message sentMessage = await botClient.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo:new InputFileUrl(new Uri( Vintilatsa[i])),
                            caption: "Bu Vintilatsiya Havo tortish uchun ishlatiladi",
                            replyMarkup: inlineKeyboard,
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

            if (update.Message.Text == "Aloqa")
            {
                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("Joy nomi", "location"),
                        InlineKeyboardButton.WithCallbackData("Telefon raqami", "phone"),
                        InlineKeyboardButton.WithCallbackData("Lokatsiya", "map")
                    }
                });

                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Qaysi ma'lumotni ko‘rishni istaysiz?",
                    replyMarkup: inlineKeyboard
                );
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