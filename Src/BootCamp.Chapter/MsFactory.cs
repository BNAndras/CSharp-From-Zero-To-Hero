﻿using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public DesktopComputer Assemble()
        {
            return new DesktopComputer();
        }
    }
}