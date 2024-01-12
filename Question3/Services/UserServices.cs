using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Newtonsoft.Json;
using Question3.Models;

namespace Question3.Services
{
    public class UserServices: IUserServices
    {
        private const string _baseUrl = "https://jsonplaceholder.typicode.com/posts";
        private readonly HttpClient _httpClient;

        public UserServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetUserAsync(int? id)
        {
            var user = await _httpClient.GetAsync($"{_baseUrl}/post");
            if (user.IsSuccessStatusCode)
            {
                var userContent = await user.Content.ReadAsStringAsync();
                var getUser = JsonConvert.DeserializeObject<User>(userContent);
                return getUser;
          
            }
            else
            {
                return null;
            }
        }
        public async Task<User> AddUserAsync(PostRecord postRecord)
        {
            var userJson = JsonConvert.SerializeObject(postRecord);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var user = await _httpClient.PostAsync($"{_baseUrl}/posts");
            if (user.IsSuccessStatusCode)
            {
                var userContent = await user.Content.ReadAsStringAsync();
                var getUser = JsonConvert.DeserializeObject<User>(userContent);
                return getUser;

            }
            else
            {
                return null;
            }
        }
        public async Task<User> UpdateUserAsync(PostRecord postRecord)
        {
            var userJson = JsonConvert.SerializeObject(postRecord);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var user = await _httpClient.PutAsync($"{_baseUrl}/posts");
            if (user.IsSuccessStatusCode)
            {
                var userContent = await user.Content.ReadAsStringAsync();
                var getUser = JsonConvert.DeserializeObject<User>(userContent);
                return getUser;

            }
            else
            {
                return null;
            }
        }
        public async Task<User> DeleteUserAsync(PostRecord postRecord)
        {
            var userJson = JsonConvert.SerializeObject(postRecord);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var user = await _httpClient.DeleteAsync($"{_baseUrl}/posts");
            if (user.IsSuccessStatusCode)
            {
                var userContent = await user.Content.ReadAsStringAsync();
                var getUser = JsonConvert.DeserializeObject<User>(userContent);
                return getUser;

            }
            else
            {
                return null;
            }
        }

    }
}
