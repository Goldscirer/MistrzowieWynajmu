﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MistrzowieWynajmu.Models.Interfaces
{
    interface IAddressRepository
    {
        int AddAddress(Address address);
        Address GetAddress(int addressId);
    }
}
