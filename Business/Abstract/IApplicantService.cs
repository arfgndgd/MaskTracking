using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //interface içinde sadece metod imzası oluşturulur, metod içeriği verilmez
    public interface IApplicantService
    {
        //encapsulation --> Özellikleri alıp bir classın içine koyup onları kapsülleme ve sonrasında istediğin şekilde kullanma
        void ApplyForMask(Citizen citizen); //maske başvurusu

        List<Citizen> GetList();

        bool CheckCitizen(Citizen citizen);
    }
}
