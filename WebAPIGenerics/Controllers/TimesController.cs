using System.Linq;
using System.Web.Http;
using WebAPIGenerics.Models;
using WebAPIGenerics.Utils;

namespace WebAPIGenerics.Controllers
{
    public class TimesController : ApiController
    {
        Context _context = new Context();

        //public TimesController(Context context)
        //{
        //    this._context = context;
        //}
        /// <summary>
        /// Retorna a lista de jogadores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult Get()
        {
            var model = _context.Times.ToList();
            return Ok(model);
        }
        [HttpGet]
        public IHttpActionResult Edit(int id)
        {
            Time t = _context.Times.Where(x => x.TimeID == id).SingleOrDefault();
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }

        /// <summary>
        /// Retorna a lista de jogadores com paginação
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetListWithPaging(int pageSize, int page)
        {
            int skip = (pageSize - 1) * page;
            int total = _context.Times.Count();
            var userFilterPaging = _context.Times
                .OrderBy(c => c.TimeID)
                .Skip(skip)
                .Take(page)
                .ToList();

            return Ok(new Paginacao<Time>(userFilterPaging, pageSize, page, total));

        }

        [HttpPut]
        public IHttpActionResult EditById(Time time)
        {
            Time t = _context.Times.Where(x => x.TimeID == time.TimeID).SingleOrDefault();
            if (t == null)
            {
                return NotFound();
            }
            t.TimeID = time.TimeID;
            t.Nome = time.Nome;
            
            _context.SaveChanges();///
            return Ok();

        }


        [HttpPost]
        public IHttpActionResult Post(Time time)
        {
            Time t = new Time();
            t.Nome = time.Nome;
            
            _context.Times.Add(time);

            _context.SaveChanges();

            

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Time time = _context.Times.Where(x => x.TimeID == id).SingleOrDefault();
            if (time == null)
            {
                return NotFound();
            }
            _context.Times.Remove(time);
            _context.SaveChanges();

            return Ok();
        }


    }
}
