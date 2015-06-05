using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace StarTeam.Server
{
    public static class InitMongo
    {
        private const string ConnectionString = "mongodb://localhost:27020/mydb";
        private static readonly MongoClient client = new MongoClient(ConnectionString);
        private static readonly MongoServer server = client.GetServer();
        private static MongoDatabase database;
        static InitMongo()
        {
            
        }
        
        public static MongoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = server.GetDatabase("mydb");  
                }
                return database;
            }
            set
            {
                database = server.GetDatabase("mydb");  
            }
        }
    }
}