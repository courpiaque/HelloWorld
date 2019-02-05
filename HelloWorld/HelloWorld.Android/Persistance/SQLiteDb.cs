using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorld.Persistence;
using SQLite;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloWorld.Droid.Persistance;
using System.IO;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorld.Droid.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}