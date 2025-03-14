using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using MVC_Session01.Models;

namespace MVC_Session01.Controllers
{
    public class MovieController : Controller
    {
        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id : {id}";
        //}
        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}

        //-----------------------------

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id : {id}",
        //        ContentType="text/html",
        //        StatusCode = 200
        //    }; 
        //    return contentResult;
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id : {id}",
        //        ContentType="object/pdf",
        //        StatusCode = 200
        //    }; 
        //    return contentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://drive.google.com/drive/u/1/home");

        //    return redirectResult;
        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new {id=133 });

        //    return redirectToActionResult;
        //}

        //-----------------------------

        //[ActionName("GetMovie")]
        //[HttpPost]
        //public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //       // return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "text/plain" };
        //        return Content( $"Get Movie With Id: {id}",  "text/plain");
        //    }
        //    else if (id == 2)
        //    {
        //       // return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "application/json" };
        //        return Content( $"Get Movie With Id: {id}",  "application/json");

        //    }
        //    else if (id == 3)
        //    {
        //        // return new RedirectResult(url: "https://drive.google.com/drive/u/1/home");
        //        return Redirect("https://drive.google.com/drive/u/1/home");
        //    }
        //    else
        //    {
        //        // return new RedirectToActionResult(actionName: "AddMovie", controllerName: "Movie", new { id = id });
        //        return RedirectToAction("AddMovie",  "Movie", new { id = id });
        //    }
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}
        //-----------------------------

        // Actions Parameter Binding
        // 1. Form
        // 2. Segment
        // 3. Query Params
        // 4. Files

        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Get Movie With Id: {movie.Id} , Name: {movie.Name}", "text/plain");
        }


    }
}
