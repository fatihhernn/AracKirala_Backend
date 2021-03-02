using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddedCar = "Araba başarılı bir şekilde eklendi";
        public static string DeletedCar = "Araba başarılı bir şekilde silindi";
        public static string CarsListed = "Arabalar listelendi";
        public static string ListedCarDetails = "Araba detayları listelendi";
        public static string CarUpdated = "Araba başarılı bir şekilde güncellendi";

        public static string AddedBrand = "Marka başarılı bir şekilde eklendi";
        public static string DeletedBrand = "Marka başarılı bir şekilde silindi";
        public static string BrandUpdated = "Marka başarılı bir şekilde güncelledi";
        public static string BrandsListed = "Markalar başarılı bir şekilde listelendi";
        public static string BrandListed = "Marka başarılı bir şekilde listelendi";


        public static string AddedColor = "Renk başarılı bir şekilde eklendi";
        public static string DeletedColor = "Renk başarılı bir şekilde silindi";
        public static string ColorUpdated = "Renk başarılı bir şekilde güncelledi";
        public static string ColorsListed = "Renkler başarılı bir şekilde listelendi";
        public static string ColorListed = "Renk başarılı bir şekilde listelendi";

        public static string AddedCustomer = "Müşteri başarılı bir şekilde eklendi";
       

        public static string DeletedCustomer = "Müşteri başarılı bir şekilde silindi";
        public static string CustomersListed = "Müşteriler başarılı bir şekilde listelendi";
        public static string CustomerListed = "Müşteri başarılı bir şekilde listelendi";
        public static string UpdatedCustomer = "Müşter başarılı bir şekilde güncellendi";

        public static string RentedCar = "Araba başarılı bir şekilde kiralandı";
        public static string NotRentedCar = "Araba kiralanamadı";

        public static string DeletedUser = "Kullanıcı Silindi";
        public static string UpdatedUser = "Kullanıcı güncellendi";
        public static string AddedUser = "Kullanıcı eklendi";

        public static string RentalTimeError = "Kiralayacağınız araba kiralanmış";

        public static string AddedCarImage = "Fotoğraf eklendi";
        public static string DeletedCarImage = "Fotoğraf silindi";
       
        public static string UploadCarImage = "Fotoğraf yüklendi";

        public static string CarImageLimitExceeded = "Eklenebilecek resim sayısı aşılmaktadır";

        public static string CarListedByCarId { get; internal set; }
        public static string AllCarImagesListed { get; internal set; }
        public static string CarImageListedById { get; internal set; }
        public static string CarImageDeleted { get; internal set; }
        public static string CarImagesAdded { get; internal set; }
    }
}
