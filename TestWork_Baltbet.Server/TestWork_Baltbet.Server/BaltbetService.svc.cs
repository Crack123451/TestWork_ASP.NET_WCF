using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

namespace TestWork_Baltbet.Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "BaltbetService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы BaltbetService.svc или BaltbetService.svc.cs в обозревателе решений и начните отладку.
    public class BaltbetService : IBaltbetService
    {
        private Baltbet_AccountsEntities DataBase = new Baltbet_AccountsEntities();


        public bool AddUser(string gender, int age, string login, string name, string lastName, string passport, string password)
        {
            if (CheckUserLogin(login) == false)
            {
                var hashPassword = Hashing.HashPassword(password);
                DataBase.Accounts.Add(new Account
                {
                    Gender = gender,
                    Age = age,
                    Login = login,
                    Name = name,
                    LastName = lastName,
                    Passport = passport,
                    PasswordHash = hashPassword
                });
                DataBase.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckUserLogin(string login)
        {
            return DataBase.Accounts.Where(a => a.Login == login).Count() > 0;
        }

        public bool CheckUser(string login, string password)
        {
            var hashPassword = DataBase.Accounts.Where(a => a.Login == login).Select(a => a.PasswordHash);
            if (hashPassword.Count() > 0)
            {
                return Hashing.VerifyHashedPassword(hashPassword.First(), password);
            }
            //return DataBase.Accounts.Where(a => a.Login == login && a.Password == password).Count() > 0;
            return false;
        }

        public List<Account> GetListAccounts()
        {
            return DataBase.Accounts.ToList();
        }
    }
}
