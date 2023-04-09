using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class User
    {
        public int User_id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string DateOfBirthDay { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public float Phone { get; set; }
        public string Adress { get; set; }
        public float Role_id { get; set; }
        public string Email { get; set; }
        public int SeriaPas { get; set; }
        public int NumPas { get; set; }
        public string Vidan { get; set; }
        public string DataVidachi { get; set; }
        public User(int user_Id, string firsName, string lastName, string patronymic, string dateOfBirthDay, string login, string password, float phone, string adress, float role_Id, string email, int seriaPas, int numPas, string vidan, string dataViadachi)
        {
            User_id = user_Id;
            FirsName = firsName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirthDay = dateOfBirthDay;
            Login = login;
            Password = password;
            Phone = phone;
            Adress = adress;
            Role_id = role_Id;
            Email = email;
            SeriaPas = seriaPas;
            NumPas = numPas;
            Vidan = vidan;
            DataVidachi = dataViadachi;
        }

        public User()
        {
        }
    }
}
