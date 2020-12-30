using ApiData;
using ApiEntitty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiBusiness
{
    public class Class1
    {

        public List<employees> mmx()
        {
            List<employees> employees = null;

              using (ApplicationDbContext context = new ApplicationDbContext())
            {
                 employees= context.tb_employees.ToList();// .Include(x => x.id).ToList();
            }

          return employees;
        }

    }
}
