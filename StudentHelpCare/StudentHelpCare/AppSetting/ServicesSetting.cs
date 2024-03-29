﻿using StudentHelpCare.StudentHelpCare.Services.IServices;
using StudentHelpCare.StudentHelpCare.Services.Services;

namespace StudentHelpCare.StudentHelpCare.AppSetting
{
    public static class ServicesSetting
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();

            return services;
        }
    }
}
