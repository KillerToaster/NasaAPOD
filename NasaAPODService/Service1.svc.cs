using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NasaAPODService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //get the image of the day
        public string getAPOD()
        {
            /*
             Steps:
                1. Download JSON content from api call
                2. get image url from JSON
                3. get image using webclient
                4. display image
                5. Display image title
                6. display explanation
            */

            //using newtonsoft. get the JSON with the information in it
            //var url = $"https://api.nasa.gov/planetary/apod"; //no parameters for this call



            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr";
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.hdurl;
                Console.WriteLine(output);
                return output; //return the hdurl
            }

        }

        public string getAPODTitle()
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr";
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.title;
                Console.WriteLine(output);
                return output; //return the hdurl
            }
        }

        public string getAPODExp()
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr";
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.explanation;
                Console.WriteLine(output);
                return output;
            }
        }

        public string getAPODDate()
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr";
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.date;
                Console.WriteLine(output);
                return output;
            }
        }


        public string getOldImage(string year, string month, string day)
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr&date=" + year + "-" + month + "-" + day;
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.hdurl;
                Console.WriteLine(output);
                return output; //return the hdurl
            }   
        }

        public string getOldTitle(string year, string month, string day)
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr&date=" + year + "-" + month + "-" + day;
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.title;
                Console.WriteLine(output);
                return output; //return the hdurl
            }
        }

        public string getOldExp(string year, string month, string day)
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr&date=" + year + "-" + month + "-" + day;
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                //Console.WriteLine(Info);
                string output = Info.explanation;
                //Console.WriteLine(output);
                return output; //return the hdurl
            }
        }

        public string getOldDate(string year, string month, string day)
        {
            using (WebClient web = new WebClient())
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=oMGPh1XBZwgwXMxLuHa4QYZIl0nOXRNWXfLDcqGr&date=" + year + "-" + month + "-" + day;
                var json = web.DownloadString(url);

                AstronomyImage.root Info = JsonConvert.DeserializeObject<AstronomyImage.root>(json);
                Console.WriteLine(Info);
                string output = Info.date;
                Console.WriteLine(output);
                return output; //return the hdurl
            }
        }


    }
}
