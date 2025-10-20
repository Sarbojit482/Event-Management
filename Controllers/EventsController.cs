using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;
using EventManagement.ViewModels;

namespace EventManagement.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EventsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /Events
        public async Task<IActionResult> Index()
        {
            var events = await _db.Events.Include(e => e.Venue)
                                         .OrderBy(e => e.StartTime)
                                         .ToListAsync();
            return View(events);
        }

        // GET: /Events/Create
        public IActionResult Create()
        {
            var vm = new EventViewModel
            {
                Venues = _db.Venues.ToList()
            };
            return View(vm);
        }

        // POST: /Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Venues = _db.Venues.ToList();
                return View(vm);
            }

            var ev = new Event
            {
                Title = vm.Title,
                StartTime = vm.StartTime.ToUniversalTime(),
                EndTime = vm.EndTime.ToUniversalTime(),
                Description = vm.Description,
                VenueId = vm.VenueId
            };

            _db.Add(ev);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var ev = await _db.Events.FindAsync(id);
            if (ev == null) return NotFound();

            var vm = new EventViewModel
            {
                Id = ev.Id,
                Title = ev.Title,
                StartTime = ev.StartTime,
                EndTime = ev.EndTime,
                Description = ev.Description,
                VenueId = ev.VenueId,
                Venues = _db.Venues.ToList()
            };

            return View(vm);
        }

        // POST: /Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EventViewModel vm)
        {
            if (id != vm.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                vm.Venues = _db.Venues.ToList();
                return View(vm);
            }

            var ev = await _db.Events.FindAsync(id);
            if (ev == null) return NotFound();

            ev.Title = vm.Title;
            ev.StartTime = vm.StartTime.ToUniversalTime();
            ev.EndTime = vm.EndTime.ToUniversalTime();
            ev.Description = vm.Description;
            ev.VenueId = vm.VenueId;

            try
            {
                _db.Update(ev);
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_db.Events.Any(e => e.Id == id))
                    return NotFound();
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: /Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var ev = await _db.Events.Include(e => e.Venue)
                                     .FirstOrDefaultAsync(e => e.Id == id);
            if (ev == null) return NotFound();

            return View(ev);
        }

        // POST: /Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ev = await _db.Events.FindAsync(id);
            if (ev != null)
            {
                _db.Events.Remove(ev);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
