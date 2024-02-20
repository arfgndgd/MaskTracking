using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        //encapsulation --> Özellikleri alıp bir classın içine koyup onları kapsülleme ve sonrasında istediğin şekilde kullanma
        public void ApplyForMask(Citizen citizen) //maske başvurusu
        {

        }

        public List<Citizen> GetList()
        {
            return null;
        }

        public bool CheckCitizen(Citizen citizen)
        {
            //mernis kontrolü yapılacak
            return true;
        }
    }

}
