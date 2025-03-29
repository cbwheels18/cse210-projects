using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial For Beginners - Learn C# Basics in 1 Hour", "Programming with Mosh", 4232);
        Comment video1comment1 = new Comment("Saeedhashemi1994", "thank u for teaching us in dark mode");
        Comment video1comment2 = new Comment("gem8273", "It was the best lecture I've seen so far. Also, your accent is really clear for someone like me who is not native Enlgish is smooth and understandable. I appreciate it thanks.");
        Comment video1comment3 = new Comment("xionic1194", "The first tutorial I have seen that tells you to go on stack overflow");
        Comment video1comment4 = new Comment("abdulladil55", "Console.Writeline('Hello World');'Momma I became a programmer!'");
        video1.comments.Add(video1comment1);
        video1.comments.Add(video1comment2);
        video1.comments.Add(video1comment3);
        video1.comments.Add(video1comment4);

        Video video2 = new Video("Learn C# BASICS in 10 MINUTES!", "Code Monkey", 654);
        Comment video2comment1 = new Comment("kkyajTV1512", "For a complete beginner, this will go over their head. But after spending some time in a beginner's course and learning code, this is basically a solid cheat sheet and/or solid summary review.");
        Comment video2comment2 = new Comment("them0rningstar", "I'm currently in the process of learning C# as my first coding language, and this is amazing to recap different things i learnt or for remembering stuff after i haven't programmed in a while! Great video!");
        Comment video2comment3 = new Comment("sty1623", "This is really helpful for people who have had some experience with coding in the past. Doesnt seem really beginner friendly since its really fast and it coveres a lot of topics");
        Comment video2comment4 = new Comment("bennyd47", "This video is absolutely solid. Covers so many little 'gotchas' with regards to scope and basic syntax. As someone who switches languages / projects often, thanks for the great refresher!");
        video2.comments.Add(video2comment1);
        video2.comments.Add(video2comment2);
        video2.comments.Add(video2comment3);
        video2.comments.Add(video2comment4);

        Video video3 = new Video("C# Tutorial - Full Course for Beginners", "freeCodeCamp.org", 16268);
        Comment video3comment1 = new Comment("datonedoctor-archives6295", "The fact that this man spent 4 hours teaching code and doesn’t add ads so we the viewers could learn.  Mad respect my man.");
        Comment video3comment2 = new Comment("anneliesvanhagen4116", "Finally found someone who doesn’t skip steps explaining, so even people like me not knowing anything about programming can follow. Thank you Mike");
        Comment video3comment3 = new Comment("littlecurrybread", "I'm at the end of this video, and I swear to you, this guy has a natural talent for teaching programming. I've read so many books, watched so many videos, and he understands how to break things down in such a simple way. Really love his teaching style.");
        Comment video3comment4 = new Comment("olpersmak", "He knows about C# he knows about C++, He's younger then me , He's a master he knows how to teach. What a gem he is.");
        video3.comments.Add(video3comment1);
        video3.comments.Add(video3comment2);
        video3.comments.Add(video3comment3);
        video3.comments.Add(video3comment4);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"- Username: {comment._userName} \nComment: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}