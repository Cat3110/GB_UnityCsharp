using System.IO;
using UnityEngine;

namespace GB_UnityCSharp.DataSaving
{
    public class JsonSaver<T>
    {
        public void Save(T position, string path = null)
        {
            var str = JsonUtility.ToJson(position);
            File.WriteAllText(path, str);
        }

        public T Load(string path = null)
        {
            var str = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(str);
        }
    }
}