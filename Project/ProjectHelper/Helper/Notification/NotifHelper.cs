using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;

namespace Helper
{ 

    public class PlayerIdViewModel
    {
        public string Token { get; set; }
        public string PlayerId { get; set; }
    }
    public class OneSignalServer_MessageModel
    {

        public string OnSignalGuid { get; set; }
        public string MessageText { get; set; }
        public int InboxId { get; set; }
        public int AppId { get; set; }
        public string PlayerIds { get; set; }
        public string Desc { get; set; }

    }

    public class NotifModel
    {
        public string[] registration_ids { get; set; }
        public NotifBody notification { get; set; }
        public int priority { get; set; } 
    }

    public class NotifBody
    {
        public string body { get; set; }
    }
}