using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        //Video Number 1
        Video video1 = new Video("Under Control","Alesso",184);
        Comment comment11 = new Comment("@djbela","I want another EDM golden era like this");
        video1.AddComment(comment11);

        //Video Number 2
        Video video2 = new Video("Oh Lord","NF",199);
        Comment comment21 = new Comment("@djbela","I want another EDM golden era like this");
        video2.AddComment(comment21);

        Video video3 = new Video("Hey","Julio Iglesias",300);
        Comment comment31 = new Comment("@djbela","I want another EDM golden era like this");
        video3.AddComment(comment31);

        Video video4 = new Video("The Older I get","Bryan Andrews",193);
        Comment comment41 = new Comment("@djbela","I want another EDM golden era like this");
        video4.AddComment(comment41);
        //Adding vidoes to the list 
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        
        foreach (var item in videos)
        {
            Console.WriteLine(item.DisplayText());
        }
        

    }
}