namespace TareaCuatro
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsBestFriend { get; set; }

        public Contact(int id, string firstName, string lastName, string address, string phone, string email, int age, bool isBestFriend)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Email = email;
            Age = age;
            IsBestFriend = isBestFriend;
        }
    }
}
