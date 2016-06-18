using Handlebars.Rx.UI.Example.App.Dtos;
using System;
using System.Net.Http;

namespace Handlebars.Rx.UI.Example.App.Clients
{
    public class PageClient : IPageClient
    {
        public PageDto GetArticlePage(string slug)
        {
            var response = CreateHttpClient().GetAsync($"/api/page/getbyname?name=article&slug={slug}").Result;
            return response.Content.ReadAsAsync<PageDto>().Result;            
        }

        public PageDto GetArticlesPage()
        {
            var response = CreateHttpClient().GetAsync("/api/page/getbyname?name=articles").Result;
            return response.Content.ReadAsAsync<PageDto>().Result;
        }

        public PageDto GetGalleryPage(string slug)
        {
            var response = CreateHttpClient().GetAsync($"/api/page/getbyname?name=gallery&slug={slug}").Result;
            return response.Content.ReadAsAsync<PageDto>().Result;
        }

        public PageDto GetVideoPage(string slug)
        {
            var response = CreateHttpClient().GetAsync($"/api/page/getbyname?name=video&slug={slug}").Result;
            return response.Content.ReadAsAsync<PageDto>().Result;
        }

        protected virtual HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:56622/");
            return httpClient;
        }
    }
}