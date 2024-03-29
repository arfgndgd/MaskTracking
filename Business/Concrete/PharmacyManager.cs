﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService) //Constructor
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {
            if (_applicantService.CheckCitizen(citizen))
            {
                Console.WriteLine(citizen.FirstName + " için maske verildi.");
            }
        }
    }
}
