using ApiData;
using ApiEntitty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ApiBusiness
{
    public class LogicEmployees
    {

        public List<employees> GetAllEmployees()
        {
            List<employees> employees = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                employees = context.tb_employees.ToList();
            }

            return employees;
        }


        public employees SaveEmployees(employees value)
        {
            employees data = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                data = new employees { 
                employee_name = value.employee_name,
                employee_salary = value.employee_salary,
                employee_age = value.employee_age,
                profile_image = value.profile_image
                };

                context.tb_employees.Add(data);              
               int iResult= context.SaveChanges();
            }

            return data;
        }


        public employees UpdateEmployees(employees value)
        {
            employees data = null;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                data = context.tb_employees.Find(value.id);
                if (data == null)
                {
                    throw new Exception("Id Employees value not found");
                }


                data.employee_name = value.employee_name;
                data.employee_salary = value.employee_salary;
                data.employee_age = value.employee_age;
                data.profile_image = value.profile_image;

                context.tb_employees.Update(data);
             //   context.Entry(entity).CurrentValues.SetValues(data);

              //  int iResult = context.SaveChanges();
            }

            return data;
        }





    }
}
