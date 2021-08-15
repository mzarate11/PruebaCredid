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

        public List<Users.clsUser> DeserializarU(List<Users.clsUser> users)
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            string respuesta = GetJsonFromWeb(url);
            var DataU = JsonConvert.DeserializeObject<List<Users.clsUser>>(respuesta);
            return DataU;
        }

        #endregion



        #region Posts



        public List<Posts.clsPost> DeserializarP(List<Posts.clsPost> posts)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            string respuesta = GetJsonFromWeb(url);

            var DataP = JsonConvert.DeserializeObject<List<Posts.clsPost>>(respuesta);
            return DataP;
        }
        #endregion



        #region Comments


        public List<Comments.clsComment> DeserializarC(List<Comments.clsComment> comments)
        {
            string url = "https://jsonplaceholder.typicode.com/comments";

            string respuesta = GetJsonFromWeb(url);
            return JsonConvert.DeserializeObject<List<Comments.clsComment>>(respuesta);
        }
        #endregion


    }

}


