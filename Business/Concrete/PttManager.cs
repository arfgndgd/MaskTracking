using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor --> Class newlendiğinde çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {
            //YANLIŞ
            //iş sınıflarında başka bir iş sınıfı kullanılıyorsa uygulama direnç gösterir.
            //CitizenManager sınıfına artık bağımlıyız bu yanlış bir durum.
            //Vatandaşlığı olmayan birine maske vermek sıkıntı doğurur bu newleme durumunda
            //Bunun için Abstract altında interface class  oluşturacağız.
            //MEŞELA HAREKATI

            //YANLIŞ
            //CitizenManager citizenManager = new CitizenManager();
            //if (citizenManager.CheckCitizen(citizen))
            //{
            //    Console.WriteLine(citizen.FirstName + " için maske verildi");
            //}

            if (_applicantService.CheckCitizen(citizen))
            {
                Console.WriteLine(citizen.FirstName + " için maske verildi");
            } else
            {
                Console.WriteLine(citizen.FirstName + " için maske verilmedi");
            }
        }
    }
}
