using System.Web.Http;
using WebAPIGenerics.Utils;
using WebAPIGenerics.Service;



namespace WebAPIGenerics.Controllers
{
    public class TimesController : ApiController
    {
        Services<Entidade.Time> _service = new Services<Entidade.Time>();
        
        [HttpGet]
        public IHttpActionResult Get()
        {
            var model = _service.ListAll();
            return Ok(model);
        }
        [HttpGet]
        public IHttpActionResult Edit(int id)
        {
            Entidade.Time t = _service.findById(id);
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
            int total = _service.Count();
            var userFilterPaging = _service.ListWithPaging(pageSize, page);

            return Ok(new Paginacao<Entidade.Time>(userFilterPaging, pageSize, page, total));

        }

        [HttpPut]
        public IHttpActionResult EditById(Entidade.Time time)
        {
            Entidade.Time t = _service.findById(time.TimeID);
            if (t == null)
            {
                return NotFound();
            }
            _service.update(t);
            return Ok();
        }


        [HttpPost]
        public IHttpActionResult Post(Entidade.Time time)
        {
            _service.save(time);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Entidade.Time time = _service.findById(id);
            if (time == null)
            {
                return NotFound();
            }
            _service.delete(time);

            return Ok();
        }
    }
}
