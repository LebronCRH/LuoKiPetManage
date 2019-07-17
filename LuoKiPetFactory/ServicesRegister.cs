using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using LuoKiPetIDAL;
using LuoKiPetDAL;
using LuoKiPetBLL;
using LuoKiPetIBLL;

namespace LuoKiPetFactory
{
    public static class ServicesRegister
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfigurationRoot config)
        {
            services.AddTransient(typeof(IUserInfoDal), typeof(UserInfoDal));
            services.AddTransient(typeof(IUserInfoService), typeof(UserInfoService));
            services.AddTransient(typeof(IManageMenuDal), typeof(ManageMenuDal));
            services.AddTransient(typeof(IManagerMenuChildDal), typeof(ManagerMenuChildDal));
            services.AddTransient(typeof(IManageMenuService), typeof(ManageMenuService));
            services.AddTransient(typeof(IManagerMenuChildService), typeof(ManagerMenuChildService));
            services.AddTransient(typeof(IPetCategoryService), typeof(PetCategoryService));
            services.AddTransient(typeof(IPetCategoryDal), typeof(PetCategoryDal));
            services.AddTransient(typeof(IAdministratorsDal), typeof(AdministratorsDal));
            services.AddTransient(typeof(IAdministratorsService), typeof(AdministratorsService));
            //宠物疾病相关的服务注入
            services.AddTransient(typeof(IPetPositionDal), typeof(PetPositionDal));
            services.AddTransient(typeof(IPetPositionService), typeof(PetPositionService));
            services.AddTransient(typeof(IPetPositionSymptomDal), typeof(PetPositionSymptomDal));
            services.AddTransient(typeof(IPetPositionSymptomService), typeof(PetPositionSymptomService));
            services.AddTransient(typeof(IPetDiseaseDal), typeof(PetDiseaseDal));
            services.AddTransient(typeof(IPetDiseaseService), typeof(PetDiseaseService));
            //文章管理服务的注入
            services.AddTransient(typeof(IPetInformationDal), typeof(PetInformationDal));
            services.AddTransient(typeof(IPetInformationService), typeof(PetInformationService));
            services.AddTransient(typeof(IClassArticleDal), typeof(ClassArticleDal));
            services.AddTransient(typeof(IClassArticleService), typeof(ClassArticleService));
            return services;
        }
    }
}
