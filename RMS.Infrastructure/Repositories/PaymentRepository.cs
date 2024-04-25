﻿using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using RMS.Infrastructure.Persistence.DataBases;
using RMS.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repositories;
public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(EFContext context) : base(context)
    {
    }
}