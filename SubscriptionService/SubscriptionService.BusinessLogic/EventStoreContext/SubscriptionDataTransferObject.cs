﻿using System;

namespace SubscriptionService.BusinessLogic.EventStoreContext
{
    public class SubscriptionDataTransferObject
    {
        public String SerialisedData { get; set; }
        public Guid EventId { get; set; }
        public String SubscriptionGroupId { get; set; }
    }
}