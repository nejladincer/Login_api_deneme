using Rekabet_login.Domain.Entities;
using Rekabet_login.Domain.Models;
using Rekabet_login.Domain.Repositories;
using Rekabet_login.Domain.Services;
using Rekabet_login.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekabet_login.Services
{
    public class UserService
    {
        //private readonly IUserRepository userRepository;

        //private readonly IUnitOfWork<MongoDbContext> unitOfWork;

        //public UserService(IUserRepository userRepository, IUnitOfWork<MongoDbContext> unitOfWork)
        //{
        //    this.userRepository = userRepository;
        //    this.unitOfWork = unitOfWork;
        //}

        //public BaseResponse<User> AddUser(User user)
        //{
        //    try
        //    {
        //        userRepository.AddUser(user);
        //        unitOfWork.Complete();
        //        return new BaseResponse<User>(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<User>($"Kullanıcı eklenirken bir hata meydana geldi:{ex.Message}");
        //    }
        //}

        //public BaseResponse<User> FindById(int userId)
        //{
        //    try
        //    {
        //        User user = userRepository.FindById(userId);

        //        if (user == null)
        //        {
        //            return new BaseResponse<User>("Kullanıcı bulunamadı.");
        //        }

        //        return new BaseResponse<User>(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<User>($"Kullanıcı bulunurken bir hata meydana geldi:{ex.Message}");
        //    }
        //}

        //public BaseResponse<User> FindEmailAndPassword(string email, string password)
        //{
        //    try
        //    {
        //        User user = userRepository.FindByEmailandPassword(email, password);
        //        if (user == null)
        //        {
        //            return new BaseResponse<User>("Kullanıcı bulunamadı.");
        //        }
        //        else
        //        {
        //            return new BaseResponse<User>(user);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<User>($"Kullanıcı bulunurken bir hata meydana geldi:{ex.Message}");
        //    }
        //}

        //public BaseResponse<User> GetUserWithRefreshToken(string refreshToken)
        //{
        //    try
        //    {
        //        User user = userRepository.GetUserWithRefreshToken(refreshToken);

        //        if (user == null)
        //        {
        //            return new BaseResponse<User>("Kullanıcı bulunamadı.");
        //        }
        //        else
        //        {
        //            return new BaseResponse<User>(user);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<User>($"Kullanıcı bulunurken bir hata meydana geldi:{ex.Message}");
        //    }
        //}

        //public void RemoveRefreshToken(User user)
        //{
        //    try
        //    {
        //        userRepository.RemoveRefreshToken(user);
        //        unitOfWork.Complete();
        //    }
        //    catch (Exception)
        //    {
        //        //loglama yapılacaktır.
        //    }
        //}

        //public void SaveRefreshToken(int userId, string refreshToken)
        //{
        //    try
        //    {
        //        userRepository.SaveRefreshToken(userId, refreshToken);

        //        unitOfWork.Complete();
        //    }
        //    catch (Exception)
        //    {
        //        //loglama yapılacaktır..
        //    }
        //}
    }
}
