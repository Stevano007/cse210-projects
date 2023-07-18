using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Mayor", "Goldrick", 120);
        video1.AddComment(new Comment("John","This is a great video!"));
        video1.AddComment(new Comment("Jane","i dont know how to feel about this content!"));
        video1.AddComment(new Comment("Dave","This should be banned!"));
        videos.Add(video1);

        Video video2 = new Video("Gold Dust", "Markurly", 50);
        video2.AddComment(new Comment("Mark","This video is too short"));
        video2.AddComment(new Comment("Ferguson","Lovely"));
        video2.AddComment(new Comment("Dave","This is not acceptable"));
        videos.Add(video2);

        Video video3 = new Video("Suits", "Mark Angel", 300);
        video3.AddComment(new Comment("Mark","This video is too long"));
        video3.AddComment(new Comment("Stonebridge","Immaculate!"));
        video3.AddComment(new Comment("Dave","Hmm, i reserve my comment"));
        videos.Add(video3);

        foreach(Video video in videos){
            Console.WriteLine($"{video._title} by {video._author}, Length: {video._length}");
            Console.WriteLine($"This video has {video.CommentCount()} comments");
            Console.WriteLine("Comments: ");
            Console.WriteLine();
            foreach(Comment comment in video.comments){
                Console.WriteLine($"{comment._text}, Commented by: {comment._name} ");
                Console.WriteLine();
            }
            Console.WriteLine();
}
}
}