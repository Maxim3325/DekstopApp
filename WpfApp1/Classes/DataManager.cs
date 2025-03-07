using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.Classes
{
    public class DataManager
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Query> Queries { get; set; } = new List<Query>();
        public DataManager()
        {
            LoadChange();
        }
        public void SaveChange()
        {
            string result = "";
            foreach (var user in Users)
            {
                result += $"{user.Id};{user.Name};{user.Login};{user.Password};{user.Role}\n";
            }
            File.WriteAllText("user.csv", result);

            result = "";
            foreach (var query in Queries)
            {
                result += $"{query.ManagerName};{query.ChangeType};{query.EmployeeName}\n";
            }
            File.WriteAllText("query.csv", result);
        }

        private void LoadChange()
        {
            var users = File.ReadAllLines("user.csv");
            foreach (var user in users)
            {
                if (string.IsNullOrEmpty(user))
                {
                    continue;
                }
                var userData = user.Split(',');
                var userClass = new User()
                {
                    Id = int.Parse(userData[0]),
                    Name = userData[1],
                    Login = userData[2],
                    Password = userData[3],
                    Role = userData[4],
                };
                Users.Add(userClass);
            }

            var queries = File.ReadAllLines("query.csv");
            foreach (var query in queries)
            {
                if (string.IsNullOrEmpty(query))
                {
                    continue;
                }
                var queryData = query.Split(',');
                var queryClass = new Query()
                {
                    ManagerName = queryData[0],
                    ChangeType = queryData[1],
                    EmployeeName = queryData[2]
                };
                Queries.Add(queryClass);
            }
            
        }
    }
}
