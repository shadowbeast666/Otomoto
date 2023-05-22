using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Otomoto.Data;
using Otomoto.Models;

namespace Otomoto.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CarController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int? carId, string opis, string marka, string model1, string typ, string pojemnosc, string skrzyniaBiegow, int? rokProdukcji, decimal? cena, int? vin, int? przebieg, string rodzajPaliwa)
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



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car, IFormFile carImage)
        {
            if (carImage == null)
            {
                ModelState.AddModelError("", "Image is required");
            }

            if (ModelState.IsValid && carImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await carImage.CopyToAsync(memoryStream);
                    car.CarPicture = memoryStream.ToArray();
                }

                _dbContext.Cars.Add(car);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(car);
        }

        public IActionResult CheckVIN(int Vin)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Vin == Vin);
            if (car == null)
            {
                return Json(true);
            }
            return Json(false);
        }

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

            return View(car);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Car car, IFormFile carImage)
        {
            var existingCar = _dbContext.Cars.FirstOrDefault(c => c.CarId == car.CarId);
            if (existingCar == null)
            {
                return NotFound();
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
