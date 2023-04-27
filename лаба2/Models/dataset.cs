using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace лаба2.Models
{
    [DisplayName("новый заказ")]
    public class dataset
    {
        public string? id { get; set; }

        [DisplayName("Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data { get; set; }

        [DisplayName("ФИО заказчика")]
        public string? ownername { get; set; }

        [DisplayName("Номер телефона")]
        public string? phonenumber { get; set; }

        [DisplayName("Название услуги")]
        public string? servicename { get; set; }

        [DisplayName("Адрес")]
        public string? adress { get; set; }

        [DisplayName("Доп услуги")]
        public bool plusservice { get; set; }

        [DisplayName("Отзыв")]
        public int review { get; set; }

    }

    public enum plusservice
    {
        not_used,
        used

    }
    public enum servicename
    {
        cleaning,
        vacuum,
        laundry,
        ironing
    }

    public enum review
    {
        super,
        good,
        normal,
        bad,
        awful
    }
}
