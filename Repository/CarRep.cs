using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRep
    {
        public void AddNew(CarsTable carsTable)
        {
          using (TransportationCompanyContext ctx = new TransportationCompanyContext())
            { 
                 ctx.CarsTables.Add(carsTable);
                ctx.SaveChanges();
            }
               
        }

        public  List<CarsTable> GetAll()
        {
            using (TransportationCompanyContext ctx = new TransportationCompanyContext())
            { 
                return ctx.CarsTables.ToList();    

            }
               
        }

    }

    
}
