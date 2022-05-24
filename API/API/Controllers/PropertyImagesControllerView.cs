using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Web.Administration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyImagesViewController : ControllerBase
    {


        public static IWebHostEnvironment _WebHostEnvironment;
        public PropertyImagesViewController(IWebHostEnvironment webHostEnvironment)
        {
            _WebHostEnvironment = webHostEnvironment;
        }

        // POST: api/PropertyImages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostPropertyImage([FromForm] PropertyImageView propertyImage)
        {
            try
            {
                if (propertyImage.FileUrl.Length > 0)
                {
                    string path = _WebHostEnvironment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + propertyImage.FileUrl.FileName))
                    {
                        propertyImage.FileUrl.CopyTo(fileStream);
                        fileStream.Flush();

                        string ConnectionString = "Server=DESKTOP-HMI7REM; Database=WebApi; Trusted_Connection=True; MultipleActiveResultSets=True;";

                        SqlConnection connection = new SqlConnection(ConnectionString);
                        string Query = $"insert into PropertyImage (FilesUrl)" +
                            $"Values('{path + propertyImage.FileUrl.FileName}')";

                        SqlCommand cmd = new SqlCommand(Query, connection);
                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception E)
                        {
                            return E.Message;
                        }
                        finally {
                            connection.Close();
                        };
                        return "Upload Done...";
                    }
                }
                else
                {
                    return "Failed to upload";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        // GET: api/PropertyImages/5
        [HttpGet("{filename}")]
        public async Task<IActionResult> GetPropertyImage([FromRoute] string filename)
        {
            try
            {
                var path = _WebHostEnvironment.WebRootPath + "\\uploads\\";
                var filePath = path + filename + ".png";

                if (System.IO.File.Exists(filePath))
                {
                    byte[] b = System.IO.File.ReadAllBytes(filePath);
                    return File(b, "image/png");
                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
