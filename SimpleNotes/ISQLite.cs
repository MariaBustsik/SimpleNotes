﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotes
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
