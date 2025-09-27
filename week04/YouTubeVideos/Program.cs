using System;

class Program
{
    static void Main(string[] args)
    {
        //First Video
        Video video1 = new Video("video1", "Thailis", 300);

        video1.AddCommentToList(new Comment("Tomas", "Nice video!"));
        video1.AddCommentToList(new Comment("Camila", "I love it!"));
        video1.AddCommentToList(new Comment("Aaron", "It is Amazing!"));

        //Second Video
        Video video2 = new Video("video2", "Tomas", 550);

        video2.AddCommentToList(new Comment("Thailis", "Oooo Incredible!"));
        video2.AddCommentToList(new Comment("Camila", "The best video :o"));
        video2.AddCommentToList(new Comment("Aaron", "Super Wow!"));

        //Third Video

        Video video3 = new Video("video3", "Camila", 150);

        video3.AddCommentToList(new Comment("Tomas", "Wohoo!"));
        video3.AddCommentToList(new Comment("Thailis", "Sooo nicee!"));
        video3.AddCommentToList(new Comment("Aaron", "Incredibleee!"));

        //Fourth Video
        Video video4 = new Video("video4", "Aaron", 150);

        video4.AddCommentToList(new Comment("Tomas", "Nice video!"));
        video4.AddCommentToList(new Comment("Camila", "I love it!"));
        video4.AddCommentToList(new Comment("Thailis", "It is Amazing!"));

        List<Video> videos = new List<Video>
        {
            video1, video2, video3, video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayInformation() + "\n");
            video.DisplayComments();
            Console.WriteLine("");
        }
    }
}