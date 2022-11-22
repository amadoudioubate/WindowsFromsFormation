namespace MultiWindows.Model
{
    public enum Profile
    {
        ADMIN, MANAGER, STAGIAIRE, RH
    }
    public class Utilisateur
    {
        
        private Profile _profile;
      
        public string Login { get; set; }

        public string Password { get; set; }


        public Profile Profile
        {
            get { return _profile; }
            set {
                if(Enum.IsDefined(typeof(Profile), value))
                {
                    _profile = value;
                }
                else
                {
                    throw new ArgumentException("Format de profil invalide", "Profil");
                }
            }
        }

        public string? Photo { get; set; } // Photo optionnelle

        public Utilisateur()
        {

        }
        public Utilisateur(string login, string password, string photo, Profile profile)
        {
            Login = login;
            Password = password;
            Photo = photo;
            Profile = profile;
        }

        public override string ToString()
        {
            return "Login: " + Login + " Profile: " + Profile;
        }
    }
}
