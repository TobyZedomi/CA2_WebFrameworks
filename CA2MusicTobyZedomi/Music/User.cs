
namespace CA2MusicTobyZedomi.Music
{
    public class User
    {

        private string name;
        private string email;
        private string password;

   

        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }



        public User()
        {
            this.Name = "Toby";
            this.Email = "toby@gmail.com";
            this.Password = "123";
        }


        // getters and setters

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }


        // equals and hash
        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   name == user.name &&
                   email == user.email &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, email, password);
        }

        //toString
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Email)}={Email}, {nameof(Password)}={Password}}}";
        }
    }
}
