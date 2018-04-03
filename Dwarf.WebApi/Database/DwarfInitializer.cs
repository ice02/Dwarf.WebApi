using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarf.Database
{
    public class DwarfInitializer
    {
        private static bool _initialized = false;
        private static object _lock = new object();

        internal static void Initialize(DwarfContext context)
        {
            if (!_initialized)
            {
                lock (_lock)
                {
                    if (_initialized)
                        return;

                    InitializeData(context);
                }
            }
        }

        private static void InitializeData(DwarfContext context)
        {
            context.Database.Migrate();
            Seed(context);
        }

        private static void Seed(DwarfContext context)
        {
            
        }
    }
}
