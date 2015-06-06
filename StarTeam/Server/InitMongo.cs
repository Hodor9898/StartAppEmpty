using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace StarTeam.Server
{
    public class InitMongo
    {
        const string ConnectionString = "mongodb://localhost:27020/mydb";

        private static MongoDatabase database;
        static InitMongo()
        {
            
        }

        public static MongoDatabase Database
        {
            get
            {
                if (database != null) return database;
                var client = new MongoClient(ConnectionString);
                var server = client.GetServer();
                database = server.GetDatabase("mydb");
                return database;
            }
        }
    }
}