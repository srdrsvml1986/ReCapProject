using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied="Authorization Denied";
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string InvalidName = "öğre ismi geçersiz";

        public static string MaintenanceTime = "Bakım zamanı";

        public static string ItemsListed = "Öğeler Listelendi";
        public static string ItemGetted = "Öğeler alındı";
        public static string ItemUpdated = "Öğe güncellendi";
        public static string ImageMaxCount= "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
    }
}
