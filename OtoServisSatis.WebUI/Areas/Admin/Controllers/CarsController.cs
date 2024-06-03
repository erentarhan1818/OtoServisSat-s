using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.WebUI.Utils;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class CarsController : Controller
    {
        private readonly ICarService _service;
        private readonly IService<Marka> _serviceMarka;


        public CarsController(ICarService service, IService<Marka> serviceMarka)
        {
            _service = service;
            _serviceMarka = serviceMarka;
        }

        // GET: CarsController
        public async Task<IActionResult> IndexAsync()
        {
            var model = await _service.GetCustomCarList();
            return View(model);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.MarkaId = new SelectList( await _serviceMarka.GetAllAsync(),"Id","Adi");
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Arac arac, IFormFile? Resim1, IFormFile? Resim2, IFormFile? Resim3, IFormFile? Resim4, IFormFile? Resim5, IFormFile? Resim6, IFormFile? Resim7, IFormFile? Resim8, IFormFile? Resim9, IFormFile? Resim10, IFormFile? Resim11)
        {
            if (ModelState.IsValid)
            {
               try
               {
                    arac.Resim1 =await  FileHelper.FileLoaderAsync(Resim1 , "/Img/Cars/");
                    arac.Resim2 = await FileHelper.FileLoaderAsync(Resim2, filePath: "/Img/Cars/");
                    arac.Resim3 = await FileHelper.FileLoaderAsync(Resim3, "/Img/Cars/");
                    arac.Resim4 = await FileHelper.FileLoaderAsync(Resim4, "/Img/Cars/");
                    arac.Resim5 = await FileHelper.FileLoaderAsync(Resim5, "/Img/Cars/"); 
                    arac.Resim6 = await FileHelper.FileLoaderAsync(Resim6, "/Img/Cars/");
                    arac.Resim7 = await FileHelper.FileLoaderAsync(Resim7, "/Img/Cars/");
                    arac.Resim8 = await FileHelper.FileLoaderAsync(Resim8, "/Img/Cars/");
                    await _service.AddAsycn(arac);
                  ;
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
               }
            catch
            {
                    ModelState.AddModelError("", "Hata oluştu !");

                }
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            return View(arac);
        }

        // GET: CarsController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            var model = await _service.FindAsyc(id);
            return View(model);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Arac arac, IFormFile?  Resim1, IFormFile? Resim2, IFormFile? Resim3, IFormFile? Resim4, IFormFile? Resim5, IFormFile? Resim6, IFormFile? Resim7, IFormFile? Resim8, IFormFile? Resim9, IFormFile? Resim10, IFormFile? Resim11, IFormFile? Resim12, IFormFile? Resim13, IFormFile? Resim14)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Resim1 is not null )
                    {
                        arac.Resim1 = await FileHelper.FileLoaderAsync(Resim1, "/Img/Cars/");
                    }
                    if (Resim2 is not null)
                    {
                        arac.Resim2 = await FileHelper.FileLoaderAsync(Resim2 , "/Img/Cars/");
                    }
                    if (Resim3 is not null)
                    {
                        arac.Resim3 = await FileHelper.FileLoaderAsync(Resim3, "/Img/Cars/");
                    }
                    if (Resim4 is not null)
                    {
                        arac.Resim4 = await FileHelper.FileLoaderAsync(Resim4, "/Img/Cars/");
                    }
                    if (Resim5 is not null)
                    {
                        arac.Resim5 = await FileHelper.FileLoaderAsync(Resim5, "/Img/Cars/");
                    }
                    if (Resim6 is not null)
                    {
                        arac.Resim6 = await FileHelper.FileLoaderAsync(Resim6, "/Img/Cars/");
                    }
                    if (Resim7 is not null)
                    {
                        arac.Resim7 = await FileHelper.FileLoaderAsync(Resim7, "/Img/Cars/");
                    }
                    if (Resim8 is not null)
                    {
                        arac.Resim8 = await FileHelper.FileLoaderAsync(Resim8, "/Img/Cars/");
                    }
                   
                 


                    _service.Update(arac);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata oluştu !");

                }
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            return View(arac);
        }

        // GET: CarsController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _service.FindAsyc(id);
            return View(model);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id, Arac arac)
        {
            try
            {
                _service.Delete(arac);
                await _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
