using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Exercises
{
    public class VariableData
    {
        public void Method1()
        {
            //Console.WriteLine("Signed integral types:");

            //Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            //Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            //Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            //Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            //Console.WriteLine("");
            //Console.WriteLine("Unsigned integral types:");

            //Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            //Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            //Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            //Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            //Console.WriteLine("");
            //Console.WriteLine("Floating point types:");
            //Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            //Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            //Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            //int[] data;
            //data = new int[3];
            int[] data = new int[3];

            string shortenedString = "Hello World";
            Console.WriteLine(shortenedString);

            int val_A = 2;
            int val_B = val_A;
            val_B = 5;

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}");
            Console.WriteLine($"val_B: {val_B}");

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");

            /*
            int for most whole numbers
            decimal for numbers representing money
            bool for true or false values
            string for alphanumeric value

            byte: working with encoded data that comes from other computer systems or using different character sets.
            double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
            System.DateTime for a specific date and time value.
            System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
            */
        }

        public void Method2()
        {
            /*
            Array.Sort() and Array.Reverse() methods are used to sort and reverse the elements of an array.
            */
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* reverse sorted */
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Reversed...");
            //Array.Reverse(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* Clear() and Resize() */
            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}


            /* remove using resize */
            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6);
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            /* Split() and Join() */
            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            ////string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);
            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}

            /* project solution 1*/
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            // split at every comma
            string[] items = orderStream.Split(',');

            // Alphabetically sort array in-place
            Array.Sort(items);

            // Walk the sorted array and print each code

            foreach (var item in items)
            {
                if (item.Length == 4)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + "\t- Error");
                }
            }
        }

        public void StringFormatting()
        {
            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine("{1} {0}!", first, second);
            //Console.WriteLine("{0} {0} {0}!", first, second);

            //string first = "Hello";
            //string second = "World";
            //Console.WriteLine($"{first} {second}!");
            //Console.WriteLine($"{second} {first}!");
            //Console.WriteLine($"{first} {first} {first}!");

            //// currency
            //decimal price = 123.45m;
            //int discount = 50;
            //Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            //// Numbers
            //decimal measurement = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement:N} units");
            //// two digits
            //decimal measurement2 = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement2:N4} units");
            //// combining
            //decimal price2 = 67.55m;
            //decimal salePrice = 59.99m;

            //string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

            //Console.WriteLine(yourDiscount);


            // second tutorial
            //int invoiceNumber = 1201;
            //decimal productShares = 25.4568m;
            //decimal subtotal = 2750.00m;
            //decimal taxPercentage = .15825m;
            //decimal total = 3185.19m;

            //Console.WriteLine($"Invoice Number: {invoiceNumber}");
            //Console.WriteLine($"   Shares: {productShares:N3} Product");
            //Console.WriteLine($"     Sub Total: {subtotal:C}");
            //Console.WriteLine($"           Tax: {taxPercentage:P2}");
            //Console.WriteLine($"     Total Billed: {total:C}");

            // third padding
            //string input = "Pad this";
            //Console.WriteLine(input.PadLeft(12));
            //Console.WriteLine(input.PadLeft(12, '-'));
            //Console.WriteLine(input.PadRight(12, '-'));

            // fourth name output
            //string paymentId = "769C";
            //string payeeName = "Mr. Stephen Ortega";
            //string paymentAmount = "$5,000.00";

            //var formattedLine = paymentId.PadRight(6);
            //formattedLine += payeeName.PadRight(24);
            //formattedLine += paymentAmount.PadLeft(10);

            //Console.WriteLine("1234567890123456789012345678901234567890");
            //Console.WriteLine(formattedLine);


            // Project
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
            Console.WriteLine($"\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}");
            Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}");
            Console.WriteLine("\nHere's a quick comparison:");


            Console.WriteLine($"{currentProduct.PadRight(19)} {currentReturn:P2}  {currentProfit:C}");
            Console.WriteLine($"{newProduct.PadRight(19)} {newReturn:P2}  {newProfit:C}");


            /* alternate return solution */
            //string comparisonMessage = "";

            //comparisonMessage = currentProduct.PadRight(20);
            //comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            //comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            //comparisonMessage += "\n";
            //comparisonMessage += newProduct.PadRight(20);
            //comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            //comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            //Console.WriteLine(comparisonMessage);
        }

        public void IndexOfSubstring()
        {
            //string message = "Find what is (inside the parentheses)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');

            ////Console.WriteLine(openingPosition);
            ////Console.WriteLine(closingPosition);

            //openingPosition += 1;

            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length));


            /* 2 */
            //string message = "What is the value <span>between the tags</span>?";

            //int openingPosition = message.IndexOf("<span>");
            //int closingPosition = message.IndexOf("</span>");

            //openingPosition += 6;
            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length));

            /* avoid magic values */
            //string message2 = "What is the value <span>between the tags</span>?";

            //const string openSpan = "<span>";
            //const string closeSpan = "</span>";

            //int openingPosition2 = message.IndexOf(openSpan);
            //int closingPosition2 = message.IndexOf(closeSpan);

            //openingPosition2 += openSpan.Length;
            //int length2 = closingPosition2 - openingPosition2;
            //Console.WriteLine(message.Substring(openingPosition2, length2));



            //string message3 = "Hello, it is I <span> The Emperor </span>.";

            ///* return the text inside of the span start and end */
            //string spanOpen = "<span>";
            //string spanEnd = "</span>";

            //// define where to start the return
            //int startPosition3 = message3.IndexOf(spanOpen);
            //int endPosition3 = message3.IndexOf(spanEnd);

            //startPosition3 += spanOpen.Length;

            //// define length
            //int length3 = endPosition3 - startPosition3;
            //Console.WriteLine(message3.Substring(startPosition3, length3));


            //string message = "hello there!";

            //int first_h = message.IndexOf('h');
            //int last_h = message.LastIndexOf('h');

            //Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


            //string message = "(What if) there are (more than) one (set of parentheses)?";
            //while (true)
            //{
            //    int openingPosition = message.IndexOf('(');
            //    if (openingPosition == -1) break;

            //    openingPosition += 1;
            //    int closingPosition = message.IndexOf(')');
            //    int length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length));

            //    // Note the overload of the Substring to return only the remaining 
            //    // unprocessed message:
            //    message = message.Substring(closingPosition + 1);


            //}


            /* searching for specific letters */
            //string message = "Hello, world!";
            //char[] charsToFind = { 'a', 'e', 'i' };

            //int index = message.IndexOfAny(charsToFind);

            //Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

            /* next example */
            //string message = "Help (find) the {opening symbols}";
            //Console.WriteLine($"Searching THIS Message: {message}");
            //char[] openSymbols = { '[', '{', '(' };
            //int startPosition = 5;
            //int openingPosition = message.IndexOfAny(openSymbols);
            //Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            //openingPosition = message.IndexOfAny(openSymbols, startPosition);
            //Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");



            /*Find substrings in a string that are between any symbol and return them  */
            //string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            //// The IndexOfAny() helper method requires a char array of characters. 
            //// You want to look for:

            //char[] openSymbols = { '[', '{', '(' };

            //// You'll use a slightly different technique for iterating through 
            //// the characters in the string. This time, use the closing 
            //// position of the previous iteration as the starting index for the 
            ////next open symbol. So, you need to initialize the closingPosition 
            //// variable to zero:

            //int closingPosition = 0;

            //while (true)
            //{
            //    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            //    if (openingPosition == -1) break;

            //    string currentSymbol = message.Substring(openingPosition, 1);

            //    // Now  find the matching closing symbol
            //    char matchingSymbol = ' ';

            //    switch (currentSymbol)
            //    {
            //        case "[":
            //            matchingSymbol = ']';
            //            break;
            //        case "{":
            //            matchingSymbol = '}';
            //            break;
            //        case "(":
            //            matchingSymbol = ')';
            //            break;
            //    }

            //    // To find the closingPosition, use an overload of the IndexOf method to specify 
            //    // that the search for the matchingSymbol should start at the openingPosition in the string. 

            //    openingPosition += 1;
            //    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            //    // Finally, use the techniques you've already learned to display the sub-string:

            //    int length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length));

            /* Remove and Replace methds */
            //string data = "12345John Smith          5000  3  ";
            //string updatedData = data.Remove(5, 20);
            //Console.WriteLine(updatedData);

            ///* Remove char no matter where they appear */
            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);
            //}





            /* Challenge, Microsoft solution :/ */
            //const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            //string quantity = "";
            //string output = "";

            //// Your work here

            //// Extract the "quantity"
            //const string openSpan = "<span>";
            //const string closeSpan = "</span>";

            //int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            //int quantityEnd = input.IndexOf(closeSpan);
            //int quantityLength = quantityEnd - quantityStart;
            //quantity = input.Substring(quantityStart, quantityLength);
            //quantity = $"Quantity: {quantity}";

            //// Set output to input, replacing the trademark symbol with the registered trademark symbol
            //const string tradeSymbol = "&trade;";
            //const string regSymbol = "&reg;";
            //output = input.Replace(tradeSymbol, regSymbol);

            //// Remove the opening <div> tag
            //const string openDiv = "<div>";
            //int divStart = output.IndexOf(openDiv);
            //output = output.Remove(divStart, openDiv.Length);

            //// Remove the closing </div> tag and add "Output:" to the beginning
            //const string closeDiv = "</div>";
            //int divCloseStart = output.IndexOf(closeDiv);
            //output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            //Console.WriteLine(quantity);
            //Console.WriteLine(output);







            /* Challenge (My solution), extract replace and remove data from an input string */
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            // define open and closing for span wrapper
            string spanOpen = "<span>";
            string spanClose = "</span>";

            // find the index start of span
            int startPosition = input.IndexOf(spanOpen);
            // start at end of span open
            startPosition += spanOpen.Length;
            // get start of endPosition index
            int endPosition = input.IndexOf(spanClose);
            // get substring
            int length = endPosition - startPosition;

            quantity = ($"Quantity: {input.Substring(startPosition, length)}");

            string divOpen = "<div>";
            string divClose = "</div>";

            int divStartPosition = input.IndexOf(divOpen);
            divStartPosition += divOpen.Length;
            int divEndPosition = input.IndexOf(divClose);
            int divLength = divEndPosition - divStartPosition;

            output = $"Output: {input.Substring(divStartPosition, divLength)}";

            output = output.Replace("&trade", "&reg");

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }

        public void Project()
        {
            /*
            For the new features of the Contoso Pets application, the design specification provides details for the dog search and suggested donation features:

            Dog attribute search

            Gather input for the pet characteristic search term
            Loop through the animals array and identify "dogs"
            For each dog, combine the physical and personality descriptions to search
            Search the combined description for the input term match
            Output the dogs that have a term match
            Suggested donation data

            Define suggestedDonation string
            Expand the ourAnimals array to contain suggestedDonation and populate sample data for suggestedDonation
            Ensure all usage of ourAnimals array accounts for the added suggestedDonation data
            Output suggestedDonation with regional currency symbol ($, €, ¥,... )


            1. List all of our current pet information
            2. Display all dogs with a specified characteristic

            Enter menu item selection or type "Exit" to exit the program
            */

            // using System;

            // #1 the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // #2 variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            decimal decimalDonation = 0.00m;

            // #3 array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 7];

            // #4 create sample data ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        suggestedDonation = "85.00";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";
                        suggestedDonation = "49.99";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";
                        suggestedDonation = "40.00";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "lion";
                        suggestedDonation = "";

                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if (!decimal.TryParse(suggestedDonation, out decimalDonation))
                {
                    decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
                }
                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            }

            // #5 display the top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // use switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // list all pet info
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 7; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Display all dogs with a specified characteristic");

                        string dogCharacteristic = "";

                        while (dogCharacteristic == "")
                        {
                            // have the user enter physical characteristics to search for
                            Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                dogCharacteristic = readResult.ToLower().Trim();
                            }
                        }

                        bool noMatchesDog = true;
                        string dogDescription = "";

                        // #6 loop through the ourAnimals array to search for matching animals
                        for (int i = 0; i < maxPets; i++)
                        {
                            bool dogMatch = true;

                            if (ourAnimals[i, 1].Contains("dog"))
                            {

                                if (dogMatch == true)
                                {
                                    // #7 Search combined descriptions and report results
                                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];


                                    if (dogDescription.Contains(dogCharacteristic))
                                    {
                                        Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                        Console.WriteLine(dogDescription);

                                        noMatchesDog = false;
                                    }
                                }
                            }
                        }

                        if (noMatchesDog)
                        {
                            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                        }

                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");
        }

        public void ChallengeProject()
        {
            // ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            decimal decimalDonation = 0.00m;

            // array used to store runtime data
            string[,] ourAnimals = new string[maxPets, 7];

            // sample data ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        suggestedDonation = "85.00";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "gus";
                        suggestedDonation = "49.99";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "snow";
                        suggestedDonation = "40.00";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "lion";
                        suggestedDonation = "";

                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        suggestedDonation = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                if (!decimal.TryParse(suggestedDonation, out decimalDonation))
                {
                    decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
                }
                ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
            }

            // top-level menu options
            do
            {
                // NOTE: the Console.Clear method is throwing an exception in debug sessions
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                // switch-case to process the selected menu option
                switch (menuSelection)
                {
                    case "1":
                        // list all pet info
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 7; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }

                        Console.WriteLine("\r\nPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // #1 Display all dogs with a multiple search characteristics

                        string dogCharacteristic = "";
                        string[] dogCharacteristics = [];

                        while (dogCharacteristic == "")
                        {
                            // #2 have user enter multiple comma separated characteristics to search for
                            Console.WriteLine($"\r\nEnter one desired dog characteristic to search for, or multiple searches seperated by a comma.");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                dogCharacteristic = readResult.ToLower().Trim();
                                // split at every comma
                                dogCharacteristics = dogCharacteristic.Split(',');
                                Array.Sort(dogCharacteristics);
                                Console.WriteLine();
                            }
                        }

                        bool noMatchesDog = true;
                        string dogDescription = "";
                        int matchCount = 0;

                        // #4 update to "rotating" animation with countdown
                        string[] searchingIcons = { ".  ", ".. ", "..." };
                        string[] spinIcons = { "/ 2", "-- 1", "\\ 1", "* 0" };

                        // loop ourAnimals array to search for matching animals
                        for (int i = 0; i < maxPets; i++)
                        {

                            if (ourAnimals[i, 1].Contains("dog"))
                            {

                                // Search combined descriptions and report results
                                dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];

                                //for (int j = 5; j > -1; j--)
                                //{
                                //    // #5 update "searching" message to show countdown 
                                //    foreach (string icon in searchingIcons)
                                //    {
                                //        Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {dogCharacteristic} {icon}");
                                //        Thread.Sleep(250);
                                //    }

                                //    Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                                //}


                                if (dogCharacteristics != null)
                                {
                                    foreach (var dogChar in dogCharacteristics)          // <- term first
                                    {
                                        for (int k = 5; k > -1; k--)
                                        {
                                            foreach (string spinIcon in spinIcons)
                                            {
                                                Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {dogChar} {spinIcon}   ");
                                                Thread.Sleep(250);
                                            }
                                        }
                                        Console.Write($"\r{new String(' ', Console.BufferWidth)}"); // clear after each term
                                    }
                                }

                                // #3a iterate submitted characteristic terms and search description for each term
                                if (dogDescription.Contains(dogCharacteristic))
                                {
                                    // #3b update message to reflect term 
                                    // #3c set a flag "this dog" is a match
                                    Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");

                                    noMatchesDog = false;
                                    matchCount++;
                                }

                                if (dogCharacteristics != null)
                                {
                                    foreach (var dogChar in dogCharacteristics)
                                    {
                                        if (dogDescription.Contains(dogChar))
                                        {
                                            Console.WriteLine($"\nOur dog {ourAnimals[i, 3].Substring(10)} is a match for your search \"{dogChar}\"");

                                            noMatchesDog = false;
                                            matchCount++;
                                        }
                                    }
                                }

                                if (matchCount > 0)
                                {
                                    Console.WriteLine($"\n{ourAnimals[i, 3]} ({ourAnimals[i, 0]}).\n{ourAnimals[i, 4]}.\n{ourAnimals[i, 5]}.");

                                }

                                // #3d if "this dog" is match write match message + dog description
                            }
                        }

                        if (noMatchesDog)
                        {
                            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                        }

                        if (matchCount == 0)
                        {
                            Console.WriteLine("No matches found for any available dogs");
                        }

                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");

        }
    }
}
