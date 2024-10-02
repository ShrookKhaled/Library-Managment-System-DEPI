namespace Library_DEPI.Controllers
{
    public class GenresController : Controller
    {
        private readonly IGenreServices _genreServices;

        public GenresController(IGenreServices genreServices)
        {
            _genreServices = genreServices;
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            return View(_genreServices.GetAll());
        }

        // GET: Genres/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _genreServices.GetOne(id);
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // GET: Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Genre genre)
        {
            if (_genreServices.ExistsByName(genre.Name)) // تحقق إذا كان الاسم موجود
            {
                ModelState.AddModelError("Name", "This genre name already exists. Please choose a different name.");
            }

            if (ModelState.IsValid)
            {
                _genreServices.create(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _genreServices.GetOne(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Genre genre)
        {
            if (id != genre.Id)
            {
                return NotFound();
            }

            if (_genreServices.ExistsByName(genre.Name, id)) // تحقق إذا كان الاسم موجود
            {
                ModelState.AddModelError("Name", "This genre name already exists. Please choose a different name.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _genreServices.Update(id, genre);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_genreServices.IsExist(genre.Id))
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
            return View(genre);
        }

        // GET: Genres/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = _genreServices.GetOne(id);
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genre = _genreServices.GetOne(id);
            if (genre != null)
            {
                _genreServices.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        
    }
}
