using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2._10_exercises
{

    class Program
    {
        static void Main(string[] args)
        {
            //var watch1 = new Stopwatch();

            //watch1.Start();

            //Thread.Sleep(1000);

            //watch1.Stop();

            //var interval = watch1.GetInterval();

            //Console.WriteLine(interval.TotalMilliseconds + "ms");
            //Console.ReadLine();

            var my1stPost = new StackOverflow("test Title", "test Description");

            my1stPost.UpVote();
            my1stPost.UpVote();
            my1stPost.UpVote();
            Console.WriteLine("Post title: {0}, Post Description: {1}, Post created on the: {2}", my1stPost.GetTitle(), my1stPost.GetDescription(), my1stPost.GetDateCreated());
            Console.WriteLine("Total Likes (expected 3): " + my1stPost.GetLikeCounter());
            my1stPost.DownVote();
            Console.WriteLine("Total Likes (expected 2): " + my1stPost.GetLikeCounter());


        }
    }
}
