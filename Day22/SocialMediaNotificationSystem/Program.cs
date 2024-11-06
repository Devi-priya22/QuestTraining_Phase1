using System;
using SocialMediaNotificationSystem.Models;
using SocialMediaNotificationSystem.Interfaces;

namespace SocialMediaNotificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CommentNotification commentNotification = new CommentNotification();
            FollowNotification followNotification = new FollowNotification();
            LikeNotification likeNotification = new LikeNotification();

            commentNotification.SendNotification();
            followNotification.SendNotification();
            likeNotification.SendNotification();


            NotificationHandler handler = new NotificationHandler();
            handler.OnCommentNotificationReceived();
            handler.OnFollowNotificationReceived();
            handler.OnLikeNotificationReceived();

            Console.ReadLine(); // Keep console open
        }
    }

    // Basic class implementing interfaces
    class NotificationHandler : IComment, IFollowNotification, ILikeNotification
    {
        public void OnCommentNotificationReceived()
        {
            Console.WriteLine("Comment Notification Received");
        }

        public void OnFollowNotificationReceived()
        {
            Console.WriteLine("Follow Notification Received");
        }

        public void OnLikeNotificationReceived()
        {
            Console.WriteLine("Like Notification Received");
        }
    }
}
