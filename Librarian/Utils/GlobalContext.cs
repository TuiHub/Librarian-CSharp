﻿using Librarian.Models;

namespace Librarian.Utils
{
    public static class GlobalContext
    {
        public static SystemConfig SystemConfig { get; set; }
        public static JwtConfig JwtConfig { get; set; }
    }
}
