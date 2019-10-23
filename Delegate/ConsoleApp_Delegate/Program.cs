using System;

namespace ConsoleApp_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tester t = new Tester();
            t.Run();
        }
    }
    #region Delegates
    public class Tester
    {
        public void Run()
        {
            MediaStorage myMediaStorage = new MediaStorage();

            // instantiate the two media players
            AudioPlayer myAudioPlayer = new AudioPlayer();
            VideoPlayer myVideoPlayer = new VideoPlayer();

            // instantiate the delegates
            MediaStorage.PlayMedia audioPlayerDelegate = new
                   MediaStorage.PlayMedia(myAudioPlayer.PlayAudioFile);
            MediaStorage.PlayMedia videoPlayerDelegate = new
                   MediaStorage.PlayMedia(myVideoPlayer.PlayVideoFile);

            // call the delegates
            myMediaStorage.ReportResult(audioPlayerDelegate);
            myMediaStorage.ReportResult(videoPlayerDelegate);

        }

        public class MediaStorage
        {
            public delegate int PlayMedia();

            public void ReportResult(PlayMedia playerDelegate)
            {
                if (playerDelegate() == 0)
                {
                    Console.WriteLine("Media played successfully.");
                }
                else
                {
                    Console.WriteLine("Media did not play successfully.");
                }
            }
        }

        public class AudioPlayer
        {
            private int audioPlayerStatus;

            public int PlayAudioFile()
            {
                Console.WriteLine("Simulating playing an audio file here.");
                audioPlayerStatus = 0;
                return audioPlayerStatus;
            }
        }

        public class VideoPlayer
        {
            private int videoPlayerStatus;

            public int PlayVideoFile()
            {
                Console.WriteLine("Simulating a failed video file here.");
                videoPlayerStatus = -1;
                return videoPlayerStatus;
            }
        }

        
    }


    #endregion //Delegates
}
