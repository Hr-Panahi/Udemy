using System;


namespace Inheritance_132
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post();
            Console.WriteLine(post1.ToString());

            Post post2 = new Post("Hello World", "Hamid", true);
            Console.WriteLine(post2.ToString());

            post2.Update("Update: Hello World!", true);
            Console.WriteLine(post2.ToString());

            ImagePost imagePost1 = new ImagePost("My New Laptop", "Mohammad",
                "https://amazon.com/laptops/2", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Snifty's Gameplay", "Eaglet", 
                "https://youtube.come/snifty/2312%32fb", 10, true);
            Console.WriteLine(videoPost1.ToString());


            Console.WriteLine("Press Enter to start playing the video.");
            Console.ReadKey();
            videoPost1.Play(); // Start playing the video

            Console.WriteLine("Press any key to pause the video...");
            Console.ReadKey(); // Wait for user input

            videoPost1.Stop(); // Pause the video
        }
    }
}
