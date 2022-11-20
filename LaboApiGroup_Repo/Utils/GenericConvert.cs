using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Utils
{
    public static class GenericConvert<T> where T : new()
    {
        public static  T Convert(IDataRecord dtr)
        {
            T t = new();

            foreach (var item in t.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)) 
            {
                if (item.FieldType.Equals(typeof(int)))
                {
                    string[] v = item.Name.Split('>');
                    //item.SetValue(t, (int)dtr[v[0].Substring(1)]);
                    item.SetValue(t, (int)dtr["Id_Role"]);
                }
                if (item.FieldType.Equals(typeof(string)))
                {
                    string[] v = item.Name.Split('>');
                    item.SetValue(t, dtr[v[0][1..]]);
                }

            }
            return t;
        }
    }
}
