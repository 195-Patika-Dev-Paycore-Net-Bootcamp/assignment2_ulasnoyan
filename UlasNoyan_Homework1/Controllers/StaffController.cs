
using Microsoft.AspNetCore.Mvc;

namespace UlasNoyan_Homework2
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        /*
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public double Salary { get; set; }
    
        */






        //Liste mekaniğini implement edemedim sanırım yazış stilimde problem var haftaki ödevde öğrenmiş ve düzeltmiş olma umuduyla...









        [HttpGet("get staff information")]
        public List<Staff> get()
        {
            List<Staff> staffs = new List<Staff>();
            return new List<Staff>();
        }
        [HttpPut]
        public void Put([FromBody] Staff a)
        {

        }

        [HttpDelete]
        public void Delete([FromBody] Int32 Id)
        {

        }



        [HttpPost("Get Staff Information")]
        public void Post([FromBody] Staff a)
        {
      
        }
    }
}

