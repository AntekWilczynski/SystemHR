﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHRUserInterface.Extensions
{
    public static class ExtensionsMethods
    {
        public static void DatePickerValueChanged(this DateTimePicker dtp)
        {

            dtp.Format = DateTimePickerFormat.Short;

        }
    }
}
