using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class User
    //Класс пользователя
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public bool Client { get; set; }

        public User(string name, string surname, string phone, bool client, int id = 0)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Client = client;
        }

        public User() : this(null, null, null, false) {}
    }
}
