namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //            return (user.IsAdmin || MadeBy == user);
            // there are 3 scenarios to test here
            // or 3 execution paths or 3 ways to exit this function
            //if (user.IsAdmin) // is user an admin
            //    return true;

            //if (MadeBy == user) // is same here
            //    return true;

            //return false; // is someone else trying to cancel

            // refactor 1
            //if (user.IsAdmin || MadeBy == user)
            //    return true;

            //return false;

            // refactor 2
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}