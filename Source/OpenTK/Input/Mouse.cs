﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public class Mouse : IMouse
    {
        #region --- IInputDevice Members ---

        public string Description
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Mouse; }
        }

        #endregion
    }
}
