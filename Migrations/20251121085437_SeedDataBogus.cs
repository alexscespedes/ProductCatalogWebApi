using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductCatalogApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Home Appliances" },
                    { 3, "Sports & Fitness" },
                    { 4, "Office Suppliers" },
                    { 5, "Gaming" },
                    { 6, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "IsActive", "Name", "Price", "Rating", "SKU" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 5, 3, 1, 3, 28, 788, DateTimeKind.Local).AddTicks(3895), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Practical Soft Pants", 184.32693084978880m, 1.1479364867546105, "PBDBEZFS" },
                    { 2, 2, new DateTime(2025, 5, 1, 3, 18, 57, 712, DateTimeKind.Local).AddTicks(5175), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Handcrafted Plastic Pizza", 652.095761843152375m, 1.7975361400912799, "1HK3866Q" },
                    { 3, 3, new DateTime(2024, 4, 12, 17, 35, 41, 259, DateTimeKind.Local).AddTicks(4540), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Unbranded Steel Fish", 585.413132736336575m, 1.9644765994543913, "EVJVFE93" },
                    { 4, 3, new DateTime(2024, 5, 29, 13, 42, 41, 158, DateTimeKind.Local).AddTicks(4085), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Sleek Rubber Mouse", 206.492295236674455m, 4.0961398874599526, "OZHBUZ4T" },
                    { 5, 4, new DateTime(2024, 7, 7, 1, 7, 30, 147, DateTimeKind.Local).AddTicks(5799), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", false, "Intelligent Metal Chair", 33.5998196026699585m, 1.788140759394798, "5RXYTLLJ" },
                    { 6, 5, new DateTime(2024, 6, 20, 17, 4, 13, 177, DateTimeKind.Local).AddTicks(3953), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Unbranded Wooden Pants", 149.4628326303504680m, 4.5420634316477688, "1HUK9LZD" },
                    { 7, 4, new DateTime(2025, 8, 6, 18, 33, 18, 183, DateTimeKind.Local).AddTicks(362), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Small Rubber Pants", 1074.168900818034055m, 4.2626667956304711, "OWNYKWVP" },
                    { 8, 1, new DateTime(2023, 12, 27, 17, 11, 33, 517, DateTimeKind.Local).AddTicks(7372), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Generic Granite Towels", 826.30521023509465m, 4.3515327305274702, "FQYWYO7T" },
                    { 9, 5, new DateTime(2024, 9, 1, 19, 50, 41, 352, DateTimeKind.Local).AddTicks(3921), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Licensed Rubber Keyboard", 554.155548185240425m, 3.899011585297417, "YDC4FUNH" },
                    { 10, 1, new DateTime(2024, 9, 30, 13, 28, 22, 332, DateTimeKind.Local).AddTicks(5889), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Ergonomic Wooden Mouse", 1205.07946650490470m, 2.5510010425619845, "ZH8X1FXZ" },
                    { 11, 1, new DateTime(2024, 8, 1, 2, 4, 7, 761, DateTimeKind.Local).AddTicks(7674), "The Football Is Good For Training And Recreational Purposes", true, "Awesome Concrete Gloves", 558.085722786016810m, 3.5496001023756194, "UNTLC22U" },
                    { 12, 4, new DateTime(2025, 11, 12, 18, 54, 55, 777, DateTimeKind.Local).AddTicks(7850), "The Football Is Good For Training And Recreational Purposes", true, "Small Plastic Fish", 423.223617802402945m, 3.026095197798496, "RIPJXPRE" },
                    { 13, 1, new DateTime(2025, 2, 4, 11, 57, 40, 339, DateTimeKind.Local).AddTicks(6549), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Handcrafted Concrete Salad", 278.619326771354135m, 3.7275519523024121, "EVMTT9WM" },
                    { 14, 3, new DateTime(2024, 10, 14, 1, 46, 17, 792, DateTimeKind.Local).AddTicks(4579), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Awesome Cotton Computer", 686.663761910307995m, 4.3729152150818749, "43WWD5PN" },
                    { 15, 5, new DateTime(2023, 12, 5, 15, 26, 29, 273, DateTimeKind.Local).AddTicks(4100), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Handmade Fresh Mouse", 691.361356090859735m, 2.1523220026443965, "XYP3PBIV" },
                    { 16, 1, new DateTime(2025, 5, 12, 10, 54, 2, 797, DateTimeKind.Local).AddTicks(7012), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Small Granite Bike", 618.549680560594505m, 2.9470859544259964, "IP7TDNTF" },
                    { 17, 2, new DateTime(2024, 11, 25, 22, 33, 15, 251, DateTimeKind.Local).AddTicks(8999), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Sleek Fresh Soap", 780.836206016885585m, 3.659172261852103, "MTRWNXWQ" },
                    { 18, 3, new DateTime(2024, 1, 28, 9, 17, 4, 501, DateTimeKind.Local).AddTicks(2944), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Unbranded Plastic Cheese", 1398.686339935694870m, 4.0048644255610357, "Q5KJ1M6B" },
                    { 19, 3, new DateTime(2024, 3, 19, 15, 48, 30, 412, DateTimeKind.Local).AddTicks(2035), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Intelligent Frozen Shoes", 575.341628806138345m, 3.5826055590118768, "YPCVCY56" },
                    { 20, 3, new DateTime(2024, 9, 22, 23, 56, 15, 957, DateTimeKind.Local).AddTicks(2879), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", false, "Tasty Granite Chips", 1400.693446143903530m, 2.7068201839100956, "ZHRZN892" },
                    { 21, 4, new DateTime(2024, 1, 29, 0, 47, 22, 463, DateTimeKind.Local).AddTicks(3329), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Rustic Plastic Shirt", 1057.984256264971420m, 1.3469893991984629, "SRVOCFPR" },
                    { 22, 5, new DateTime(2024, 1, 29, 3, 16, 2, 356, DateTimeKind.Local).AddTicks(9091), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Practical Rubber Pants", 630.838045019970770m, 1.2572410107634302, "PTYYBZN1" },
                    { 23, 5, new DateTime(2025, 4, 10, 23, 1, 1, 26, DateTimeKind.Local).AddTicks(1076), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Licensed Rubber Keyboard", 220.329586511002080m, 2.7845354748051472, "0GY5S11A" },
                    { 24, 1, new DateTime(2024, 4, 25, 3, 17, 4, 228, DateTimeKind.Local).AddTicks(3256), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Handmade Plastic Mouse", 1383.130792085050510m, 1.177876352080204, "6O6HNRQE" },
                    { 25, 1, new DateTime(2025, 9, 19, 15, 56, 36, 4, DateTimeKind.Local).AddTicks(6162), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Gorgeous Metal Computer", 705.334914464861585m, 4.3849272497393734, "D6G6V2LX" },
                    { 26, 4, new DateTime(2024, 3, 20, 16, 8, 9, 607, DateTimeKind.Local).AddTicks(5865), "The Football Is Good For Training And Recreational Purposes", true, "Intelligent Granite Pizza", 1353.15084716264095m, 3.5877989492203519, "6FAV6778" },
                    { 27, 5, new DateTime(2025, 8, 26, 12, 21, 41, 5, DateTimeKind.Local).AddTicks(9186), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", false, "Fantastic Plastic Sausages", 210.824226647148980m, 1.3743217717026899, "4YUGMYV6" },
                    { 28, 6, new DateTime(2024, 4, 22, 23, 40, 33, 165, DateTimeKind.Local).AddTicks(3409), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Handmade Frozen Salad", 268.582202712377510m, 1.4537753544237919, "HI721NAR" },
                    { 29, 1, new DateTime(2024, 10, 14, 22, 32, 0, 222, DateTimeKind.Local).AddTicks(9538), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Generic Frozen Chair", 800.225926080130155m, 4.3213777688625203, "R85WXT6N" },
                    { 30, 1, new DateTime(2024, 1, 25, 7, 37, 4, 164, DateTimeKind.Local).AddTicks(4384), "The Football Is Good For Training And Recreational Purposes", false, "Practical Plastic Chips", 800.633233138869970m, 1.1251438784528713, "8VOP4VJ0" },
                    { 31, 3, new DateTime(2024, 2, 17, 21, 38, 37, 360, DateTimeKind.Local).AddTicks(7275), "The Football Is Good For Training And Recreational Purposes", true, "Fantastic Plastic Salad", 375.965048292304180m, 4.6651228378936418, "GQN6QON6" },
                    { 32, 1, new DateTime(2023, 12, 24, 5, 25, 32, 582, DateTimeKind.Local).AddTicks(2290), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Generic Soft Pants", 1169.594581722415740m, 2.9945683563397623, "S5F4JD06" },
                    { 33, 5, new DateTime(2025, 10, 27, 9, 47, 12, 937, DateTimeKind.Local).AddTicks(7356), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Fantastic Frozen Chicken", 1141.790164443473670m, 3.3952678623836747, "E62D0BXX" },
                    { 34, 6, new DateTime(2024, 3, 11, 0, 45, 56, 475, DateTimeKind.Local).AddTicks(3016), "The Football Is Good For Training And Recreational Purposes", true, "Generic Concrete Keyboard", 1397.56208001751685m, 4.4529191596827546, "3TOSRY0X" },
                    { 35, 4, new DateTime(2024, 10, 21, 22, 44, 48, 387, DateTimeKind.Local).AddTicks(9010), "The Football Is Good For Training And Recreational Purposes", false, "Small Plastic Fish", 307.377498621487835m, 1.7699458986392806, "XXYN5DRO" },
                    { 36, 3, new DateTime(2025, 5, 19, 15, 4, 4, 823, DateTimeKind.Local).AddTicks(7725), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Ergonomic Steel Shirt", 1481.456932364883430m, 3.169045325805127, "OWK9RLOF" },
                    { 37, 3, new DateTime(2025, 8, 15, 10, 29, 39, 713, DateTimeKind.Local).AddTicks(1308), "The Football Is Good For Training And Recreational Purposes", true, "Small Rubber Keyboard", 802.131785778114865m, 3.9049189773336215, "L6Z0CVE3" },
                    { 38, 4, new DateTime(2023, 12, 23, 16, 49, 45, 510, DateTimeKind.Local).AddTicks(8670), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Refined Wooden Car", 760.151713006456480m, 1.3861391885844894, "M51NW5QC" },
                    { 39, 6, new DateTime(2024, 1, 29, 9, 54, 9, 313, DateTimeKind.Local).AddTicks(7376), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Fantastic Metal Soap", 399.761484706997330m, 1.8124093254710649, "R4IVO2UK" },
                    { 40, 3, new DateTime(2025, 5, 30, 21, 49, 26, 75, DateTimeKind.Local).AddTicks(7139), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Refined Cotton Ball", 1409.697335317959280m, 2.5140388665195661, "8ZV7DG7Z" },
                    { 41, 6, new DateTime(2025, 11, 18, 12, 0, 11, 654, DateTimeKind.Local).AddTicks(8549), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Rustic Wooden Soap", 1208.356758058191360m, 4.1964102143388633, "SDRB6P6Y" },
                    { 42, 1, new DateTime(2024, 10, 17, 4, 39, 50, 276, DateTimeKind.Local).AddTicks(8942), "The Football Is Good For Training And Recreational Purposes", true, "Rustic Steel Tuna", 635.382697065891965m, 2.663170054002308, "HTN1FMIE" },
                    { 43, 6, new DateTime(2025, 3, 18, 9, 11, 28, 832, DateTimeKind.Local).AddTicks(3876), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Ergonomic Frozen Car", 1111.399735051665795m, 2.6469433992043063, "7D3MVRUU" },
                    { 44, 4, new DateTime(2024, 6, 12, 2, 15, 36, 837, DateTimeKind.Local).AddTicks(7537), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Refined Rubber Salad", 1145.0037892325810m, 2.1506884978666192, "I51W5ZBY" },
                    { 45, 2, new DateTime(2024, 11, 26, 19, 38, 10, 694, DateTimeKind.Local).AddTicks(6637), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Rustic Frozen Salad", 671.074941821369080m, 3.7728568081591027, "9E5ZIHOQ" },
                    { 46, 5, new DateTime(2024, 5, 27, 0, 37, 55, 718, DateTimeKind.Local).AddTicks(8725), "The Football Is Good For Training And Recreational Purposes", true, "Ergonomic Metal Hat", 676.169048453398560m, 3.6799576505849898, "GN9VPAYY" },
                    { 47, 2, new DateTime(2025, 3, 20, 8, 51, 30, 863, DateTimeKind.Local).AddTicks(8745), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Rustic Steel Pants", 1304.797274898888090m, 2.0462921374226153, "UWF9S2AO" },
                    { 48, 4, new DateTime(2024, 4, 22, 0, 20, 43, 910, DateTimeKind.Local).AddTicks(2490), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Gorgeous Fresh Chips", 398.957073559810735m, 2.9937583749200196, "OITP6158" },
                    { 49, 4, new DateTime(2024, 11, 1, 19, 49, 5, 103, DateTimeKind.Local).AddTicks(6768), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Rustic Plastic Hat", 1029.862602967588580m, 3.3257511265185808, "AG483GEL" },
                    { 50, 2, new DateTime(2025, 2, 10, 17, 8, 38, 489, DateTimeKind.Local).AddTicks(622), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Handcrafted Wooden Chicken", 1163.312557758649930m, 4.7427145658399308, "FG1W2YWD" },
                    { 51, 4, new DateTime(2024, 11, 2, 1, 20, 3, 289, DateTimeKind.Local).AddTicks(7465), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Small Frozen Car", 103.1882801827266040m, 4.2345868376434286, "J0CY2OM6" },
                    { 52, 5, new DateTime(2024, 12, 25, 1, 57, 14, 721, DateTimeKind.Local).AddTicks(2872), "The Football Is Good For Training And Recreational Purposes", false, "Gorgeous Cotton Hat", 1132.574194698526120m, 2.8026625963846397, "X5YK2CM8" },
                    { 53, 1, new DateTime(2024, 7, 19, 16, 0, 16, 770, DateTimeKind.Local).AddTicks(2265), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Fantastic Frozen Soap", 1045.447165201337855m, 4.2845264977772892, "0LKYU5GP" },
                    { 54, 2, new DateTime(2025, 7, 5, 18, 33, 24, 563, DateTimeKind.Local).AddTicks(300), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", false, "Unbranded Cotton Chair", 1114.313367987292845m, 3.69728739186115, "X2L6T5DH" },
                    { 55, 2, new DateTime(2024, 5, 20, 3, 57, 59, 728, DateTimeKind.Local).AddTicks(624), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Awesome Granite Chips", 166.80915745752095m, 2.1703244822406162, "IVLI3VV0" },
                    { 56, 2, new DateTime(2025, 4, 29, 1, 56, 41, 378, DateTimeKind.Local).AddTicks(4331), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Fantastic Rubber Gloves", 311.781984905205420m, 4.6897016367196844, "NRHBC4OP" },
                    { 57, 6, new DateTime(2024, 8, 18, 6, 45, 26, 158, DateTimeKind.Local).AddTicks(5302), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Awesome Metal Sausages", 638.389152723305940m, 4.2995235345271983, "ZST6C41P" },
                    { 58, 4, new DateTime(2025, 6, 20, 6, 54, 46, 757, DateTimeKind.Local).AddTicks(829), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Rustic Fresh Chair", 1454.162792629652295m, 4.8295828351505472, "EGSYZHCM" },
                    { 59, 2, new DateTime(2025, 3, 24, 8, 43, 58, 28, DateTimeKind.Local).AddTicks(7704), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Small Plastic Sausages", 212.957018411970490m, 2.0256072275495112, "RG83DXJO" },
                    { 60, 4, new DateTime(2024, 12, 12, 23, 10, 25, 822, DateTimeKind.Local).AddTicks(3477), "The Football Is Good For Training And Recreational Purposes", true, "Handmade Plastic Cheese", 1027.790291637662080m, 3.8476623654086244, "C3JM4BD4" },
                    { 61, 6, new DateTime(2024, 9, 3, 21, 11, 23, 357, DateTimeKind.Local).AddTicks(3141), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Sleek Soft Chips", 289.422386687963030m, 4.5062784133219775, "99NJVOZ8" },
                    { 62, 3, new DateTime(2025, 6, 26, 10, 41, 39, 671, DateTimeKind.Local).AddTicks(4141), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Practical Cotton Salad", 290.891840710485295m, 4.8947695831692366, "XCNRBWGX" },
                    { 63, 3, new DateTime(2024, 1, 22, 21, 41, 22, 643, DateTimeKind.Local).AddTicks(4577), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Tasty Granite Hat", 637.824946182260585m, 2.6008576163872004, "XXV9MYU3" },
                    { 64, 3, new DateTime(2024, 5, 15, 8, 31, 56, 750, DateTimeKind.Local).AddTicks(4815), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Small Frozen Keyboard", 158.592376629566745m, 4.8463783335585404, "T19XUG88" },
                    { 65, 1, new DateTime(2025, 2, 3, 13, 33, 49, 218, DateTimeKind.Local).AddTicks(3436), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", false, "Handcrafted Steel Chicken", 1275.701161746832855m, 2.7063641404094141, "7Q7UIJBN" },
                    { 66, 2, new DateTime(2025, 2, 6, 22, 4, 35, 814, DateTimeKind.Local).AddTicks(9798), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Sleek Wooden Hat", 892.94353917395230m, 4.9824073086534071, "V16NN5P6" },
                    { 67, 1, new DateTime(2025, 6, 12, 22, 44, 9, 808, DateTimeKind.Local).AddTicks(7780), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Fantastic Steel Soap", 101.3873624398003215m, 2.5483367377916997, "YUZOOA3A" },
                    { 68, 6, new DateTime(2024, 3, 24, 8, 48, 8, 738, DateTimeKind.Local).AddTicks(1152), "The Football Is Good For Training And Recreational Purposes", true, "Unbranded Wooden Hat", 889.689440861243160m, 4.8567149175417281, "ANN3KER3" },
                    { 69, 2, new DateTime(2024, 3, 13, 19, 59, 49, 855, DateTimeKind.Local).AddTicks(9921), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Unbranded Soft Bike", 1068.699709382037390m, 3.5571528035129192, "ALYHQ0GV" },
                    { 70, 6, new DateTime(2024, 9, 27, 4, 14, 2, 539, DateTimeKind.Local).AddTicks(904), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Practical Frozen Ball", 999.944595169050045m, 3.4640312617043416, "UEI5V5QO" },
                    { 71, 2, new DateTime(2024, 4, 30, 14, 4, 20, 860, DateTimeKind.Local).AddTicks(5425), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", false, "Rustic Fresh Chicken", 584.467928136155175m, 4.2646426864917428, "P00JRG5L" },
                    { 72, 1, new DateTime(2025, 7, 7, 14, 24, 46, 734, DateTimeKind.Local).AddTicks(7374), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Ergonomic Cotton Gloves", 1034.029187849337935m, 4.6170665079552329, "ZSYX6JP7" },
                    { 73, 6, new DateTime(2024, 1, 9, 17, 37, 50, 597, DateTimeKind.Local).AddTicks(6108), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Gorgeous Fresh Gloves", 191.725442766820815m, 4.8063421780730753, "LZGU4Z6J" },
                    { 74, 5, new DateTime(2024, 5, 10, 10, 28, 9, 863, DateTimeKind.Local).AddTicks(7368), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", false, "Ergonomic Granite Sausages", 843.61815182140970m, 4.0719632573973747, "S9R8QP06" },
                    { 75, 5, new DateTime(2025, 5, 26, 22, 56, 43, 981, DateTimeKind.Local).AddTicks(4998), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Fantastic Soft Fish", 1114.121220648084345m, 3.2658768098457545, "10OR26PT" },
                    { 76, 2, new DateTime(2023, 11, 25, 10, 23, 5, 941, DateTimeKind.Local).AddTicks(4105), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", false, "Gorgeous Wooden Hat", 737.103807358111240m, 3.0420987145080751, "7XD6AQ0C" },
                    { 77, 5, new DateTime(2024, 5, 16, 12, 46, 56, 216, DateTimeKind.Local).AddTicks(580), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Rustic Frozen Bike", 754.273341167149955m, 2.392885924775586, "Z9JZTNH3" },
                    { 78, 6, new DateTime(2024, 4, 22, 18, 24, 20, 132, DateTimeKind.Local).AddTicks(6011), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Fantastic Metal Car", 1493.994751315018480m, 1.4971609328531952, "OI7EH62B" },
                    { 79, 4, new DateTime(2025, 3, 22, 16, 6, 31, 143, DateTimeKind.Local).AddTicks(2811), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Intelligent Granite Tuna", 1018.983868109673370m, 4.8562062488034705, "RCI2GT6V" },
                    { 80, 6, new DateTime(2025, 6, 23, 22, 13, 56, 873, DateTimeKind.Local).AddTicks(9410), "The Football Is Good For Training And Recreational Purposes", true, "Sleek Concrete Pants", 1142.638327180132570m, 3.0382371175499836, "PB67ZIUA" },
                    { 81, 6, new DateTime(2025, 3, 9, 18, 30, 31, 494, DateTimeKind.Local).AddTicks(396), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Licensed Concrete Gloves", 909.137612741506910m, 2.4388877017014212, "6PRNPFNI" },
                    { 82, 1, new DateTime(2024, 2, 14, 0, 21, 13, 221, DateTimeKind.Local).AddTicks(5832), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Intelligent Wooden Mouse", 1232.476526586016720m, 4.0727813176906995, "01R6O2UA" },
                    { 83, 5, new DateTime(2024, 12, 24, 15, 57, 2, 784, DateTimeKind.Local).AddTicks(2857), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Practical Rubber Car", 1319.927403827343280m, 3.7233955708150601, "FU984S28" },
                    { 84, 1, new DateTime(2023, 11, 30, 11, 54, 53, 172, DateTimeKind.Local).AddTicks(370), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Small Fresh Table", 661.852008557742660m, 2.3331718230981386, "H1IYK17B" },
                    { 85, 2, new DateTime(2024, 5, 30, 15, 24, 21, 983, DateTimeKind.Local).AddTicks(887), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Tasty Frozen Bike", 533.189761270697825m, 2.2344483477970631, "P0HOS7WW" },
                    { 86, 1, new DateTime(2025, 2, 8, 12, 14, 19, 677, DateTimeKind.Local).AddTicks(3026), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Practical Metal Fish", 1255.084193726328545m, 2.7101053288279093, "I1T9JWV6" },
                    { 87, 3, new DateTime(2025, 3, 16, 1, 33, 40, 580, DateTimeKind.Local).AddTicks(8747), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Incredible Granite Gloves", 553.678782809306305m, 1.7924349806135425, "577EP4D7" },
                    { 88, 1, new DateTime(2025, 4, 12, 9, 0, 57, 548, DateTimeKind.Local).AddTicks(1240), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Tasty Rubber Car", 381.180567212578960m, 2.0945473173033267, "DRNUMFRO" },
                    { 89, 6, new DateTime(2024, 3, 9, 12, 56, 56, 434, DateTimeKind.Local).AddTicks(4511), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", false, "Licensed Concrete Ball", 580.121228793007325m, 2.8515814060361189, "ZG8XC3HP" },
                    { 90, 6, new DateTime(2025, 5, 24, 14, 42, 6, 47, DateTimeKind.Local).AddTicks(8710), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Rustic Steel Tuna", 296.287854381609995m, 2.169084301779459, "84AIP4EB" },
                    { 91, 4, new DateTime(2024, 2, 26, 7, 47, 34, 711, DateTimeKind.Local).AddTicks(6459), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Ergonomic Rubber Car", 256.058775507294365m, 2.6370811431999419, "C99PDS0X" },
                    { 92, 4, new DateTime(2025, 3, 24, 10, 44, 28, 35, DateTimeKind.Local).AddTicks(9143), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Practical Plastic Sausages", 247.358920448870485m, 4.3395750876633024, "UJNQK3PR" },
                    { 93, 1, new DateTime(2024, 8, 19, 11, 22, 43, 745, DateTimeKind.Local).AddTicks(1581), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Ergonomic Steel Computer", 657.786959392430395m, 4.0263570836740605, "GBZFX1EB" },
                    { 94, 6, new DateTime(2025, 9, 1, 13, 36, 16, 729, DateTimeKind.Local).AddTicks(4028), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", false, "Generic Metal Shirt", 508.355053847602645m, 1.1467769810661652, "OSWI35I6" },
                    { 95, 2, new DateTime(2024, 6, 18, 10, 56, 27, 431, DateTimeKind.Local).AddTicks(3561), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Handmade Wooden Ball", 377.514581535246280m, 4.0765495431256307, "770D9W8O" },
                    { 96, 2, new DateTime(2024, 10, 12, 4, 34, 10, 705, DateTimeKind.Local).AddTicks(819), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Unbranded Plastic Computer", 717.496644009803770m, 1.5112010769470281, "YX97AXTB" },
                    { 97, 2, new DateTime(2024, 4, 10, 16, 14, 16, 691, DateTimeKind.Local).AddTicks(630), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Tasty Soft Salad", 918.055908551017920m, 4.2168064510927383, "NQ30YOFW" },
                    { 98, 2, new DateTime(2024, 1, 7, 3, 47, 19, 469, DateTimeKind.Local).AddTicks(1113), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Practical Plastic Bike", 335.195792487973620m, 2.946311858300076, "SAXEABAU" },
                    { 99, 6, new DateTime(2024, 4, 12, 13, 17, 43, 391, DateTimeKind.Local).AddTicks(7247), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Sleek Cotton Towels", 386.854554232832720m, 4.1420534878911095, "VBLIE721" },
                    { 100, 6, new DateTime(2025, 2, 6, 17, 55, 47, 825, DateTimeKind.Local).AddTicks(1940), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Intelligent Wooden Gloves", 436.158174053404590m, 1.4262077845337648, "AESBHO0Z" },
                    { 101, 3, new DateTime(2024, 6, 24, 22, 34, 29, 969, DateTimeKind.Local).AddTicks(8797), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Generic Frozen Tuna", 1494.549524702754060m, 1.3989542373495492, "8UEB0YMP" },
                    { 102, 2, new DateTime(2025, 2, 20, 9, 28, 18, 933, DateTimeKind.Local).AddTicks(5716), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Tasty Steel Chips", 460.598526136298545m, 1.4465793245211693, "0MLYXWL7" },
                    { 103, 4, new DateTime(2025, 7, 6, 20, 35, 39, 89, DateTimeKind.Local).AddTicks(1972), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Small Frozen Car", 827.008715902478325m, 4.9643119212469733, "HSKNS5Q8" },
                    { 104, 2, new DateTime(2025, 4, 19, 21, 7, 18, 646, DateTimeKind.Local).AddTicks(5099), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", true, "Intelligent Fresh Table", 1129.804598100267240m, 3.8077027233933727, "YGIH1WI1" },
                    { 105, 6, new DateTime(2025, 1, 7, 17, 37, 36, 189, DateTimeKind.Local).AddTicks(9890), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Small Wooden Bike", 790.31360149952775m, 4.8898443073074045, "TRVG3NIH" },
                    { 106, 6, new DateTime(2024, 11, 21, 2, 14, 21, 375, DateTimeKind.Local).AddTicks(5410), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Handmade Granite Keyboard", 368.981339633986555m, 4.0156171440408102, "1MBQ5V66" },
                    { 107, 5, new DateTime(2025, 2, 2, 4, 25, 32, 369, DateTimeKind.Local).AddTicks(3338), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Refined Metal Pants", 170.343840753145990m, 4.6594058702096657, "9VLQBPCZ" },
                    { 108, 6, new DateTime(2024, 4, 23, 1, 14, 4, 870, DateTimeKind.Local).AddTicks(4380), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Fantastic Cotton Fish", 18.59510755788018405m, 1.9097501109291679, "2EQKWCHY" },
                    { 109, 3, new DateTime(2023, 11, 29, 12, 5, 17, 943, DateTimeKind.Local).AddTicks(7243), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Sleek Granite Fish", 700.167274668306245m, 3.2436617386496014, "ER5STFGY" },
                    { 110, 6, new DateTime(2024, 8, 3, 11, 24, 16, 52, DateTimeKind.Local).AddTicks(1934), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Ergonomic Metal Salad", 983.291850012668165m, 2.5514157121249283, "CERLE3XH" },
                    { 111, 1, new DateTime(2024, 7, 5, 5, 42, 38, 929, DateTimeKind.Local).AddTicks(545), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Incredible Cotton Car", 131.5560471249040525m, 3.8695202988592006, "ULQD4IQJ" },
                    { 112, 2, new DateTime(2024, 5, 18, 2, 7, 21, 820, DateTimeKind.Local).AddTicks(5571), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Incredible Frozen Shirt", 378.676384863202395m, 3.3911911684700535, "KLGUT9U0" },
                    { 113, 1, new DateTime(2024, 7, 26, 21, 22, 43, 672, DateTimeKind.Local).AddTicks(3825), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Unbranded Cotton Table", 994.869332684663405m, 3.3257459413048247, "GHZEVRT8" },
                    { 114, 6, new DateTime(2025, 8, 9, 3, 33, 42, 774, DateTimeKind.Local).AddTicks(3032), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Awesome Granite Chicken", 1316.724960331209775m, 4.4076398395965999, "NBJG0TA2" },
                    { 115, 3, new DateTime(2025, 3, 9, 20, 20, 17, 102, DateTimeKind.Local).AddTicks(3556), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Incredible Metal Pants", 894.467448537131425m, 1.9691275108562789, "7VOIXL3T" },
                    { 116, 2, new DateTime(2025, 4, 13, 1, 31, 34, 873, DateTimeKind.Local).AddTicks(6497), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Handmade Granite Car", 865.265477205073485m, 4.2853248371452581, "GKZ0UT41" },
                    { 117, 6, new DateTime(2025, 7, 1, 19, 44, 25, 140, DateTimeKind.Local).AddTicks(4363), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", true, "Ergonomic Rubber Salad", 1183.524408896332355m, 3.7129848285443132, "5R82UEHE" },
                    { 118, 5, new DateTime(2024, 4, 5, 17, 49, 3, 371, DateTimeKind.Local).AddTicks(4971), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Generic Granite Shoes", 959.638149228746970m, 3.7214280756135389, "7PNW3QQD" },
                    { 119, 4, new DateTime(2024, 12, 13, 17, 27, 5, 465, DateTimeKind.Local).AddTicks(6993), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Practical Granite Chips", 691.631891180211795m, 4.4612410142906089, "9694COVP" },
                    { 120, 3, new DateTime(2025, 3, 15, 10, 30, 22, 37, DateTimeKind.Local).AddTicks(1330), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Tasty Metal Soap", 1171.979745387427855m, 2.6153056576346931, "W4AOKUMT" },
                    { 121, 2, new DateTime(2024, 10, 13, 11, 54, 43, 466, DateTimeKind.Local).AddTicks(573), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", false, "Handmade Rubber Car", 257.190850132804960m, 4.7094920423959516, "B5MHRHUU" },
                    { 122, 2, new DateTime(2024, 8, 17, 14, 2, 34, 188, DateTimeKind.Local).AddTicks(9413), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", false, "Small Steel Gloves", 348.180261510629595m, 3.1673759147019469, "V5B7LLFA" },
                    { 123, 5, new DateTime(2024, 10, 7, 0, 46, 23, 651, DateTimeKind.Local).AddTicks(6415), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Handmade Rubber Mouse", 769.429165501121055m, 4.9439826440303616, "04PXX0TS" },
                    { 124, 5, new DateTime(2025, 10, 6, 12, 3, 25, 474, DateTimeKind.Local).AddTicks(6788), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", false, "Sleek Metal Computer", 889.235915990789960m, 2.6438421358496749, "50Z4XG90" },
                    { 125, 3, new DateTime(2025, 10, 24, 9, 10, 46, 763, DateTimeKind.Local).AddTicks(9982), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Handmade Steel Shoes", 67.613575290944665m, 4.5213789007453897, "TL7721IH" },
                    { 126, 3, new DateTime(2025, 5, 5, 2, 15, 31, 483, DateTimeKind.Local).AddTicks(5438), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", true, "Unbranded Cotton Chips", 679.659946508143310m, 3.4988911317067464, "T3F2DT5E" },
                    { 127, 6, new DateTime(2024, 10, 9, 17, 12, 46, 351, DateTimeKind.Local).AddTicks(6512), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Gorgeous Metal Pants", 618.795206066635905m, 3.1603950188057359, "ROZYR7B9" },
                    { 128, 4, new DateTime(2025, 1, 31, 19, 25, 20, 254, DateTimeKind.Local).AddTicks(7702), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", false, "Incredible Soft Pizza", 1440.759101295393030m, 2.1983103064455425, "BJ01XVW9" },
                    { 129, 6, new DateTime(2024, 2, 20, 22, 10, 33, 929, DateTimeKind.Local).AddTicks(9986), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Handmade Metal Shoes", 225.033744673454595m, 3.9159764468690028, "6RJSIFG2" },
                    { 130, 4, new DateTime(2024, 4, 16, 17, 33, 37, 485, DateTimeKind.Local).AddTicks(1568), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Rustic Wooden Pants", 1452.895942564037980m, 3.9475636270722592, "E30JBEYA" },
                    { 131, 4, new DateTime(2025, 6, 15, 16, 43, 56, 520, DateTimeKind.Local).AddTicks(944), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Awesome Metal Hat", 891.262616134344280m, 2.4866736466766834, "OQOKBUR3" },
                    { 132, 2, new DateTime(2025, 8, 22, 10, 22, 46, 315, DateTimeKind.Local).AddTicks(5995), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", true, "Refined Rubber Sausages", 312.793788644290325m, 3.0759849209364272, "39WGSHI6" },
                    { 133, 6, new DateTime(2024, 12, 25, 16, 15, 20, 896, DateTimeKind.Local).AddTicks(1279), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", false, "Rustic Soft Tuna", 410.535179826255310m, 4.1795142188888912, "NQEE4IYG" },
                    { 134, 2, new DateTime(2024, 8, 31, 6, 17, 41, 98, DateTimeKind.Local).AddTicks(4625), "The Football Is Good For Training And Recreational Purposes", true, "Sleek Granite Fish", 922.534306907498735m, 1.5582808799546566, "BZAHTAOZ" },
                    { 135, 6, new DateTime(2024, 10, 24, 0, 59, 0, 926, DateTimeKind.Local).AddTicks(2215), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", false, "Unbranded Soft Ball", 178.978367804894510m, 4.1207469203993901, "B5WZ57UA" },
                    { 136, 5, new DateTime(2024, 1, 22, 4, 32, 38, 245, DateTimeKind.Local).AddTicks(9212), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", true, "Gorgeous Soft Salad", 837.886641733034655m, 2.4701052491893805, "5AWBT9IH" },
                    { 137, 6, new DateTime(2024, 6, 29, 18, 48, 8, 15, DateTimeKind.Local).AddTicks(2083), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", true, "Gorgeous Metal Towels", 299.101012364279510m, 3.9627342219292765, "FMM6VC5M" },
                    { 138, 2, new DateTime(2024, 9, 20, 1, 24, 18, 289, DateTimeKind.Local).AddTicks(6565), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Generic Frozen Tuna", 826.033978827282870m, 1.663365268645395, "74S65HLQ" },
                    { 139, 2, new DateTime(2024, 8, 26, 1, 30, 25, 689, DateTimeKind.Local).AddTicks(4438), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", false, "Intelligent Plastic Fish", 59.9454372270025625m, 4.8450903570843034, "DKQE3ZAQ" },
                    { 140, 3, new DateTime(2024, 11, 25, 21, 31, 31, 64, DateTimeKind.Local).AddTicks(4694), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", false, "Rustic Frozen Pants", 1028.025979960741445m, 1.5774975840979955, "HB1K49KV" },
                    { 141, 5, new DateTime(2024, 10, 4, 16, 25, 53, 325, DateTimeKind.Local).AddTicks(9224), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Licensed Frozen Gloves", 320.637719068307545m, 4.5290180978030676, "VUL3TMG6" },
                    { 142, 1, new DateTime(2025, 10, 6, 15, 27, 28, 184, DateTimeKind.Local).AddTicks(4101), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", true, "Handcrafted Granite Pants", 1375.688400855707375m, 4.9194172610861369, "Q99BXHX1" },
                    { 143, 4, new DateTime(2024, 9, 18, 1, 9, 24, 210, DateTimeKind.Local).AddTicks(1654), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", true, "Sleek Cotton Car", 550.186924630293010m, 3.3168983855811889, "5XPL3ASF" },
                    { 144, 4, new DateTime(2025, 10, 26, 13, 20, 37, 622, DateTimeKind.Local).AddTicks(6687), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", false, "Handcrafted Concrete Soap", 814.528408343391815m, 2.126832420801041, "MZSPWTD0" },
                    { 145, 1, new DateTime(2024, 12, 14, 22, 17, 5, 357, DateTimeKind.Local).AddTicks(8311), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Rustic Cotton Sausages", 319.762714138964325m, 2.5647333908198902, "9C9DOTAS" },
                    { 146, 5, new DateTime(2025, 11, 4, 3, 37, 29, 172, DateTimeKind.Local).AddTicks(368), "The Football Is Good For Training And Recreational Purposes", true, "Fantastic Wooden Tuna", 774.812222850243365m, 4.9992154155856259, "HEDJ0XHK" },
                    { 147, 6, new DateTime(2025, 2, 21, 9, 31, 3, 631, DateTimeKind.Local).AddTicks(748), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", true, "Rustic Steel Ball", 77.545416464999270m, 2.3631854596532484, "4KUOXSQH" },
                    { 148, 3, new DateTime(2024, 3, 9, 21, 38, 4, 567, DateTimeKind.Local).AddTicks(56), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", false, "Small Steel Shoes", 435.982114196267725m, 4.2190405440201921, "MPSN6SD0" },
                    { 149, 1, new DateTime(2024, 4, 27, 0, 31, 50, 863, DateTimeKind.Local).AddTicks(7732), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", true, "Tasty Plastic Pizza", 524.782529157351330m, 3.3635762923350816, "XUU9YWGE" },
                    { 150, 2, new DateTime(2025, 8, 24, 5, 54, 17, 326, DateTimeKind.Local).AddTicks(2857), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", true, "Unbranded Frozen Salad", 1498.97222192962575m, 1.6099898025254684, "EVXATWW2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
