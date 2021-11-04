using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace slivraria.model
{
    public interface IAcessoDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
