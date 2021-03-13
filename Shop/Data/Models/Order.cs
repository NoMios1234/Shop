using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int orderId { get; set; }
        [Display(Name = "Введите ФИО")]
        [StringLength(50)]
        [Required(ErrorMessage = "Длинна ФИО не более 30 символов")]
        public string orderName { get; set; }
        [Display(Name = "Введите Адрес")]
        [StringLength(70)]
        [Required(ErrorMessage = "Длинна адреса не более 50 символов")]
        public string orderAddress { get; set; }
        [Display(Name = "Введите Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13)]
        [Required(ErrorMessage = "Длинна номера менее 10 знаков")]
        public string orderPhone { get; set; }
        [Display(Name = "Введите email адрес")]
        [DataType(DataType.EmailAddress)]
        [StringLength(35)]
        [Required(ErrorMessage = "Длинна email не более 30 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
