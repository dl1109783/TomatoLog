﻿using System;

namespace TomatoLog.Common.Utilities
{
    public class FileDesc
    {
        public string FileName { get; set; }
        public DateTime ModifyTime { get; set; }
        public long Length { get; set; }
    }
}
