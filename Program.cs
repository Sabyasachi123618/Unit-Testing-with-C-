// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelled(User user)
        {
            if(user.isadmin)
                return true;
            if (MadeBy == user)
                return true;
            return false;
        }
        //Just for testing time being
        public void none()
        {
            Console.WriteLine("can this be called by var");
        }
    }
    public class User
    {
        public bool isadmin { get; set; }
    }
    public class Maine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing to do much");
        }
    }
}
