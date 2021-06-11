using System;
namespace IMeiWei.Model
{
    /// <summary>
    /// business:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class business
    {
        public business()
        { }
        #region Model
        private long _id;
        private string _businessid;
        private string _businessname;
        private string _businessphone;
        private string _businesshours;
        private int? _percapitaconsumption;
        private string _restauranthighlights;
        private string _firstoffer;
        private string _vipoffer;
        private string _businesstypeid;
        private bool _isserverpark;
        private bool _isserverallelic;
        private string _businessaddress;
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
        public string BusinessId
        {
            set { _businessid = value; }
            get { return _businessid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessName
        {
            set { _businessname = value; }
            get { return _businessname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessPhone
        {
            set { _businessphone = value; }
            get { return _businessphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessHours
        {
            set { _businesshours = value; }
            get { return _businesshours; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PerCapitaConsumption
        {
            set { _percapitaconsumption = value; }
            get { return _percapitaconsumption; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RestaurantHighlights
        {
            set { _restauranthighlights = value; }
            get { return _restauranthighlights; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FirstOffer
        {
            set { _firstoffer = value; }
            get { return _firstoffer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VIPOffer
        {
            set { _vipoffer = value; }
            get { return _vipoffer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessTypeId
        {
            set { _businesstypeid = value; }
            get { return _businesstypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsServerPark
        {
            set { _isserverpark = value; }
            get { return _isserverpark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsServerAllelic
        {
            set { _isserverallelic = value; }
            get { return _isserverallelic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessAddress
        {
            set { _businessaddress = value; }
            get { return _businessaddress; }
        }
        #endregion Model

    }
}

