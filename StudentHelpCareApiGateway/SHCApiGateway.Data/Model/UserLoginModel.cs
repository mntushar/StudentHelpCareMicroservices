﻿namespace StudentHelpCare.Identity.Data.Model
{
    public class UserLoginModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsRemember { get; set; } = false;
    }
}
