using Azure.Storage;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJobHunter.Controllers
{
  public class HomeController : Controller
  {
    private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

    public IActionResult Index()
    {
      ViewBag.carousel = db.tbl_carousel_image.Where(x=>x.module == "JOB").ToList();
      ViewBag.location = db.tbl_location.ToList();
      var models = db.tbl_category_j.ToList();
      return View(models);
    }

    public IActionResult Menu()
    {
      var models = db.tbl_category_j.ToList();
      return PartialView("_Menu", models);
    }

    public IActionResult AboutUs()
    {
      return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private CloudBlobContainer getBlobStorageInformation(string containername)
    {
      //step 1: read json
      var builder = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json");
      IConfigurationRoot configure = builder.Build();
      //to get key access
      //once link, time to read the content to get the connectionstring
      CloudStorageAccount objectaccount =
      CloudStorageAccount.Parse(configure["ConnectionStrings:BlobStorageConnection"]);
      CloudBlobClient blobclient = objectaccount.CreateCloudBlobClient();
      //step 2: how to create a new container in the blob storage account.
      CloudBlobContainer container = blobclient.GetContainerReference(containername);
      return container;
    }

    public string UploadStorage(IFormFile model, string fname, string containername)
    {
      try
      {
        //refer to the container
        CloudBlobContainer container = getBlobStorageInformation(containername);
        CloudBlockBlob blob = container.GetBlockBlobReference(fname);
        using (var ms = new MemoryStream())
        {
          model.CopyTo(ms);
          ms.Position = 0;
          blob.UploadFromStreamAsync(ms).Wait();          
        }
        return blob.Uri.ToString();
      }
      catch (Exception ex)
      {
        return "";
      }
    }

    




  }
}
