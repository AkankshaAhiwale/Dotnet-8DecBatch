using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RollOffMvc.Helper;
using RollOffMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RollOffMvc.Controllers
{
    public class RollOffDataController : Controller
    {
        RollOffHelper rollOffHelper = new RollOffHelper();
        
        /*public IActionResult Index()
        {
            return View();
        }*/
        public async Task<IActionResult> GetAllDetails()
        {
            List<RollOffData> rollOffdata = new List<RollOffData>();
            HttpClient httpClient = rollOffHelper.Initial();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("/RollOff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                rollOffdata = JsonConvert.DeserializeObject<List<RollOffData>>(result);
            }
            return View(rollOffdata);
        }

        public async Task<IActionResult> GetDetailsByEmail(string email)
        {
            List<RollOffData> rollOffData = new List<RollOffData>();
            HttpClient httpClient = rollOffHelper.Initial();
            //httpClient.BaseAddress = new Uri("");
            HttpResponseMessage responseMessage = await httpClient.GetAsync("RollOff?email="+email);
            
            if(responseMessage.IsSuccessStatusCode)
            {
                var read = responseMessage.Content.ReadAsStringAsync().Result;
                      
            }
            return View();
        }
            
        }
    }

