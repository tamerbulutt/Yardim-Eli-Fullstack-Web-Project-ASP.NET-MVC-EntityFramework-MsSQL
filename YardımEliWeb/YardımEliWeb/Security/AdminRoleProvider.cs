using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using YardımEliWeb.Models.Entity;

namespace YardımEliWeb.Security
{
    public class AdminRoleProvider : RoleProvider
    {
        public override string ApplicationName 
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            //Database'imizi tanımladık.
            dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities();
            // Database'deki kullanıcı adıyla bizim kullanıcı adımızı denkleştirdik.
            var kullanıcı = db.tblKullanıcılar.FirstOrDefault(x => x.kullanıcıAdı==username);
            return new string[] { kullanıcı.kullanıcıRol };
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}