﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Sample.Connector.Test
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    class FakeUploader : IUploader
    {
        public Dictionary<string, Item> fakeStorage = new Dictionary<string, Item>();

        public Task<string> UploadItem(string jobId, string taskId, Item item)
        {
            string itemId = "FakeAutoGeneratedId-" + item.Id;
            fakeStorage.Add(itemId, item);
            return Task.FromResult(itemId);
        }
    }
}
