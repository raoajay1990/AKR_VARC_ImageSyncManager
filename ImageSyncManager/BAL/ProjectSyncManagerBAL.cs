using ImageSyncManager.DAL;
using ImageSyncManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSyncManager.BAL
{
    public class ProjectSyncManagerBAL
    {
        public int NumberOfProjects(string path)
        {
            int count = 0;
            if (path != string.Empty)
            {
                count = Directory.GetDirectories(path).Length;
            }

            return count;
        }

        public string AddProjectDetails(string path)
        {
            try
            {
                ProjectSyncManagerDAL projSyncManagerDAL = new ProjectSyncManagerDAL();
                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    if (CheckIfFoldersExists(directory))
                    {
                        Page page = new Page();
                        page.PageName = Path.GetFileName(directory);
                        page.IsActive = true;
                        page.CreatedDate = DateTime.Today;

                        page.PageID = projSyncManagerDAL.AddNewPage(page);

                        if (page.PageID > 0)
                        {
                            Article article = new Article();
                            article.ArticleTitle = Path.GetFileName(directory);
                            article.CreatedDate = DateTime.Today;
                            article.PageObj = page;
                            article.ArticleDescription = File.ReadAllText(directory + @"\Description\description.txt");

                            projSyncManagerDAL.AddNewArticle(article);

                            Image image = new Image();
                            var imgFiles = Directory.GetFiles(directory + @"\Images");
                            foreach (var file in imgFiles)
                            {
                                if (Path.GetExtension(file) == ".jpg" || Path.GetExtension(file) == ".png")
                                {
                                    image.ImageName = Path.GetFileName(file);
                                    image.ImagePath = file;
                                    image.IsActive = true;
                                    image.PageObj = page;
                                    image.Photo = GetPhoto(file);
                                    image.CreatedDate = DateTime.Today;

                                    projSyncManagerDAL.AddImage(image);
                                }
                            }
                        }
                        else
                        {
                            return "Page ID not created for Project";
                        }
                        
                    }
                    else
                    {
                        return "Folder Doesnt Exists";
                    }

                }
                return "Projects Added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }


        public bool CheckIfFoldersExists(string path)
        {
            bool exists = false;

            if (!File.Exists(path + @"\Description\description.txt"))
            {
                return exists;
            }
            else if (!(Directory.GetDirectories(path).Length > 0))
            {
                return exists;
            }
            else
            {
                exists = true;
                return exists;
            }
        }
    }
}
