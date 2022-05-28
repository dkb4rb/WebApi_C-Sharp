using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using API.Results;
using System.Data.SqlClient;
using System.Xml;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerrsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OwnerrsController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Countries as paginated result.
        /// </summary>
        /// <param name="SearchCriteria">Texto de búsqueda.</param>
        /// <param name="SortField">Nombre de campo por el cual ordenar (distingue mayúsculas).</param>
        /// <param name="SortType">Tipo de orden: ASC (ascendente) / DESC (descendente).</param>
        /// <param name="CurrentPage">Número de página a obtener.</param>
        /// <param name="RecordsPerPage">Número de registros por página.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Solicitud incorrecta</response>
        /// <response code="401">No tiene acceso al recurso. Autenticación requerida.</response>
        /// <response code="404">No existen datos para mostrar o no tiene permiso de acceso</response>
        /// <returns></returns>

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));
        }

        // GET: api/Ownerrs
        [HttpGet]
        public DefaultResult<Ownerr> GetOwnerr()
        {
            List<Ownerr> own;
            
            DefaultResult<Ownerr> _OwnResult;

            own = _context.Ownerr.ToList();


            string ConnectionString = "Server=DESKTOP-HMI7REM; Database=WebApi; Trusted_Connection=True; MultipleActiveResultSets=True;";

            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = $"SELECT * FROM Property ";
            

            SqlCommand cmd = new SqlCommand(Query, connection);
           
                connection.Open();
            SqlDataReader v = cmd.ExecuteReader();

            while (v.Read()) {
                
            }

            _OwnResult = new DefaultResult<Ownerr>()
            {
                CurrentPage = 1,
                CurrentSort = "doce",
                CurrentSearch = "",
                CurrentSortType = "",
                RecordsPerPage = 1,
                TotalRecords = 1,
                TotalPages = 2,
                Resultt = v,

                Result = own
            };

            return _OwnResult;

        }

        // GET: api/Ownerrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ownerr>> GetOwnerr(int id)
        {
            var ownerr = await _context.Ownerr.FindAsync(id);

            if (ownerr == null)
            {
                return NotFound();
            }

            return ownerr;
        }

        // PUT: api/Ownerrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOwnerr(int id, Ownerr ownerr)
        {
            if (id != ownerr.idOwner)
            {
                return BadRequest();
            }

            _context.Entry(ownerr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnerrExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ownerrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public dynamic PostOwnerr([FromBody] OwnerrItem ownerr)
        {
            try
            {
                Ownerr own;
                own = new()
                {
                    Name = ownerr.Name,
                    Address = ownerr.Address,
                    Birthday = ownerr.Birthday,
                    Photo = ownerr.Photo
                };

            _context.Ownerr.Add(own);
                _context.SaveChangesAsync();
                ownerr.idOwner = own.idOwner;
                return CreatedAtAction("GetOwnerr", ownerr);
            }
            catch (Exception) {
                return BadRequest();
            }
        }

        // DELETE: api/Ownerrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwnerr(int id)
        {
            var ownerr = await _context.Ownerr.FindAsync(id);
            if (ownerr == null)
            {
                return NotFound();
            }

            _context.Ownerr.Remove(ownerr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OwnerrExists(int id)
        {
            return _context.Ownerr.Any(e => e.idOwner == id);
        }
    }
}
