﻿using System;

namespace CERAAPI.ViewModels
{
    public class AddOrganizationViewModel
    {
        public string OrganizationName { get; set; }
        public string PrimaryAddress { get; set; }
        public string Description { get; set; }
        public string ContactPersonName { get; set; }
        public string EmailId { get; set; }
        public int PhoneNo { get; set; }
        public Guid UserId { get; set; }
    }
}
