using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace BLL
{
    public class Logica
    {
        static void Main(string[] args)
        {


        }



        public string GetJsonFromWeb(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest();

            var response = client.Get(request);

            return response.Content.ToString();
        }



        #region Users

        #region Data Users
        public class Geo
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }

        public class Address
        {
            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public Geo geo { get; set; }
        }

        public class Company
        {
            public string name { get; set; }
            public string catchPhrase { get; set; }
            public string bs { get; set; }
        }

        public class Users
        {
            public int id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public Address address { get; set; }
            public string phone { get; set; }
            public string website { get; set; }
            public Company company { get; set; }
        }
        #endregion


        public List<Users> DeserializarU(List<Users> users)
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            string respuesta = GetJsonFromWeb(url);
            return JsonConvert.DeserializeObject<List<Users>>(respuesta);
        }

        #endregion



        #region Posts

        #region Data Posts
        public class Post
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }
        #endregion

        public List<Post> DeserializarP(List<Post> posts)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            string respuesta = GetJsonFromWeb(url);

            return JsonConvert.DeserializeObject<List<Post>>(respuesta);
        }
        #endregion



        #region Comments

        #region Data Comments
        public class Comment
        {
            public int postId { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string body { get; set; }
        }
        #endregion

        public List<Comment> DeserializarC(List<Comment> comments)
        {
            string url = "https://jsonplaceholder.typicode.com/comments";

            string respuesta = GetJsonFromWeb(url);
            return JsonConvert.DeserializeObject<List<Comment>>(respuesta);
        }
        #endregion


    }
}


