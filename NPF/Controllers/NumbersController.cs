using NPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;
using Newtonsoft.Json;

namespace NPF.Controllers

{
    public class NumbersController : ApiController
    {
        // GET: api/Numbers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Numbers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Numbers
        public Root Post([FromBody] Numbers value)
        {

            Root root = new Root();

            List<Result> lista = new List<Result>();

            foreach (var number in value.numbers)
            {
                

                if ((int.Parse(number) % 11 == 0))
                {

                    Result result = new Result();


                    result.isMultiple = true;
                    result.number = number;
                    lista.Add(result);
                    
                    
                 }

                else
                {

                    Result result = new Result();


                    result.isMultiple = false;
                    result.number = number;
                    lista.Add(result);


                }

            }

            root.result = lista;

            return root;


        }

        // PUT: api/Numbers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Numbers/5
        public void Delete(int id)
        {
        }
    }
}
