﻿using CinemaClix.Models;

namespace CinemaClix.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> GetUserById(int id);

        Task AddNewUser(User user);

        Task DeleteUser(int id);

        Task UpdateUser(User user);

        Task AddSubscriptionToUser(int userId, Subscriptions subscription);
        Task<User?> AuthLogin(User userInput);

        Task Logout();
    }
}