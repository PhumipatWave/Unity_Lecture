using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Dynamics
{
    // Dynamics : Write code against a type that does not exist at compile time
    public class Dynamics : MonoBehaviour
    {
        private string json =
            " {" +
            "   \"assets\": [" +
            "       { \"type\": \"texture\", \"name\": \"player\", \"path\": \"textures/player.png\" }," +
            "       { \"type\": \"sound\", \"name\": \"background\", \"path\": \"sound/bg_music.mp3\" }," +
            "       { \"type\": \"model\", \"name\": \"enemy\", \"path\": \"models/enemy.obj\" }" +
            "   ]" +
            " }";

        // If know the json structure
        #region TestJson
        public class Rootobject
        {
            public Coord coord { get; set; }
            public Weather[] weather { get; set; }
            public string _base { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public int dt { get; set; }
            public Sys sys { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }

        public class Coord
        {
            public float lon { get; set; }
            public float lat { get; set; }
        }

        public class Main
        {
            public float temp { get; set; }
            public float pressure { get; set; }
            public int humidity { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public float sea_level { get; set; }
            public float grnd_level { get; set; }
        }

        public class Wind
        {
            public float speed { get; set; }
            public int deg { get; set; }
        }

        public class Clouds
        {
            public int all { get; set; }
        }

        public class Sys
        {
            public float message { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        #endregion


        private void Start()
        {
            // dynamic : don't know accually what type is it until runtime
            dynamic d = new object();
            //d.x = 123;
            //d.Test();

            // var : type is known at compile time
            var v = 56;

            dynamic jsonDynamic = JObject.Parse(json);
            Debug.Log(jsonDynamic.GetType().GetProperties());
            Debug.Log(jsonDynamic.assets[0].type);

            try
            {
                string typeName = jsonDynamic.assets[0].type;
            }
            catch (RuntimeBinderException)
            {

            }

            dynamic dTest = Test();
            Debug.Log(dTest.text);
        }

        private dynamic Test()
        {
            return new { text = "Hello Dynamics", health = 100 };
        }
    }
}