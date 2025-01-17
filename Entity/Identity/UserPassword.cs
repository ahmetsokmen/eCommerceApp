﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrnekSite.Entity.Identity
{
    public class UserPassword
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string OldPassword { get; set; }
        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(100,MinimumLength =5, ErrorMessage ="Şifreniz en az 5 karakter olmalı.")]
        public string NewPassword { get; set; }
        [Required]
        [DisplayName("Şifre Tekrarı")]
        [Compare("NewPassword",ErrorMessage ="Şifreler aynı değil")]
        public string ReNewPassword { get; set; }

    }
}