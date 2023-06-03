using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Otomoto.Data;
using Otomoto.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.MVC.Models;

namespace Otomoto.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public CarController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IActionResult Index(int? carId, string opis, string marka, string model1, string typ, string pojemnosc, string skrzyniaBiegow, int? rokProdukcji, decimal? cena, int? vin, int? przebieg, string rodzajPaliwa)
        {
            var cars = _dbContext.Cars.AsQueryable();

            var carBrands = _dbContext.CarBrands.ToList();
            ViewBag.CarBrands = carBrands;
            cars = cars.Where(c => c.IsAdActive);

            if (carId.HasValue)
            {
                cars = cars.Where(c => c.CarId == carId.Value);
            }

            if (!string.IsNullOrEmpty(opis))
            {
                cars = cars.Where(c => c.Opis.Contains(opis));
            }

            if (!string.IsNullOrEmpty(marka))
            {
                cars = cars.Where(c => c.Marka == marka);
            }

            if (!string.IsNullOrEmpty(model1))
            {
                cars = cars.Where(c => c.Model.Contains(model1));
            }

            if (!string.IsNullOrEmpty(typ))
            {
                cars = cars.Where(c => c.Typ.Contains(typ));
            }

            if (!string.IsNullOrEmpty(pojemnosc))
            {
                cars = cars.Where(c => c.Pojemnosc.Contains(pojemnosc));
            }

            if (!string.IsNullOrEmpty(skrzyniaBiegow))
            {
                cars = cars.Where(c => c.SkrzyniaBiegow.Contains(skrzyniaBiegow));
            }

            if (rokProdukcji.HasValue)
            {
                cars = cars.Where(c => c.RokProdukcji == rokProdukcji.Value);
            }

            if (cena.HasValue)
            {
                cars = cars.Where(c => c.Cena == cena.Value);
            }

            if (vin.HasValue)
            {
                cars = cars.Where(c => c.Vin == vin.Value);
            }

            if (przebieg.HasValue)
            {
                cars = cars.Where(c => c.Przebieg == przebieg.Value);
            }

            if (!string.IsNullOrEmpty(rodzajPaliwa))
            {
                cars = cars.Where(c => c.RodzajPaliwa.Contains(rodzajPaliwa));
            }

            var model = cars.ToList();
            return View(model);
        }

        [Authorize]

        [Authorize(Roles = "SuperAdmin,Moderator")]
        public IActionResult Manage(int? carId, string opis, string marka, string model1, string typ, string pojemnosc, string skrzyniaBiegow, int? rokProdukcji, decimal? cena, int? vin, int? przebieg, string rodzajPaliwa)
        {
            var cars = _dbContext.Cars.AsQueryable();

            var carBrands = _dbContext.CarBrands.ToList();
            ViewBag.CarBrands = carBrands;

            if (carId.HasValue)
            {
                cars = cars.Where(c => c.CarId == carId.Value);
            }

            if (!string.IsNullOrEmpty(opis))
            {
                cars = cars.Where(c => c.Opis.Contains(opis));
            }

            if (!string.IsNullOrEmpty(marka))
            {
                cars = cars.Where(c => c.Marka == marka);
            }

            if (!string.IsNullOrEmpty(model1))
            {
                cars = cars.Where(c => c.Model.Contains(model1));
            }

            if (!string.IsNullOrEmpty(typ))
            {
                cars = cars.Where(c => c.Typ.Contains(typ));
            }

            if (!string.IsNullOrEmpty(pojemnosc))
            {
                cars = cars.Where(c => c.Pojemnosc.Contains(pojemnosc));
            }

            if (!string.IsNullOrEmpty(skrzyniaBiegow))
            {
                cars = cars.Where(c => c.SkrzyniaBiegow.Contains(skrzyniaBiegow));
            }

            if (rokProdukcji.HasValue)
            {
                cars = cars.Where(c => c.RokProdukcji == rokProdukcji.Value);
            }

            if (cena.HasValue)
            {
                cars = cars.Where(c => c.Cena == cena.Value);
            }

            if (vin.HasValue)
            {
                cars = cars.Where(c => c.Vin == vin.Value);
            }

            if (przebieg.HasValue)
            {
                cars = cars.Where(c => c.Przebieg == przebieg.Value);
            }

            if (!string.IsNullOrEmpty(rodzajPaliwa))
            {
                cars = cars.Where(c => c.RodzajPaliwa.Contains(rodzajPaliwa));
            }

            var model = cars.ToList();
            return View(model);
        }

        [Authorize]
        [Authorize(Roles = "Basic,Moderator")]
        public IActionResult Create()
        {
            var carBrands = _dbContext.CarBrands.ToList();
            ViewBag.CarBrands = carBrands;
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Basic")]
        public async Task<IActionResult> MyCars()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var userCars = _dbContext.Cars.Where(c => c.CarUserId == currentUser.Id).ToList();
            Console.WriteLine($"Found {userCars.Count} cars for user {currentUser.UserName}.");
            return View(userCars);
        }

        [Authorize]
        [Authorize(Roles = "Moderator")]
        public IActionResult Inactive()
        {
            var car = _dbContext.Cars.Where(c => c.IsAdActive == false).ToList();
            return View(car);
        }


        [Authorize]
        [Authorize(Roles = "Basic,Moderator")]
        [HttpPost]
        public async Task<IActionResult> Create(Car car, IFormFile carImage)
        {

            var carBrands = _dbContext.CarBrands.ToList();
            ViewBag.CarBrands = carBrands;

            if (carImage == null)
            {
                ModelState.AddModelError("Error", "Image is required");
            }

            if (string.IsNullOrEmpty(car.Typ))
            {
                ModelState.AddModelError("Error", "Nadwozie jest wymagane.");
            }
            if (string.IsNullOrEmpty(car.Marka))
            {
                ModelState.AddModelError("Error", "Marka jest wymagana.");
            }
            if (string.IsNullOrEmpty(car.SkrzyniaBiegow))
            {
                ModelState.AddModelError("Error", "Skrzynia biegów jest wymagana.");
            }
            if (string.IsNullOrEmpty(car.RodzajPaliwa))
            {
                ModelState.AddModelError("Error", "Rodzaj paliwa jest wymagany.");
            }

            if (carImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await carImage.CopyToAsync(memoryStream);
                    car.CarPicture = memoryStream.ToArray();
                }

                var currentUser = await _userManager.GetUserAsync(User);
                car.CarUserId = currentUser.Id;
                car.IsAdActive = false;
                _dbContext.Cars.Add(car);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(car);
        }


        [Authorize]
        public IActionResult CheckVIN(int Vin)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Vin == Vin);
            if (car == null)
            {
                return Json(true);
            }
            return Json(false);
        }

        [Authorize]
        [Authorize(Roles = "Basic,Moderator")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _dbContext.Cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);
            if (!User.IsInRole("SuperAdmin") && !User.IsInRole("Admin") && !User.IsInRole("Moderator") && car.CarUserId != userId)
            {
                return Forbid();
            }

            return View(car);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Car car, IFormFile carImage)
        {
            var existingCar = _dbContext.Cars.FirstOrDefault(c => c.CarId == car.CarId);
            if (existingCar == null)
            {
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (!User.IsInRole("SuperAdmin") && !User.IsInRole("Admin") && !User.IsInRole("Moderator") && existingCar.CarUserId != currentUser.Id)
            {
                return Forbid();
            }

            existingCar.Opis = car.Opis;
            existingCar.Model = car.Model;
            existingCar.Marka = car.Marka;
            existingCar.Typ = car.Typ;
            existingCar.Pojemnosc = car.Pojemnosc;
            existingCar.SkrzyniaBiegow = car.SkrzyniaBiegow;
            existingCar.RokProdukcji = car.RokProdukcji;
            existingCar.Cena = car.Cena;
            existingCar.Vin = car.Vin;
            existingCar.Przebieg = car.Przebieg;
            existingCar.RodzajPaliwa = car.RodzajPaliwa;
            existingCar.CreatedAt = car.CreatedAt;
            existingCar.IsAdActive = car.IsAdActive;
            existingCar.IsAdPaid = car.IsAdPaid;

            if (carImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await carImage.CopyToAsync(memoryStream);
                    existingCar.CarPicture = memoryStream.ToArray();
                }
            }

            _dbContext.Cars.Update(existingCar);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [Authorize]
        [Authorize(Roles = "Moderator")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _dbContext.Cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [Authorize(Roles = "Basic")]
        public async Task<IActionResult> DeleteOwnCar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _dbContext.Cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(User);

            if (car.CarUserId != currentUser.Id)
            {
                return Forbid(); 
            }

            _dbContext.Cars.Remove(car);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(MyCars));
        }

        [Authorize]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _dbContext.Cars.FirstOrDefaultAsync(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            car.IsAdActive = true;

            _dbContext.Cars.Update(car);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _dbContext.Cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }



    }
}