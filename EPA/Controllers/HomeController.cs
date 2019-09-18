﻿using EPA.Models.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPA.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string County)
        {
            var client = new RestClient("http://opendata2.epa.gov.tw/AQI.json");
            var request = new RestRequest(Method.GET);
            //request.AddParameter("skip", "0", ParameterType.RequestBody);
            //request.AddParameter("top", "1000", ParameterType.RequestBody);
            //request.AddParameter("format", "json", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var AQI = JsonConvert.DeserializeObject<IEnumerable<AQIViewModel>>(response.Content);

            //SelectListItem
            var county = AQI
                .GroupBy(o => new { countyName = o.County })
                .Select(c => c.Key.countyName).ToList();

            var countyOptions = new List<SelectListItem>();
            countyOptions.AddRange(county.ConvertAll(o => {
                return new SelectListItem()
                {
                    Text = o.ToString(),
                    Value = o.ToString(),
                };
            }));

            ViewBag.countyOptions = countyOptions;

            //data
            if (County != null)
                AQI = AQI.Where(o => o.County == County);
            else
                AQI = AQI.Where(o => o.County == "基隆市");

            return View(AQI);

        }
 
        /// <summary>
        /// 取得單一監測站資料
        /// </summary>
        /// <param name="Site"></param>
        /// <returns></returns>
        public JsonResult GetSite(string SiteId)
        {
            AQIViewModel site = new AQIViewModel();

            var client = new RestClient("http://opendata2.epa.gov.tw/AQI.json");
            var request = new RestRequest(Method.GET);
            //request.AddParameter("skip", "0", ParameterType.RequestBody);
            //request.AddParameter("top", "1000", ParameterType.RequestBody);
            //request.AddParameter("format", "json", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            var AQI = JsonConvert.DeserializeObject<IEnumerable<AQIViewModel>>(response.Content);

            if (SiteId != null)
                site = AQI.Where(o => o.SiteId == SiteId).FirstOrDefault();

            return Json(site, JsonRequestBehavior.AllowGet);
        }

    }
}