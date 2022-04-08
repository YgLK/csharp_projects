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

        // TODO:   CREATE IMAGE UPLOAD FOR EACH CREATED OFFER






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
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            priceTextBox.Text = "";
            engineTextBox.Text = "";
            colorTextBox.Text = "";
        }

        private void addOfferButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            string year = yearTextBox.Text;
            string engine = engineTextBox.Text;
            string color = colorTextBox.Text;
            string price = priceTextBox.Text;

            string record = year + "," + make + "," + model + "," + price + "," + color + "," + engine;
            
            // it should append txt to cardata_test.txt
            File.AppendAllText(@"E:\csharp_projects\advanced_programming2\CarDealership\CarDealership\carData_test.txt",
                   record + Environment.NewLine);

            // TODO: upload picture associated with pushed to the data offer


            MessageBox.Show("New offer has been added.");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialogCarImage.Filter = "Images (*.png) | *.png"; // file types, that will be allowed to upload
            openFileDialogCarImage.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (openFileDialogCarImage.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = openFileDialogCarImage.FileName; // get name of file
                //using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                //{
                //    //
                //}
                carImage.ImageLocation = path;
                string color = colorTextBox.Text;
                string model = modelTextBox.Text;
                string filename = color + model + ".png";
                string carImagesDirPath = @"E:\csharp_projects\advanced_programming2\CarDealership\CarDealership\CarImages\" + filename;
                System.IO.File.Copy(path, carImagesDirPath);
            }
        }

        // find first image found in Google graphics with the chosen car
        //public List<string> FetchImages(string Url)
        //{
        //    List<string> imageList = new List<string>();

        //    //Append http:// if necessary
        //    if (!Url.StartsWith("http://") && !Url.StartsWith("https://"))
        //        Url = "http://" + Url;

        //    string responseUrl = string.Empty;
        //    string htmlData = ASCIIEncoding.ASCII.GetString(DownloadData(Url, out responseUrl));

        //    if (responseUrl != string.Empty)
        //        Url = responseUrl;

        //    if (htmlData != string.Empty)
        //    {
        //        string imageHtmlCode = "<img";
        //        string imageSrcCode = @"src=""";

        //        int index = htmlData.IndexOf(imageHtmlCode);
        //        //for (int i=0; i < 2; i++)
        //        while(index != -1)
        //        {
        //            //Remove previous data
        //            htmlData = htmlData.Substring(index);

        //            //Find the location of the two quotes that mark the image's location
        //            int brackedEnd = htmlData.IndexOf('>'); //make sure data will be inside img tag
        //            int start = htmlData.IndexOf(imageSrcCode) + imageSrcCode.Length;
        //            int end = htmlData.IndexOf('"', start + 1);

        //            //Extract the line
        //            if (end > start && start < brackedEnd)
        //            {
        //                string loc = htmlData.Substring(start, end - start);

        //                //Store line
        //                imageList.Add(loc);
        //                break;
        //            }

        //            //Move index to next image location
        //            if (imageHtmlCode.Length < htmlData.Length)
        //                index = htmlData.IndexOf(imageHtmlCode, imageHtmlCode.Length);
        //            else
        //                index = -1;
        //        }

        //        //Format the image URLs
        //        for (int i = 0; i < imageList.Count; i++)
        //        {
        //            string img = imageList[i];

        //            string baseUrl = GetBaseURL(Url);

        //            if ((!img.StartsWith("http://") && !img.StartsWith("https://"))
        //                && baseUrl != string.Empty)
        //                img = baseUrl + "/" + img.TrimStart('/');

        //            imageList[i] = img;
        //        }
        //    }

        //    return imageList;
        //}

        //    private string GetBaseURL(string Url)
        //    {
        //        int inx = Url.IndexOf("://") + "://".Length;
        //        int end = Url.IndexOf('/', inx);

        //        string baseUrl = string.Empty;
        //        if (end != -1)
        //            return Url.Substring(0, end);
        //        else
        //            return string.Empty;
        //    }

        //    private byte[] DownloadData(string Url, out string responseUrl)
        //    {
        //        byte[] downloadedData = new byte[0];
        //        try
        //        {
        //            //Get a data stream from the url
        //            WebRequest req = WebRequest.Create(Url);
        //            WebResponse response = req.GetResponse();
        //            Stream stream = response.GetResponseStream();

        //            responseUrl = response.ResponseUri.ToString();

        //            //Download in chuncks
        //            byte[] buffer = new byte[1024];

        //            //Get Total Size
        //            int dataLength = (int)response.ContentLength;

        //            //Download to memory
        //            //Note: adjust the streams here to download directly to the hard drive
        //            MemoryStream memStream = new MemoryStream();
        //            while (true)
        //            {
        //                //Try to read the data
        //                int bytesRead = stream.Read(buffer, 0, buffer.Length);

        //                if (bytesRead == 0)
        //                {
        //                    break;
        //                }
        //                else
        //                {
        //                    //Write the downloaded data
        //                    memStream.Write(buffer, 0, bytesRead);
        //                }
        //            }

        //            //Convert the downloaded stream to a byte array
        //            downloadedData = memStream.ToArray();

        //            //Clean up
        //            stream.Close();
        //            memStream.Close();
        //        }
        //        catch (Exception)
        //        {
        //            responseUrl = string.Empty;
        //            return new byte[0];
        //        }

        //        return downloadedData;
        //    }
    }
}
