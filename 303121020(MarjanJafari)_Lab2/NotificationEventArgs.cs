﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_WinForm
{
    public class NotificationEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
