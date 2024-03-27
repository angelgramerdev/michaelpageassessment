using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class ObjResponse
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public int Code { get; set; }
        public List<User> Users { get; set; }
        public User user { get; set; }

    }
}
