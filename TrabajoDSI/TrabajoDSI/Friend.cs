using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{
    public class Friend
    {
        public string name { get; set; }
        public string profilePic { get; set; }
        public string connectionStatus { get; set; }
        public string bubbleSpeak { get; set; }
    }

    public class InitializeFriendsList
    {
        public static List<Friend> initializeFriends()
        {
            List<Friend> fl = new List<Friend>();
            fl.Add(new Friend
            {
                name = "Yukilled",
                profilePic = "/Assets/Friend1.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Connected.png"
            });
            fl.Add(new Friend
            {
                name = "PaulkMV",
                profilePic = "/Assets/Friend2.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Connected.png"
            });
            fl.Add(new Friend
            {
                name = "PertGmr",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Connected.png"
            });
            fl.Add(new Friend
            {
                name = "AntonioTOUHOU",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Connected.png"
            });
            fl.Add(new Friend
            {
                name = "FenomenCoyote",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Connected.png"
            });
            fl.Add(new Friend
            {
                name = "Estrujillo",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "RandomPlayer",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "YOLO",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "Deivid4U",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "Willyrex",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "DalasReview",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });
            fl.Add(new Friend
            {
                name = "cemasmas",
                profilePic = "/Assets/Friend3.png",
                bubbleSpeak = "/Assets/bocadillo.png",
                connectionStatus = "/Assets/Disconnected.png"
            });

            return fl;
        }
    }
}
