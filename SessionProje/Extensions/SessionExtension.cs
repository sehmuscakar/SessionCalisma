using Newtonsoft.Json;
using NuGet.Packaging.Signing;

namespace SessionProje.Extensions
{
    public static class SessionExtension
    {
        public static void Set<T>(this ISession session, string key,T value)
        {
            //{"email":"safdadjh",password":"1235469"}
            session.SetString(key,JsonConvert.SerializeObject(value)); 
        }

        public static T? Get<T>(this ISession session, string key)
        {
           
          var value=session.GetString(key);
            return value== null ? default : JsonConvert.DeserializeObject<T>(value);
        }



    }
}
