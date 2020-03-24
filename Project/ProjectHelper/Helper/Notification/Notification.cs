using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Newtonsoft.Json;

namespace Helper
{
   public static class Notification
    { 

        public static bool SendNotifToOneSignalServer(NotifModel notifModel,string fireBaseUrl,string fireBaseApikey)
        {
            var request = WebRequest.Create(fireBaseUrl) as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            var key = fireBaseApikey;
         
            request.Headers.Add("Authorization", key);
            var model = new NotifModel()
            {
                registration_ids = notifModel.registration_ids,
                notification = notifModel.notification,
                priority = 10
            };
            var strModel = JsonConvert.SerializeObject(model);
            byte[] byteArray = Encoding.UTF8.GetBytes(strModel);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
                return true;
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                return false;
            }

        }
    }
}
