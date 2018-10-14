using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestWork_Baltbet.Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IBaltbetService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IBaltbetService
    {
        [OperationContract]
        bool AddUser(string Gender, int Age, string Login, string Name, string LastName, string Passport, string Password);

        [OperationContract]
        bool CheckUserLogin(string Login);

        [OperationContract]
        bool CheckUser(string Login, string Password);

        [OperationContract]
        List<Account> GetListAccounts();
    }
}
