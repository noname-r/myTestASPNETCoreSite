﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myTestASPNETCoreSite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (Заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";


    }
}
