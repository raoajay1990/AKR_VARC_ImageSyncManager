using ImageSyncManager.Constants;
using ImageSyncManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSyncManager.DAL
{
    public class ProjectSyncManagerDAL
    {
        public int AddNewPage(Page page)
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = DBConstants.ConnString;

                conn.Open();

                SqlCommand cmd = new SqlCommand(DBConstants.procAddPage, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pageName", SqlDbType.NVarChar).Value = page.PageName;
                cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = page.IsActive;
                cmd.Parameters.Add("@createdDate", SqlDbType.Date).Value = page.CreatedDate;
                int pageID =  Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return pageID;
            }
            catch(Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }

        public void AddNewArticle(Article article)
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = DBConstants.ConnString;

                conn.Open();

                SqlCommand cmd = new SqlCommand(DBConstants.procAddArticle, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ArticleTitle", SqlDbType.NVarChar).Value = article.ArticleTitle;
                cmd.Parameters.Add("@ArticleDescription", SqlDbType.NVarChar).Value = article.ArticleDescription;
                cmd.Parameters.Add("@pageID", SqlDbType.Int).Value = article.PageObj.PageID;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.Date).Value = article.CreatedDate;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }

        public void AddImage(Image image)
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = DBConstants.ConnString;

                conn.Open();

                SqlCommand cmd = new SqlCommand(DBConstants.procAddImages, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ImageName", SqlDbType.NVarChar).Value = image.ImageName;
                cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = image.ImagePath;
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = image.Photo;
                cmd.Parameters.Add("@PageID", SqlDbType.Int).Value = image.PageObj.PageID;
                cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = image.IsActive;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.Date).Value = image.CreatedDate;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
    }
}
