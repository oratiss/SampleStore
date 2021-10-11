using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes.Enumerations
{
    public enum Province
    {
        [Display(Name="آذربایجان شرقی")]
        آذربایجانشرقی = 1,
        [Display(Name="آذربایجان غربی")]
        آذربایجانغربی = 2,
        اردبیل = 3,
        اصفهان = 4,
        البرز = 5,
        ایلام = 6,
        بوشهر = 7,
        تهران = 8,
        [Display(Name="چهارمحال و بختیاری")]
        چهارمحالوبختیاری = 9,
        [Display(Name="خراسان جنوبی")]
        خراسانجنوبی = 10,
        [Display(Name="خراسان رضوی")]
        خراسانرضوی = 11,
        [Display(Name="خراسان شمالی")]
        خراسانشمالی = 12,
        خوزستان = 13,
        زنجان = 14,
        سمنان = 15,
        [Display(Name="سیستان و بلوچستان")]
        سیستانوبلوچستان = 16,
        فارس = 17,
        قزوین = 18,
        قم = 19,
        کردستان = 20,
        کرمان = 21,
        کرمانشاه = 22,
        [Display(Name= "کهگیلویه و بویراحمد")]
        کهگیلویهوبویراحمد = 23,
        گلستان = 24,
        گیلان = 25,
        لرستان = 26,
        مازندران = 27,
        مرکزی = 28,
        هرمزگان = 29,
        همدان = 30,
        یزد = 31,

    }
}
