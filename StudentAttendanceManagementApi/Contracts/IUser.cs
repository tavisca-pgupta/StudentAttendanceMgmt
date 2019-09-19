using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IUser
    {
        bool Login(int userID, string password);
        bool ChangePassword(int userID, string oldPassword, string newPassword);
    }
}
