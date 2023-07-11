using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilingPelikula;

public class Movie_Info
{
    public string MovieName, MovieDirector;
    public string MovieSynopsis, MovieCast;
    public int MovieRelease, MovieRuntime;

    public Movie_Info(string MovieName, int MovieRelease, string Director, string MovieSynopsis, string MovieCast, int Runtime)
    {
        this.MovieName = MovieName;
        this.MovieRelease = MovieRelease;
        this.MovieDirector = Director;
        this.MovieSynopsis = MovieSynopsis;
        this.MovieCast = MovieCast;
        this.MovieRuntime = Runtime;
    }

    public void Show_Detail()
    {
        Console.WriteLine();
        Console.WriteLine("Title        : " + MovieName);
    }

    public void Show_Details()
    {
        Console.WriteLine("Release Date : " + MovieRelease);
        Console.WriteLine("Director     : " + MovieDirector);
        Console.WriteLine("Main Cast    : " + MovieCast);
        Console.WriteLine("Duration     : " + MovieRuntime + " " + "minutes");
        Console.WriteLine("Synopsis     : " + MovieSynopsis);
    }

}
