using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace IMeiWei.DAL
{
	/// <summary>
	/// 数据访问类:ticket
	/// </summary>
	public partial class ticket
	{
		public ticket()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ticket");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IMeiWei.Model.ticket model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ticket(");
			strSql.Append("Id,TicketNumber,TicketAmount,LimitTime,CreateTime,CreateBy)");
			strSql.Append(" values (");
			strSql.Append("@Id,@TicketNumber,@TicketAmount,@LimitTime,@CreateTime,@CreateBy)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20),
					new MySqlParameter("@TicketNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@TicketAmount", MySqlDbType.Int32,11),
					new MySqlParameter("@LimitTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.TicketNumber;
			parameters[2].Value = model.TicketAmount;
			parameters[3].Value = model.LimitTime;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.CreateBy;

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
		public bool Update(IMeiWei.Model.ticket model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ticket set ");
			strSql.Append("TicketNumber=@TicketNumber,");
			strSql.Append("TicketAmount=@TicketAmount,");
			strSql.Append("LimitTime=@LimitTime,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateBy=@CreateBy");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TicketNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@TicketAmount", MySqlDbType.Int32,11),
					new MySqlParameter("@LimitTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.VarChar,255),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.TicketNumber;
			parameters[1].Value = model.TicketAmount;
			parameters[2].Value = model.LimitTime;
			parameters[3].Value = model.CreateTime;
			parameters[4].Value = model.CreateBy;
			parameters[5].Value = model.Id;

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
			strSql.Append("delete from ticket ");
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
			strSql.Append("delete from ticket ");
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
		public IMeiWei.Model.ticket GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TicketNumber,TicketAmount,LimitTime,CreateTime,CreateBy from ticket ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64,20)			};
			parameters[0].Value = Id;

			IMeiWei.Model.ticket model=new IMeiWei.Model.ticket();
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
		public IMeiWei.Model.ticket DataRowToModel(DataRow row)
		{
			IMeiWei.Model.ticket model=new IMeiWei.Model.ticket();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if(row["TicketNumber"]!=null && row["TicketNumber"].ToString()!="")
				{
					model.TicketNumber=int.Parse(row["TicketNumber"].ToString());
				}
				if(row["TicketAmount"]!=null && row["TicketAmount"].ToString()!="")
				{
					model.TicketAmount=int.Parse(row["TicketAmount"].ToString());
				}
				if(row["LimitTime"]!=null && row["LimitTime"].ToString()!="")
				{
					model.LimitTime=DateTime.Parse(row["LimitTime"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["CreateBy"]!=null)
				{
					model.CreateBy=row["CreateBy"].ToString();
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
			strSql.Append("select Id,TicketNumber,TicketAmount,LimitTime,CreateTime,CreateBy ");
			strSql.Append(" FROM ticket ");
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
			strSql.Append("select count(1) FROM ticket ");
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
			strSql.Append(")AS Row, T.*  from ticket T ");
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
			parameters[0].Value = "ticket";
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

