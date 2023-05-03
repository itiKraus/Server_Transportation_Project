using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarServices
    {
        public void AddNew(CarsTable carsTable )
        {
            new Repository.CarRep().AddNew(carsTable);
        }

        public List<Repository.Models.CarsTable> GetAll()
        {
            Repository.CarRep carRep = new ();
        return carRep.GetAll ();
        }
    }
}
