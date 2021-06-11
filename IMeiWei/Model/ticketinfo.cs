using System;
namespace IMeiWei.Model
{
	/// <summary>
	/// ticketinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ticketinfo
	{
		public ticketinfo()
		{}
		#region Model
		private long _id;
		private long _ticketid;
		private string _code;
		private DateTime _usetime;
		private string _status;
		private long _mappinguserid;
		private string _mappinguserphone;
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long TicketId
		{
			set{ _ticketid=value;}
			get{return _ticketid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UseTime
		{
			set{ _usetime=value;}
			get{return _usetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long MappingUserId
		{
			set{ _mappinguserid=value;}
			get{return _mappinguserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MappingUserPhone
		{
			set{ _mappinguserphone=value;}
			get{return _mappinguserphone;}
		}
		#endregion Model

	}
}

