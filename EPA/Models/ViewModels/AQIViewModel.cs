using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPA.Models.ViewModels
{
    public class AQIViewModel
    {
        [Display(Name = "監測站名稱")]
        public string SiteName { get; set; }
        [Display(Name = "縣市")]
        public string County { get; set; }
        [Display(Name = "空氣品質指標")]
        public string AQI { get; set; }
        [Display(Name = "空氣汙染指標物")]
        public string Pollutant { get; set; }
        [Display(Name = "狀態")]
        public string Status { get; set; }
        [Display(Name = "二氧化硫 SO2(ppb)")]
        public string SO2 { get; set; }
        [Display(Name = "一氧化碳 CO(ppm)")]
        public string CO { get; set; }
        [Display(Name = "一氧化碳 8小時移動 CO(ppm)")]
        public string CO_8hr { get; set; }
        [Display(Name = "臭氧 O3(ppb)")]
        public string O3 { get; set; }
        [Display(Name = "臭氧 8小時移動 O3(ppb)")]
        public string O3_8hr { get; set; }
        [Display(Name = "懸浮微粒 PM10(μg / m3)")]
        public string PM10 { get; set; }
        [Display(Name = "細懸浮微粒 PM2.5(μg / m3)")]
        public string PM25 { get; set; }
        [Display(Name = "二氧化氮 NO2(ppb)")]
        public string NO2 { get; set; }
        [Display(Name = "氮氧化物 (ppb)")]
        public string NOx { get; set; }
        [Display(Name = "一氧化氮 NO(ppb)")]
        public string NO { get; set; }
        [Display(Name = "風速 (m / sec)")]
        public string WindSpeed { get; set; }
        [Display(Name = "風向 (degrees)")]
        public string WindDirec { get; set; }
        [Display(Name = "監測日期")]
        public string PublishTime { get; set; }
        [Display(Name = "細懸浮微粒移動平均值")]
        public string PM25_AVG { get; set; }
        [Display(Name = "懸浮微粒移動平均值")]
        public string PM10_AVG { get; set; }
        [Display(Name = "二氧化硫移動平均值")]
        public string SO2_AVG { get; set; }
        [Display(Name = "經度")]
        public string Longitude { get; set; }
        [Display(Name = "緯度")]
        public string Latitude { get; set; }
        [Display(Name = "監測站編號")]
        public string SiteId { get; set; }
    }
}