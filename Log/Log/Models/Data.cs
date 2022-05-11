using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log.Models
{
    public class UserInfoModel
    {
        public List<UserInfo> UserInfo { get; set;}
        public UserInfoModel()
        {
          WebApiEntities db = new WebApiEntities();
          UserInfo = db.UserInfo.ToList();
        }
    }
}