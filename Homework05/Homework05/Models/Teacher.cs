namespace Homework05.Models
{
        public delegate void NotificationHandler(string message);

        public class Teacher
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string Subject { get; set; }
    
            public event NotificationHandler OnNotificationEvent;

           public void Subscribe(Student student)
        {
            OnNotificationEvent += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to proffesor {Name}'s notifications");
        }
        
        public void Unsubscribe(Student student)
        {
            OnNotificationEvent -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed to proffesor {Name}'s notifications");  
        }

        public void SendNotification()
        {
            Console.WriteLine("\n Sending notifications");
            OnNotificationEvent.Invoke($"Notification from proffesor {Name} : Class for {Subject} will start at 10 AM. \n");
        }
       }
    }

