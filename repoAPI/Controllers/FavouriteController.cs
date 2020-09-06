using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using repoAPI.Models;

namespace repoAPI.Controllers
{
    [Route("favourite")]
    public class FavouriteController : Controller
    {
        private readonly IGitHubService _githubService;
        public FavouriteController(IGitHubService githubService)
        {
            _githubService = githubService;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            string path = Directory.GetCurrentDirectory();

            List<Repository> repositories = new List<Repository>();

            using (StreamReader reader = new StreamReader(path + "/Services/Favourites/favourites.txt"))
            {
                string id;
                while ((id = reader.ReadLine()) != null)
                {
                    Repository repository = await _githubService.GetRepositoryFromId(id);

                    repositories.Add(repository);
                }
                reader.Close();
            }
            return View("Favourite", repositories);
        }
        [HttpGet("{id}")]
        public void AddFavourite(string id)
        {
            string path = Directory.GetCurrentDirectory();

            bool exist = false;

            using (StreamReader reader = new StreamReader(path + "/Services/Favourites/favourites.txt"))
            {
                using (StreamWriter write = new StreamWriter(path + "/Services/Favourites/temp.txt"))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        if (String.Compare(linha, id) == 0)
                        {
                            exist = true;
                            break;
                        }
                        else
                        {
                            write.WriteLine(linha);
                        }
                    }
                    write.Close();
                }
                reader.Close();
            }
            if (exist)
            {
                System.IO.File.Delete(path + "/Services/Favourites/favourites.txt");
                System.IO.File.Move(path + "/Services/Favourites/temp.txt", path + "/Services/Favourites/favourites.txt");
            }
            else 
            {
                System.IO.File.Delete(path + "/Services/Favourites/temp.txt");
                using (StreamWriter writer = new StreamWriter(path + "/Services/Favourites/favourites.txt", true))
                {
                    writer.WriteLine(id);
                    writer.Close();
                }
            }
        }
    }
}