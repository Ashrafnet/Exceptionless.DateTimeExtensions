﻿using System;

namespace Exceptionless.DateTimeExtensions.FormatParsers {
    public interface IFormatParser {
        DateTimeRange Parse(string content, DateTime now);
    }
}
