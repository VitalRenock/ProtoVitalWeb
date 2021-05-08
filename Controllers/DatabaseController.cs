using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitalWeb.Models;

namespace VitalWeb.Controllers
{
    public class DatabaseController : Controller
    {

        #region Database connexion

        private readonly DatabaseCxt _context;

        public DatabaseController(DatabaseCxt context)
        {
            _context = context;
        }

        #endregion

        #region Index

        // GET: Database
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.ToListAsync());
        }

        #endregion

        #region Details

        // GET: Database/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        #endregion

        #region Create

        // GET: Database/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Database/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,PostTitle,PostContent,PostDate")] Post post)
        {
            if (ModelState.IsValid)
            {
                _context.Add(post);
                await _context.SaveChangesAsync();

                // Test de mon interface
                using (IDal dal = new Dal(_context))
                {
                    dal.CreerRestaurant("La bonne fourchette", "01 02 03 04 05");
                    ViewBag.Restos = dal.ObtientTousLesRestaurants();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        #endregion

        #region Edit

        // GET: Database/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Database/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,PostTitle,PostContent,PostDate")] Post post)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        #endregion

        #region Delete

        // GET: Database/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Database/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Exists

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }

        #endregion

    }
}
