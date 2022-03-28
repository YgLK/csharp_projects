using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class SellCarForm : Form
    {
        public SellCarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string url_prefix = "https://www.google.com/search?tbm=isch&q=";
            string car = "Volkswagen Passat".ToLower().Replace(" ", "+");
            string car_url = url_prefix + car;
            // first picture is Google XD let's get next one
            // UPDATE: page doesnt load before scraping and only google image is taken :)
            //List<string> image_url = FetchImages("https://www.google.com/search?q=ferrari+enzo&sxsrf=APq-WBtPbZ_g0owDy_b9Y32r_ab8LJXnng:1648460215329&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjpmb7swOj2AhULjosKHYKHBYsQ_AUoAXoECAIQAw&biw=1536&bih=722&dpr=1.25");
            List<string> image_url = FetchImages(car_url);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.Load(image_url[0]);
        }

        // find first image found in Google graphics with the chosen car
        public List<string> FetchImages(string Url)
        {
            List<string> imageList = new List<string>();

            //Append http:// if necessary
            if (!Url.StartsWith("http://") && !Url.StartsWith("https://"))
                Url = "http://" + Url;

            string responseUrl = string.Empty;
            string htmlData = ASCIIEncoding.ASCII.GetString(DownloadData(Url, out responseUrl));

            if (responseUrl != string.Empty)
                Url = responseUrl;

            if (htmlData != string.Empty)
            {
                string imageHtmlCode = "<img";
                string imageSrcCode = @"src=""";

                int index = htmlData.IndexOf(imageHtmlCode);
                //for (int i=0; i < 2; i++)
                while(index != -1)
                {
                    //Remove previous data
                    htmlData = htmlData.Substring(index);

                    //Find the location of the two quotes that mark the image's location
                    int brackedEnd = htmlData.IndexOf('>'); //make sure data will be inside img tag
                    int start = htmlData.IndexOf(imageSrcCode) + imageSrcCode.Length;
                    int end = htmlData.IndexOf('"', start + 1);

                    //Extract the line
                    if (end > start && start < brackedEnd)
                    {
                        string loc = htmlData.Substring(start, end - start);

                        //Store line
                        imageList.Add(loc);
                        break;
                    }

                    //Move index to next image location
                    if (imageHtmlCode.Length < htmlData.Length)
                        index = htmlData.IndexOf(imageHtmlCode, imageHtmlCode.Length);
                    else
                        index = -1;
                }

                //Format the image URLs
                for (int i = 0; i < imageList.Count; i++)
                {
                    string img = imageList[i];

                    string baseUrl = GetBaseURL(Url);

                    if ((!img.StartsWith("http://") && !img.StartsWith("https://"))
                        && baseUrl != string.Empty)
                        img = baseUrl + "/" + img.TrimStart('/');

                    imageList[i] = img;
                }
            }

            return imageList;
        }

        private string GetBaseURL(string Url)
        {
            int inx = Url.IndexOf("://") + "://".Length;
            int end = Url.IndexOf('/', inx);

            string baseUrl = string.Empty;
            if (end != -1)
                return Url.Substring(0, end);
            else
                return string.Empty;
        }

        private byte[] DownloadData(string Url, out string responseUrl)
        {
            byte[] downloadedData = new byte[0];
            try
            {
                //Get a data stream from the url
                WebRequest req = WebRequest.Create(Url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                responseUrl = response.ResponseUri.ToString();

                //Download in chuncks
                byte[] buffer = new byte[1024];

                //Get Total Size
                int dataLength = (int)response.ContentLength;

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    //Try to read the data
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                stream.Close();
                memStream.Close();
            }
            catch (Exception)
            {
                responseUrl = string.Empty;
                return new byte[0];
            }

            return downloadedData;
        }
    }
}
