
using CA2MusicTobyZedomi.Components.Pages;

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
            if (!(obj is User))
            {
                return false;
            }
            var user = (User)obj;
            if (user.name.Equals(name) && user.email.Equals(email) && user.password.Equals(password))
            {

                return true;

            }
            return false;
        }


        public static bool operator ==(User left, User right)
        {
            return !left.Equals(right);
        }

        public static bool operator !=(User left, User right)
        {
            return !left.Equals(right);
        }


        public override int GetHashCode()
        {
            return (name, email, password).GetHashCode();
        }



        //toString
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Email)}={Email}, {nameof(Password)}={Password}}}";
        }
    }
}
