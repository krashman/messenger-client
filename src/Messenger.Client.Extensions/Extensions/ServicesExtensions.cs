﻿using System;
using Messenger.Client.Config;
using Messenger.Client.Services;
using Messenger.Client.Services.Impl;
using Messenger.Client.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.Client.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddMessengerClient(this IServiceCollection services, String accessToken = "")
        {
            if (!String.IsNullOrEmpty(accessToken))
            {
                MessengerConfig.AccessToken = accessToken;
            }

            services.AddSingleton<IMessengerSerializer, JsonMessengerSerializer>();
            services.AddSingleton<IMessengerMessageSender, MessengerMessageSender>();
        }
    }
}