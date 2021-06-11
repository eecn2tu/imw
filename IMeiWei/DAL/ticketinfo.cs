using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace IMeiWei.DAL
{
	/// <summary>
	/// 数据访问类:ticketinfo
	/// </summary>
	public partial class ticketinfo
	{
		public ticketinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ticketinfo");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMeiWei.Model.ticketinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ticketinfo(");
			strSql.Append("Id,TicketId,Code,UseTime,Status,MappingUserId,MappingUserPhone)");
			strSql.Append(" values (");
			strSql.Append("@Id,@TicketId,@Code,@UseTime,@Status,@MappingUserId,@MappingUserPhone)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20),
					new MySqlParameter("@TicketId", MySqlDbType.Int64,20),
					new MySqlParameter("@Code", MySqlDbType.VarChar,255),
					new MySqlParameter("@UseTime", MySqlDbType.DateTime),
					new MySqlParameter("@Status", MySqlDbType.VarChar,255),
					new MySqlParameter("@MappingUserId", MySqlDbType.Int64,20),
					new MySqlParameter("@MappingUserPhone", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.TicketId;
			parameters[2].Value = model.Code;
			parameters[3].Value = model.UseTime;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.MappingUserId;
			parameters[6].Value = model.MappingUserPhone;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IMeiWei.Model.ticketinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ticketinfo set ");
			strSql.Append("TicketId=@TicketId,");
			strSql.Append("Code=@Code,");
			strSql.Append("UseTime=@UseTime,");
			strSql.Append("Status=@Status,");
			strSql.Append("MappingUserId=@MappingUserId,");
			strSql.Append("MappingUserPhone=@MappingUserPhone");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TicketId", MySqlDbType.Int64,20),
					new MySqlParameter("@Code", MySqlDbType.VarChar,255),
					new MySqlParameter("@UseTime", MySqlDbType.DateTime),
					new MySqlParameter("@Status", MySqlDbType.VarChar,255),
					new MySqlParameter("@MappingUserId", MySqlDbType.Int64,20),
					new MySqlParameter("@MappingUserPhone", MySqlDbType.VarChar,255),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.TicketId;
			parameters[1].Value = model.Code;
			parameters[2].Value = model.UseTime;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.MappingUserId;
			parameters[5].Value = model.MappingUserPhone;
			parameters[6].Value = model.Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ticketinfo ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20)			};
			parameters[0].Value = Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ticketinfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMeiWei.Model.ticketinfo GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TicketId,Code,UseTime,Status,MappingUserId,MappingUserPhone from ticketinfo ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20)			};
			parameters[0].Value = Id;

			IMeiWei.Model.ticketinfo model=new IMeiWei.Model.ticketinfo();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IMeiWei.Model.ticketinfo DataRowToModel(DataRow row)
		{
			IMeiWei.Model.ticketinfo model=new IMeiWei.Model.ticketinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if(row["TicketId"]!=null && row["TicketId"].ToString()!="")
				{
					model.TicketId=long.Parse(row["TicketId"].ToString());
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["UseTime"]!=null && row["UseTime"].ToString()!="")
				{
					model.UseTime=DateTime.Parse(row["UseTime"].ToString());
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["MappingUserId"]!=null && row["MappingUserId"].ToString()!="")
				{
					model.MappingUserId=long.Parse(row["MappingUserId"].ToString());
				}
				if(row["MappingUserPhone"]!=null)
				{
					model.MappingUserPhone=row["MappingUserPhone"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TicketId,Code,UseTime,Status,MappingUserId,MappingUserPhone ");
			strSql.Append(" FROM ticketinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ticketinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from ticketinfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "ticketinfo";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

