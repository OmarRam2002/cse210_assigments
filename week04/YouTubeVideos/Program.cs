using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        //Video Number 1
        Video video1 = new Video("Under Control","Alesso",184);
        Comment comment11 = new Comment("@djbela","I want another EDM golden era like this");
        Comment comment12 = new Comment("@newvegarryl2","Under Control no es una canción, es un sentimiento.");
        Comment comment13 = new Comment("@RAHULSHAW31","Anyone in October 2025?");
        video1.AddComment(comment11);
        video1.AddComment(comment12);
        video1.AddComment(comment13);

        //Video Number 2
        Video video2 = new Video("Oh Lord","NF",199);
        Comment comment21 = new Comment("@stonewarriors5542","Ain't nobody wanna pray until the got something to pray for That is a fire verse");
        Comment comment22 = new Comment("@aman-jm2hx","God bless everyone even the people that never seen this.");
        Comment comment23 = new Comment("@wonrategear7762","He is watching and seeing everythings");
        video2.AddComment(comment21);
        video2.AddComment(comment22);
        video2.AddComment(comment23);

        Video video3 = new Video("Hey","Julio Iglesias",300);
        Comment comment31 = new Comment("@macooler","Esta canción no es una joya.... es un diamante!");
        Comment comment32 = new Comment("@WatchMovies-g8x","Aqui con 15 escuchando al mejor de todos los tiempos");
        Comment comment33 = new Comment("@xxdiorkisxx324","Una exquisitez de canciones de nuestra época");
        video3.AddComment(comment31);
        video3.AddComment(comment32);
        video3.AddComment(comment33);

        
        //Adding vidoes to the list 
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        
        foreach (var item in videos)
        {
            Console.WriteLine(item.DisplayText());
        }
        

    }
}