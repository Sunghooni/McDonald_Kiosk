﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace McDonald_Kiosk
{
    class Table
    {
        public int left_time = 60;
        public bool isEnabled = true;
        public DispatcherTimer timer;
    }
}
