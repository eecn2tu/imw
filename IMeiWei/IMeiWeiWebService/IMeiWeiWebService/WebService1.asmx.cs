using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace IMeiWeiWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "{'result':'Hello World'}";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Registration(string phoneNumber, string password, string securityNumber, string userName)
        {
            IMeiWei.BLL.user bll_user = new IMeiWei.BLL.user();
            IMeiWei.Model.user model_user = new IMeiWei.Model.user();
            List<IMeiWei.Model.user> old_model_users = new List<IMeiWei.Model.user>();

            old_model_users = bll_user.GetModelList(" phoneNumber = '" + phoneNumber + "'");

            if (null != old_model_users && old_model_users.Count > 0)
            {
                return "DUPLICATE";
            }

            model_user.IsActive = false;
            model_user.Password = password;
            model_user.SecurityCode = securityNumber;
            model_user.UserName = userName;
            model_user.UserStatusId = 1;
            model_user.PhoneNumber = phoneNumber;

            bll_user.Add(model_user);

            return "SUCCESS";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Login(string phoneNumber, string password)
        {
            IMeiWei.BLL.user bll_user = new IMeiWei.BLL.user();
            IMeiWei.Model.user model_user = new IMeiWei.Model.user();

            model_user = bll_user.GetModelList(" phoneNumber = '" + phoneNumber + "'").FirstOrDefault();

            if (null != model_user)
            {
                if (model_user.Password != password)
                {
                    return "PASSWORD_ERROR";
                }
                else
                {
                    string tokenId = Guid.NewGuid().ToString();
                    Session.Add(tokenId, phoneNumber);
                    return tokenId;
                }
            }
            else
            {
                return "USERNAME_ERROR";
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string CreateBusiness(
            string businessId, string businessName, string businessAddress, string businessPhone,
            string businessHours, string percapitaConsumption, string restauranThighLights, string firstOffer,
            string vipOffer, string businessTypeid)
        {
            IMeiWei.BLL.business bll_business = new IMeiWei.BLL.business();
            IMeiWei.Model.business model_business = new IMeiWei.Model.business();

            model_business.BusinessId = businessId;
            model_business.BusinessName = businessName;
            model_business.BusinessAddress = businessAddress;
            model_business.BusinessPhone = businessPhone;
            model_business.BusinessTypeId = businessTypeid;
            model_business.BusinessHours = businessHours;
            model_business.FirstOffer = firstOffer;
            model_business.PerCapitaConsumption = Convert.ToInt32(percapitaConsumption);
            model_business.VIPOffer = vipOffer;
            model_business.RestaurantHighlights = restauranThighLights;

            bll_business.Add(model_business);

            return "SUCCESS";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string CreateImgs()
        {
            var request = HttpContext.Current.Request;
            var imageData = request["data"];


            return null;
        }

    }
}
