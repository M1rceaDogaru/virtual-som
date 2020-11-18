using Microsoft.AspNetCore.Mvc;
using VirtualSom.Web.Models;
using VirtualSomML.Model;

namespace VirtualSom.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(IndexViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.Description))
            {
                var data = new ModelInput()
                {
                    Description = model.Description
                };

                var result = ConsumeModel.Predict(data);
                model.Suggestion = result.Prediction;
            }

            return View(model);
        }
    }
}
