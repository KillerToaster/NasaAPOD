using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing;
using System.IO;
using System.Threading;

namespace NasaAPOD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            //create the instance fo the service
            NasaAPODService.Service1Client apodService = new NasaAPODService.Service1Client();

            string hdurl = apodService.getAPOD(); //the hdurl of the image we are getting
            currentPic.ImageUrl = hdurl; //set the image

            //set the explanation
            explanationTB.Text = apodService.getAPODExp();
            
        }

        public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }

        protected void getOldPicBtn_Click(object sender, EventArgs e)
        {
            //get the strings for the date input
            string year = yearTB.Text;
            string month = monthTB.Text;
            string day = dayTB.Text;

            NasaAPODService.Service1Client apodService = new NasaAPODService.Service1Client();
            string hdurl = apodService.getOldImage(year, month, day);
            Thread.Sleep(1000);
            string exp = apodService.getOldExp(year, month, day);
            currentPic.ImageUrl = hdurl;
            explanationTB.Text = exp;
        }
    }
}