using System;
namespace IMeiWei.Model
{
    /// <summary>
    /// user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class user
    {
        public user()
        { }
        #region Model
        private long _id;
        private string _username;
        private string _password;
        private int _userstatusid;
        private string _securitycode;
        private bool _isactive;
        private string _phonenumber;
        /// <summary>
        /// auto_increment
        /// </summary>
        public long Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserStatusId
        {
            set { _userstatusid = value; }
            get { return _userstatusid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SecurityCode
        {
            set { _securitycode = value; }
            get { return _securitycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsActive
        {
            set { _isactive = value; }
            get { return _isactive; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber
        {
            set { _phonenumber = value; }
            get { return _phonenumber; }
        }
        #endregion Model

    }
}

