using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace laba_2.Models
{
    [DisplayName("Информация о заказе")]
    public class dataset
    {
        public string? id { get; set; }

        [DisplayName("ФИО")]
        public string? name { get; set; }

        [DisplayName("Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data { get; set; }

        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public uint number { get; set; }

        [DisplayName("Текущее место")]
        [DataType(DataType.MultilineText)]
        public string? adress_sender { get; set; }

        [DisplayName("Место выдачи")]
        [DataType(DataType.MultilineText)]
        public string? adress_recipient { get; set; }

        [DisplayName("Вес посылки")]
        public string? weight { get; set; }
        
        [DisplayName("Способ доставки")]
        public bool delivery_method { get; set; }

    }

    public enum delivery_method
    {
        regular,
        expedited,
        by_courier

    }
}
