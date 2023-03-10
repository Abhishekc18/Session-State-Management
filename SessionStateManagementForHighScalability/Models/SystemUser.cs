using System;
using System.Collections.Generic;

namespace SessionStateManagementForHighScalability.Models
{
    public partial class SystemUser
    {
        public string Id { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Status { get; set; }
        public string? Role { get; set; }
    }
}
