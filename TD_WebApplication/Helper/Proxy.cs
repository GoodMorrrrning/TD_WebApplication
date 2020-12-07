using EpsiDTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TD_WebApplication.Helper
{
    public interface IProxy
    {
        
        Task<List<EtudiantDTO>> GetEtudiantDTOsAsync();
    }

    public class Proxy : IProxy
    {
        const string UrlApi = @"api/etudiants";
        private HttpClient _client = new HttpClient();
        private IHttpContextAccessor _context;
        
        public Proxy(IHttpContextAccessor ctx)
        {
            _context = ctx;
        }

        
        public async Task<List<EtudiantDTO>> GetEtudiantDTOsAsync()
        {
         
            return await GetListAsync<EtudiantDTO>(UrlApi);
        }
        private async Task<List<T>> GetListAsync<T>(string route)
        {
            var Urlbuilder = new UriBuilder(_context.HttpContext.Request.Scheme,
                                           _context.HttpContext.Request.Host.Host,
                                           _context.HttpContext.Request.Host.Port.GetValueOrDefault(80),
                                           UrlApi);

            

            var data = await _client.GetStringAsync(Urlbuilder.Uri);
            var ed = JsonSerializer.Deserialize<List<T>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return ed;
        }

    }
}
