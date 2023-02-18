using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDescriptionInvalid = "Araba acıklaması geçersiz";
        public static string CarUpdated = "Araba bilgisi güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarListed = "Arabalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renler Listelendi";
        public static string ColorUpdated = "Renkler güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string CustomerAdded = "Müsteri eklendi";
        public static string CustomerDeleted = "Müsteri silindi";
        public static string CustomerUpdated = "Müsteri güncellendi";
        public static string CustomerListed = "Müsteriler Listelendi";
        public static string RentalAdded = "Araba kiralandı";
        public static string RentalDeleted = "Kiralanan araba uygun duruma geldi";
        public static string RentalUpdated = "Kiralanan araba bilgileri güncellendi";
        public static string RentalListed = "Kiralanan arabalar listelendi";
        public static string RentalInvalid = "Araba suan baska bir müsteride";
        public static string CarCountOfError = "Arabaya ait resim sayısı 5'i gecemez";
        public static string CarDailyPricetOfError ="Arabanın günlük fiyatı 700 den fazla olamaz";
        public static string AuthorizationDenied = "Yetkin yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin ="Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturldu";
        public static string PaymentAdded = "Kredi kart bilgisi kaydedildi";
        public static string PaymentDeleted= "Kredi kart bilgisi silindi";
        public static string PaymentUpdated= "Kredi kart bilgisi güncellendi";
        public static string MissingInformation="Eksik bilgi var";
        public static string RentalFailed="Araba kiralanamadı";
    }
}
