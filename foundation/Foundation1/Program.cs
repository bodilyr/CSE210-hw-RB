using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

    //create 3-4 videos
        Video videoA = new Video("Study Music Playlist", "Yanni", 14400);
        Video videoB = new Video("Best of America's Got Talent", "NBC Productions", 1800);
        Video videoC = new Video("Christmas Lights Fails", "America's Funniest Videos", 457);

    //add commments to videos (3-4 comments per video)
        videoA.AddComment(new Comment("Azure", "It was amazing how quickly I was able to focus and complete my assignment."));
        videoA.AddComment(new Comment("Sawyer", "This wasn't really my jam, but it could legit be my sleep playlist!"));
        videoA.AddComment(new Comment("Brooks", "I had some deja vu moments.  I think my mom listened to this dude a lot!"));

        videoB.AddComment(new Comment("Fern", "Why does Simon always have to be so mean?  Rudneness isn't ok..."));
        videoB.AddComment(new Comment("Malachi", "The dancers totally ROCKED!"));
        videoB.AddComment(new Comment("Cora", "I wish I had the guts to try out for this show."));

        videoC.AddComment(new Comment("Anthony", "Dude, this wasn't funny, it was basically autobiographical.  I think I had a PTSD episode."));
        videoC.AddComment(new Comment("Elowyn", "I laughed so hard I burst a blood vessel in my right eye!"));
        videoC.AddComment(new Comment("Jackson", "I'm not going near a ladder anytime soon!  Hahaha :)"));

    //add videos to list
        videos.Add(videoA);
        videos.Add(videoB);
        videos.Add(videoC);

    //have the program iterate through video list displaying title, author, length, number of comments and text of comments

    Console.Clear();

    foreach (Video video in videos)
    {
        Console.WriteLine($"Title:  {video.GetTitle()}");
        Console.WriteLine($"Author:  {video.GetAuthor()}");
        Console.WriteLine($"Length [secs]:  {video.GetLengthSeconds()}");
        Console.WriteLine($"Number of Comments:  {video.GetNumberOfComments()}");

        List<Comment> comments = video.GetComments();
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"Comment made by {comment.GetName()}:  {comment.GetText()}");
        }
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }



    }
}