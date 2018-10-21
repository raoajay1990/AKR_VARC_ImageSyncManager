using ProjectSyncWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProjectSyncWebAPI.Repository
{
    public class SyncManagerRepository
    {
        public List<PageViewModel> GetPages()
        {
            List<PageViewModel> pageViewModel = new List<PageViewModel>();
            string query = "Select PageID,PageName from Pages";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = @"Data Source=AJAY-PC\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable data = new DataTable();
                data.Load(reader);

                foreach (DataRow row in data.Rows)
                {
                    pageViewModel.Add(new PageViewModel()
                    {
                        PageID = row["PageID"] != null ? Convert.ToInt32(row["PageID"]) : -1,
                        PageName = row["PageName"] != null ? Convert.ToString(row["PageName"]) : string.Empty
                    });
                }

                conn.Close();
                return pageViewModel;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }

        public async Task<ProjectContentViewModel> GetPageContent(int pageID)
        {
            ProjectContentViewModel content = new ProjectContentViewModel();
            content.Article = await GetArticle(pageID);
            content.Images = await GetImages(pageID);
            return content;
        }

        public async Task<List<ImageViewModel>> GetImages(int pageID)
        {
            List<ImageViewModel> images = new List<ImageViewModel>();

            string query = "Select ImageID,ImageName,Image from  Images where PageID="+ pageID;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = @"Data Source=AJAY-PC\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable data = new DataTable();
                data.Load(reader);

                foreach (DataRow row in data.Rows)
                {
                    images.Add(new ImageViewModel()
                    {
                        ImageID = row["ImageID"] != null ? Convert.ToInt32(row["ImageID"]) : -1,
                        ImageName = row["ImageName"] != null ? Convert.ToString(row["ImageName"]) : string.Empty,
                        //Photo = row["Image"] != null ? (Image)new Object():null
                        Photo = row["Image"] != null ? await GetPhoto(Convert.ToString(row["ImageName"]),(byte[])row["Image"]):null
                    });
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }

            return images;
        }

        public async Task<Image> GetPhoto(string imageName , byte[] image)
        {
            try
            {
                MemoryStream ms = new MemoryStream(image);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
                //FileStream fs = new FileStream(imageName, FileMode.CreateNew, FileAccess.Write);
                //fs.Write(image, 0, image.Length);
                //fs.Flush();
                //fs.Close();
                //Image theImage = System.Drawing.Image.FromFile(imageName);
                //return theImage;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ArticleViewModel> GetArticle(int pageID)
        {
            ArticleViewModel article = new ArticleViewModel();

            string query = "Select ArticleID,ArticleTitle,ArticleDescription from Articles where PageID=" + pageID;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = @"Data Source=AJAY-PC\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable data = new DataTable();
                data.Load(reader);

                foreach (DataRow row in data.Rows)
                {
                    article.ArticleID = row["ArticleID"] != null ? Convert.ToInt32(row["ArticleID"]) : -1;
                    article.ArticleTitle = row["ArticleTitle"] != null ? Convert.ToString(row["ArticleTitle"]) : string.Empty;
                    article.ArticleDescription = row["ArticleDescription"] != null ? Convert.ToString(row["ArticleDescription"]) : string.Empty;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }

            return article;
        }
    }
}