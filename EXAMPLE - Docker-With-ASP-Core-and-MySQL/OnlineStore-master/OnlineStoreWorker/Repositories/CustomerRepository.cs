﻿using System;
using Dapper;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using OnlineStoreWorker.Models;
using OnlineStoreWorker.Settings;

namespace OnlineStoreWorker.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly IOptions<OnlineStoreDbSettings> _onlineStoreDbSettings;
        public CustomerRepository(IOptions<OnlineStoreDbSettings> onlineStoreDbSettings)
        {
            _onlineStoreDbSettings = onlineStoreDbSettings;
        }

        public void Insert(Customer customer)
        {
            var onlineStoreDbUserName = Environment.GetEnvironmentVariable("ONLINE_STORE_DB_USERNAME");
            var onlineStoreDbPassword = Environment.GetEnvironmentVariable("ONLINE_STORE_DB_PASSWORD");
            var onlineStoreDbServer = Environment.GetEnvironmentVariable("ONLINE_STORE_DB_SERVER");

            var connectionString = $"Server={onlineStoreDbServer};Database={_onlineStoreDbSettings.Value.Database};Uid={onlineStoreDbUserName};Pwd={onlineStoreDbPassword};SSL Mode = None;charset=utf8";

            MySqlConnection connection = new MySqlConnection(connectionString);


            var count = connection.Execute(@"insert into Customers (FirstName, LastName,EmailAddress,NotifyMe) values (@FirstName, @LastName,@EmailAddress,@NotifyMe)",
                                           customer);

        }
         
    }
}
