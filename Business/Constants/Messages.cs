using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Bu alana ulaşma yetkiniz yok.";

        public static string AddedSuccessfully = "Bilgiler veri tabanına başarı ile eklendi.";
        public static string UpdatedSuccessfully = "Bilgiler başarı ile güncellendi.";
        public static string DeletedSuccessfully = "Bilgiler veri tabanından başarı ile silindi";
        public static string ListedSuccessfully = "Bilgiler başarı ile listelendi.";

        public static string RentalOperationFailed = "Kiralama işlemi başarısız.";
        public static string RentalOperationSuccedd = "Kiralama işlemi başarı ile gerçekleştirildi.";

        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordIncorrect = "Şifre hatalı.";
        public static string SuccessfullLogin = "Giriş başarılı.";
        public static string UserExist = "Kullanıcı mevcut";
        public static string UserRegisteredSuccessfully = "Kullanıcı başarı ile kayıt edildi.";
    }
}
