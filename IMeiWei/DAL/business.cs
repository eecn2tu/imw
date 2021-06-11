using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace IMeiWei.DAL
{
    /// <summary>
    /// 数据访问类:business
    /// </summary>
    public partial class business
    {
        public business()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from business");
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
        public bool Add(IMeiWei.Model.business model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into business(");
            strSql.Append("BusinessId,BusinessName,BusinessPhone,BusinessHours,PerCapitaConsumption,RestaurantHighlights,FirstOffer,VIPOffer,BusinessTypeId,IsServerPark,IsServerAllelic,BusinessAddress)");
            strSql.Append(" values (");
            strSql.Append("@BusinessId,@BusinessName,@BusinessPhone,@BusinessHours,@PerCapitaConsumption,@RestaurantHighlights,@FirstOffer,@VIPOffer,@BusinessTypeId,@IsServerPark,@IsServerAllelic,@BusinessAddress)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BusinessId", MySqlDbType.VarChar,36),
					new MySqlParameter("@BusinessName", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessPhone", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessHours", MySqlDbType.VarChar,100),
					new MySqlParameter("@PerCapitaConsumption", MySqlDbType.Int32,11),
					new MySqlParameter("@RestaurantHighlights", MySqlDbType.VarChar,1000),
					new MySqlParameter("@FirstOffer", MySqlDbType.VarChar,1000),
					new MySqlParameter("@VIPOffer", MySqlDbType.VarChar,1000),
					new MySqlParameter("@BusinessTypeId", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsServerPark", MySqlDbType.Bit),
					new MySqlParameter("@IsServerAllelic", MySqlDbType.Bit),
					new MySqlParameter("@BusinessAddress", MySqlDbType.VarChar,1000)};
            parameters[0].Value = model.BusinessId;
            parameters[1].Value = model.BusinessName;
            parameters[2].Value = model.BusinessPhone;
            parameters[3].Value = model.BusinessHours;
            parameters[4].Value = model.PerCapitaConsumption;
            parameters[5].Value = model.RestaurantHighlights;
            parameters[6].Value = model.FirstOffer;
            parameters[7].Value = model.VIPOffer;
            parameters[8].Value = model.BusinessTypeId;
            parameters[9].Value = model.IsServerPark;
            parameters[10].Value = model.IsServerAllelic;
            parameters[11].Value = model.BusinessAddress;

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
        public bool Update(IMeiWei.Model.business model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update business set ");
            strSql.Append("BusinessId=@BusinessId,");
            strSql.Append("BusinessName=@BusinessName,");
            strSql.Append("BusinessPhone=@BusinessPhone,");
            strSql.Append("BusinessHours=@BusinessHours,");
            strSql.Append("PerCapitaConsumption=@PerCapitaConsumption,");
            strSql.Append("RestaurantHighlights=@RestaurantHighlights,");
            strSql.Append("FirstOffer=@FirstOffer,");
            strSql.Append("VIPOffer=@VIPOffer,");
            strSql.Append("BusinessTypeId=@BusinessTypeId,");
            strSql.Append("IsServerPark=@IsServerPark,");
            strSql.Append("IsServerAllelic=@IsServerAllelic,");
            strSql.Append("BusinessAddress=@BusinessAddress");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@BusinessId", MySqlDbType.VarChar,36),
					new MySqlParameter("@BusinessName", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessPhone", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessHours", MySqlDbType.VarChar,100),
					new MySqlParameter("@PerCapitaConsumption", MySqlDbType.Int32,11),
					new MySqlParameter("@RestaurantHighlights", MySqlDbType.VarChar,1000),
					new MySqlParameter("@FirstOffer", MySqlDbType.VarChar,1000),
					new MySqlParameter("@VIPOffer", MySqlDbType.VarChar,1000),
					new MySqlParameter("@BusinessTypeId", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsServerPark", MySqlDbType.Bit),
					new MySqlParameter("@IsServerAllelic", MySqlDbType.Bit),
					new MySqlParameter("@BusinessAddress", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.BusinessId;
            parameters[1].Value = model.BusinessName;
            parameters[2].Value = model.BusinessPhone;
            parameters[3].Value = model.BusinessHours;
            parameters[4].Value = model.PerCapitaConsumption;
            parameters[5].Value = model.RestaurantHighlights;
            parameters[6].Value = model.FirstOffer;
            parameters[7].Value = model.VIPOffer;
            parameters[8].Value = model.BusinessTypeId;
            parameters[9].Value = model.IsServerPark;
            parameters[10].Value = model.IsServerAllelic;
            parameters[11].Value = model.BusinessAddress;
            parameters[12].Value = model.Id;

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
            strSql.Append("delete from business ");
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
            strSql.Append("delete from business ");
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
        public IMeiWei.Model.business GetModel(long Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,BusinessId,BusinessName,BusinessPhone,BusinessHours,PerCapitaConsumption,RestaurantHighlights,FirstOffer,VIPOffer,BusinessTypeId,IsServerPark,IsServerAllelic,BusinessAddress from business ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
            parameters[0].Value = Id;

            IMeiWei.Model.business model = new IMeiWei.Model.business();
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
        public IMeiWei.Model.business DataRowToModel(DataRow row)
        {
            IMeiWei.Model.business model = new IMeiWei.Model.business();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = long.Parse(row["Id"].ToString());
                }
                if (row["BusinessId"] != null)
                {
                    model.BusinessId = row["BusinessId"].ToString();
                }
                if (row["BusinessName"] != null)
                {
                    model.BusinessName = row["BusinessName"].ToString();
                }
                if (row["BusinessPhone"] != null)
                {
                    model.BusinessPhone = row["BusinessPhone"].ToString();
                }
                if (row["BusinessHours"] != null)
                {
                    model.BusinessHours = row["BusinessHours"].ToString();
                }
                if (row["PerCapitaConsumption"] != null && row["PerCapitaConsumption"].ToString() != "")
                {
                    model.PerCapitaConsumption = int.Parse(row["PerCapitaConsumption"].ToString());
                }
                if (row["RestaurantHighlights"] != null)
                {
                    model.RestaurantHighlights = row["RestaurantHighlights"].ToString();
                }
                if (row["FirstOffer"] != null)
                {
                    model.FirstOffer = row["FirstOffer"].ToString();
                }
                if (row["VIPOffer"] != null)
                {
                    model.VIPOffer = row["VIPOffer"].ToString();
                }
                if (row["BusinessTypeId"] != null)
                {
                    model.BusinessTypeId = row["BusinessTypeId"].ToString();
                }
                if (row["IsServerPark"] != null && row["IsServerPark"].ToString() != "")
                {
                    if ((row["IsServerPark"].ToString() == "1") || (row["IsServerPark"].ToString().ToLower() == "true"))
                    {
                        model.IsServerPark = true;
                    }
                    else
                    {
                        model.IsServerPark = false;
                    }
                }
                if (row["IsServerAllelic"] != null && row["IsServerAllelic"].ToString() != "")
                {
                    if ((row["IsServerAllelic"].ToString() == "1") || (row["IsServerAllelic"].ToString().ToLower() == "true"))
                    {
                        model.IsServerAllelic = true;
                    }
                    else
                    {
                        model.IsServerAllelic = false;
                    }
                }
                if (row["BusinessAddress"] != null)
                {
                    model.BusinessAddress = row["BusinessAddress"].ToString();
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
            strSql.Append("select Id,BusinessId,BusinessName,BusinessPhone,BusinessHours,PerCapitaConsumption,RestaurantHighlights,FirstOffer,VIPOffer,BusinessTypeId,IsServerPark,IsServerAllelic,BusinessAddress ");
            strSql.Append(" FROM business ");
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
            strSql.Append("select count(1) FROM business ");
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
            strSql.Append(")AS Row, T.*  from business T ");
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
            parameters[0].Value = "business";
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

