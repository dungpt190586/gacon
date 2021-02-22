using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Class2
    {
        ////#1 
        //var clientsManager = container.Resolve<IRedisClientsManager>();

        //private static RedisClient redisClient = RedisClientManager.GetClient();
        //public string GetValue(string key)
        //{
        //    var val = redisClient.Get<string>(key);
        //    return val;
        //}
        ////#2 
        //public string GetValue(string key, RedisClient redisClient)
        //{
        //    var val = redisClient.Get<string>(key);
        //    return val;
        //}
        ////#3 
        //public string GetValue(string key)
        //{
        //    using (var redisClient = RedisClientManager.GetClient())
        //    {
        //        var val = redisClient.Get<string>(key);
        //        return val;
        //    }
        //}
    }
}
