using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
namespace PRUEBA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<modelo.mascota> lst = new List<modelo.mascota>();
            using (var db = new MySqlConnection("Server=localhost; Database=pruebasiesa; Uid=root;"))
            {
                var sql = "select * from mascota";
                lst = db.Query<modelo.mascota>(sql).ToList();
            }
            string jsonString = JsonConvert.SerializeObject(lst);
            return Ok(jsonString);
        }
    }
}
