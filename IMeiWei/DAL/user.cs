using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace IMeiWei.DAL
{
    /// <summary>
    /// 数据访问类:user
    /// </summary>
    public partial class user
    {
        public user()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from user");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(IMeiWei.Model.user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into user(");
            strSql.Append("UserName,Password,UserStatusId,SecurityCode,IsActive,PhoneNumber)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@Password,@UserStatusId,@SecurityCode,@IsActive,@PhoneNumber)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserName", MySqlDbType.VarChar,255),
					new MySqlParameter("@Password", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserStatusId", MySqlDbType.Int32,11),
					new MySqlParameter("@SecurityCode", MySqlDbType.VarChar,255),
					new MySqlParameter("@IsActive", MySqlDbType.Bit),
					new MySqlParameter("@PhoneNumber", MySqlDbType.VarChar,11)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.UserStatusId;
            parameters[3].Value = model.SecurityCode;
            parameters[4].Value = model.IsActive;
            parameters[5].Value = model.PhoneNumber;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(IMeiWei.Model.user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update user set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Password=@Password,");
            strSql.Append("UserStatusId=@UserStatusId,");
            strSql.Append("SecurityCode=@SecurityCode,");
            strSql.Append("IsActive=@IsActive,");
            strSql.Append("PhoneNumber=@PhoneNumber");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserName", MySqlDbType.VarChar,255),
					new MySqlParameter("@Password", MySqlDbType.VarChar,255),
					new MySqlParameter("@UserStatusId", MySqlDbType.Int32,11),
					new MySqlParameter("@SecurityCode", MySqlDbType.VarChar,255),
					new MySqlParameter("@IsActive", MySqlDbType.Bit),
					new MySqlParameter("@PhoneNumber", MySqlDbType.VarChar,11),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.UserStatusId;
            parameters[3].Value = model.SecurityCode;
            parameters[4].Value = model.IsActive;
            parameters[5].Value = model.PhoneNumber;
            parameters[6].Value = model.Id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from user ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
            parameters[0].Value = Id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from user ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public IMeiWei.Model.user GetModel(long Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,UserName,Password,UserStatusId,SecurityCode,IsActive,PhoneNumber from user ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
            parameters[0].Value = Id;

            IMeiWei.Model.user model = new IMeiWei.Model.user();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public IMeiWei.Model.user DataRowToModel(DataRow row)
        {
            IMeiWei.Model.user model = new IMeiWei.Model.user();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = long.Parse(row["Id"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["UserStatusId"] != null && row["UserStatusId"].ToString() != "")
                {
                    model.UserStatusId = int.Parse(row["UserStatusId"].ToString());
                }
                if (row["SecurityCode"] != null)
                {
                    model.SecurityCode = row["SecurityCode"].ToString();
                }
                if (row["IsActive"] != null && row["IsActive"].ToString() != "")
                {
                    if ((row["IsActive"].ToString() == "1") || (row["IsActive"].ToString().ToLower() == "true"))
                    {
                        model.IsActive = true;
                    }
                    else
                    {
                        model.IsActive = false;
                    }
                }
                if (row["PhoneNumber"] != null)
                {
                    model.PhoneNumber = row["PhoneNumber"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,UserName,Password,UserStatusId,SecurityCode,IsActive,PhoneNumber ");
            strSql.Append(" FROM user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from user T ");
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
            parameters[0].Value = "user";
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

