using AutoMapper;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Requests.PaymentRequests;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Requests.TableRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Mappers
{
    internal class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration() 
        {
            CreateMap<CreateCustomerRequestModel, Customer>();
            CreateMap<CustomerResponseModel, Customer>();
            CreateMap<UpdateCustomerRequestModel, Customer>();

            CreateMap<CreateMenuItemRequestModel, MenuItem>();
            CreateMap<MenuItemRequestModel, MenuItem>();
            CreateMap<UpdateMenuItemRequestModel, MenuItem>();

            CreateMap<CreateOrderRequestModel, Order>();
            CreateMap<OrderRequestModel, Order>();
            CreateMap<UpdateOrderRequestModel, Order>();

            CreateMap<CreateOrderItemRequestModel, OrderItem>();
            CreateMap<OrderItemRequestModel, OrderItem>();
            CreateMap<UpdateOrderRequestModel, OrderItem>();

            CreateMap<CreatePaymentRequestModel, Payment>();
            CreateMap<PaymentRequestModel, Payment>();
            CreateMap<UpdateOrderRequestModel, Payment>();

            CreateMap<CreateReservationRequestModel, Reservation>();
            CreateMap<ReservationRequestModel, Reservation>();
            CreateMap<UpdateReservationRequestModel, Reservation>();

            CreateMap<CreateTableRequestModel, Table>();
            CreateMap<TableRequestModel, Table>();
            CreateMap<UpdateTableRequestModel, Table>();
        }
    }
}
