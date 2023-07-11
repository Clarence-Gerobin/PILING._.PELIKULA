using System;
using System.Collections.Generic;

namespace PilingPelikula;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Piling Pelikula!");

        bool exitProgram = false;
        while (!exitProgram)
        {

            int genreChoice = ShowGenreMenu();

            switch (genreChoice)
            {
                case 1:
                    Console.WriteLine("\nChoose a horror movie: ");
                    List<string> horrorMovies = new List<string>
                        {
                            "Clarita",
                            "Aurora",
                            "Sunod"
                        };
                    DisplayMovieList(horrorMovies);
                    break;
                case 2:
                    Console.WriteLine("\nChoose a comedy movie: ");
                    List<string> comedyMovies = new List<string>
                        {
                            "Booba",
                            "Private Benjamin",
                            "Girl, Boy, Bakla, Tomboy"
                        };
                    DisplayMovieList(comedyMovies);
                    break;
                case 3:
                    Console.WriteLine("\nChoose a romantic movie: ");
                    List<string> romanticMovies = new List<string>
                        {
                            "Barcelona: A Love Untold",
                            "Never Not Love You",
                            "Vince, Kath and James"
                        };
                    DisplayMovieList(romanticMovies);
                    break;
                case 4:
                    Console.WriteLine("\nChoose a historical or documentary movie: ");
                    List<string> historicDocuMovies = new List<string>
                        {
                            "The Kingmaster",
                            "Goyo: Ang Batang Heneral",
                            "Heneral Luna"
                        };
                    DisplayMovieList(historicDocuMovies);
                    break;
                case 5:
                    Recommendation r1 = new Recommendation();

                    Console.WriteLine();
                    Console.Write("Enter Movie Name    : ");
                    r1.movieName = Console.ReadLine();

                    Console.Write("Enter Movie Genre   : ");
                    r1.movieGenre = Console.ReadLine();

                    Console.Write("Enter Movie Synopsis: ");
                    r1.movieSynopsis = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nSuccessfully added...");
                    Console.ResetColor();

                    Console.WriteLine("\nCurious to check out your movie suggestion? (yes/no)");
                    Console.Write("Enter your choice: ");
                    string Choice = Console.ReadLine();

                    if (Choice.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                        Console.ResetColor();
                        Console.WriteLine("\nDiscover Your Perfect Movie Pick:");
                        Console.WriteLine();
                        Console.WriteLine("Title     : " + r1.movieName);
                        Console.WriteLine("Genre     : " + r1.movieGenre);
                        Console.WriteLine("Synopsis  : " + r1.movieSynopsis);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                        Console.ResetColor();
                        continue;
                    }
                    else if (Choice.Equals("no", StringComparison.InvariantCultureIgnoreCase)) continue;
                    break;

                case 6:
                    exitProgram = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nExiting the program...");
                    Console.WriteLine("Salamat at sa susunod ulit!");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ResetColor();
                    break;

            }

            if (exitProgram)  break;

            Console.Write("\nEnter your choice: ");
            int movieChoice = Convert.ToInt32(Console.ReadLine());

            switch (genreChoice)
            {
                case 1:
                    switch (movieChoice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m1 = new Movie_Info("Clarita", 2019, "Derick Cabrido",
                                                           "A horror film based on true events. "                       +
                                                           "It tells the story of\n\t       Clarita Villanueva, "       +
                                                           "a young woman who was believed to be \n\t       possessed " +
                                                           "by demons in the 1950s.", "Jodi Sta. Maria as "             +
                                                           "Clarita Villanueva", 101);
                            m1.Show_Detail();
                            m1.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m2 = new Movie_Info("Aurora", 2018, "Yam Laranas",
                                                           "The film revolves around the"                               +
                                                           "mysterious disappearances of "                              +
                                                           "\n\t       passengers on a ferryboat.",
                                                           "Anne Curtis as Leana", 98);
                            m2.Show_Detail();
                            m2.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m3 = new Movie_Info("Sunod", 2019, "Carlo Ledesma",
                                                           "The story follows a single mother "                         +
                                                           "who works at a call center and \n\t       starts"           +
                                                           " experiencing supernatural occurrences.",
                                                           "Carmina Villarroel as Olivia", 96);
                            m3.Show_Detail();
                            m3.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 4:
                            continue;
                        case 5:
                            exitProgram = true;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nExiting the program...");
                            Console.WriteLine("Salamat at sa susunod ulit!");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice.");
                            Console.ResetColor();
                            break;
                    }
                    break;
                case 2:
                    switch (movieChoice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m4 = new Movie_Info("Booba", 2001, "Joyce E. Bernal",
                                                           "It tells the story of a middle-aged "                            +
                                                           "woman who regresses into a \n\t       childlike "                +
                                                           "state after an accident.",
                                                           "Rufa Mae Quinto as Booba", 107);
                            m4.Show_Detail();
                            m4.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m5 = new Movie_Info("Private Benjamin", 1980, "Mike Relon Makiling",
                                                           "The film follows a spoiled young woman who joins "               +
                                                           "the Philippine \n\t       Army and experiences the challenges "  +
                                                           "and humor of military life.",
                                                           "Vice Ganda as Benjamin \"Benjie\" Santos VIII", 115);
                            m5.Show_Detail();
                            m5.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m6 = new Movie_Info("Girl, Boy, Bakla, Tomboy", 2013, "Wenn V. Deramas",
                                                           "The story revolves around quadruplets who were "                 +
                                                           "separated at birth \n\t       and grew up with different "       +
                                                           "gender identities.",
                                                           "Vice Ganda as Girlie, Peter, Mark, and Panying", 105);
                            m6.Show_Detail();
                            m6.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 4:
                            continue;
                        case 5:
                            exitProgram = true;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nExiting the program...");
                            Console.WriteLine("Salamat at sa susunod ulit!");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice.");
                            Console.ResetColor();
                            break;
                    }
                    break;
                case 3:
                    switch (movieChoice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m7 = new Movie_Info("Barcelona: A Love Untold", 2016, "Olivia M. Lamasan",
                                                           "The story revolves around two overseas Filipino workers "         +
                                                           "who meet \n\t       in Barcelona and develop a deep connection.",
                                                           "Kathryn Bernardo as Mia, Daniel Padilla as Ely", 132);
                            m7.Show_Detail();
                            m7.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m8 = new Movie_Info("Never Not Love You", 2018, "Antoinette Jadaone",
                                                           "The story follows a young couple who fall in love and "           +
                                                           "navigate \n\t       the challenges of career and long-distance relationship.",
                                                           "James Reid as Gio, Nadine Lustre as Joanne", 100);
                            m8.Show_Detail();
                            m8.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m9 = new Movie_Info("Vince, Kath and James", 2016, "Theodore Boborol",
                                                           "The story revolves around the lives of three "                    +
                                                           "teenagers involved in \n\t       a love triangle.",    
                                                           "Julia Barretto as Kath, Joshua Garcia as Vince, "                 +
                                                           "Ronnie Alonte as James", 115);
                            m9.Show_Detail();
                            m9.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 4:
                            continue;
                        case 5:
                            exitProgram = true;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nExiting the program...");
                            Console.WriteLine("Salamat at sa susunod ulit!");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice.");
                            Console.ResetColor();
                            break;
                    }
                    break;
                case 4:
                    switch (movieChoice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m10 = new Movie_Info("The Kingmaster", 2019, "Lauren Greenfield",
                                                           "This documentary provides a unique perspective "                     +
                                                           "on the \n\t       political journey of Imelda Marcos. "              +
                                                           "It serves as a cautionary tale \n\t       about a powerful "         +
                                                           "leader whose questionable perception of reality "                    +
                                                           "\n\t       caused divisions within the Philippines",
                                                           "Marcos Family (Imelda Marcos)", 100);
                            m10.Show_Detail();
                            m10.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m11 = new Movie_Info("Goyo: Ang Batang Heneral", 2018, "Jerrold Tarog",
                                                           "It focuses on the life and heroism of "                              +
                                                           "General Gregorio \"Goyo\" \n\t       del Pilar, a "                  +
                                                           "prominent figure in the Philippine "                                 +
                                                           "Revolution and \n\t       the Philippine-American "                  +
                                                           "War.", "Paulo Avelino as General Gregorio "                          +
                                                           "\"Goyo\" del Pilar", 155);
                            m11.Show_Detail();
                            m11.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            Console.WriteLine("\nMovie Details:");
                            Movie_Info m12 = new Movie_Info("Heneral Luna", 2015, "Jerrold Tarog",
                                                           "It depicts the life and events surrounding the "                     +
                                                           "controversial\n               Filipino General Antonio Luna during " +
                                                           "the Philippine-American War."
                                                           , "John Arcilla as General Antonio Luna", 118);
                            m12.Show_Detail();
                            m12.Show_Details();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
                            Console.ResetColor();
                            break;
                        case 4:
                            continue;
                        case 5:
                            exitProgram = true;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nExiting the program...");
                            Console.WriteLine("Salamat at sa susunod ulit!");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice.");
                            Console.ResetColor();
                            break;
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ResetColor();
                    break;

            }

        }

    }

    static int ShowGenreMenu()
    {
        Console.WriteLine("\nChoose a genre: ");
        Console.WriteLine("1. Horror");
        Console.WriteLine("2. Comedy");
        Console.WriteLine("3. Romance");
        Console.WriteLine("4. History and Documentary");
        Console.WriteLine("5. Add Movie Recommendation");
        Console.WriteLine("6. Exit");

        Console.Write("\nEnter your choice: ");
        int genreChoice = Convert.ToInt32(Console.ReadLine());
        return genreChoice;
    }

    static void DisplayMovieList(List<string> movies)
    {
        for (int m = 0; m < movies.Count; m++)
        {
            Console.WriteLine($"{m + 1}. {movies[m]}");
        }
        Console.WriteLine("4. Go back to genre selection");
        Console.WriteLine("5. Exit");

    }

}


