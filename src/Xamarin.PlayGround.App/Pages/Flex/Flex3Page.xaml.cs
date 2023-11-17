using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Flex
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flex3Page : ContentPage
    {
        [DataContract]
        class ImageList
        {
            [DataMember(Name = "photos")]
            public List<string> Photos = null;
        }
        
        public Flex3Page()
        {
            InitializeComponent();
            
            LoadBitmapCollection();
        }
        
        async void LoadBitmapCollection()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Download the list of stock photos
                    Uri uri = new Uri("https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/stock.json");
                    byte[] data = await webClient.DownloadDataTaskAsync(uri);

                    // Convert to a Stream object
                    using (Stream stream = new MemoryStream(data))
                    {
                        // Deserialize the JSON into an ImageList object
                        var jsonSerializer = new DataContractJsonSerializer(typeof(ImageList));
                        ImageList imageList = (ImageList)jsonSerializer.ReadObject(stream);

                        // Create an Image object for each bitmap
                        foreach (string filepath in imageList.Photos)
                        {
                            Image image = new Image
                            {
                                Source = ImageSource.FromUri(new Uri(filepath))
                            };
                            flexLayout.Children.Add(image);
                        }
                    }
                }
                catch
                {
                    flexLayout.Children.Add(new Label
                    {
                        Text = "Cannot access list of bitmap files"
                    });
                }
            }

            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
        }
    }
}