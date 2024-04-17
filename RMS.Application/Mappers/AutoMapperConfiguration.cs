using AutoMapper;
using RMS.Application.Requests.CustomerRequests;
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
            CreateMap<Customer, CustomerResponseModel> ();
            CreateMap<UpdateCustomerRequestModel, Customer>();

            CreateMap<CreateMenuItemRequestModel, MenuItem>();
            CreateMap<MenuItem, MenuItemResponseModel>();
            CreateMap<UpdateMenuItemRequestModel, MenuItem>();


            CreateMap<CreateOrderRequestModel, Order>();
            CreateMap<Order, OrderResponseModel>();
            CreateMap<UpdateOrderRequestModel, Order>();

            CreateMap<CreateOrderItemRequestModel, OrderItem>();
            CreateMap<OrderItem, OrderItemReponseModels>();
            CreateMap<UpdateOrderRequestModel, OrderItem>();

            CreateMap<CreatePaymentRequestModel, Payment>();
            CreateMap<Payment, PaymentResponseModel>();
            CreateMap<UpdateOrderRequestModel, Payment>();

            CreateMap<CreateReservationRequestModel, Reservation>();
            CreateMap<Reservation, ReservationResponseModel>();
            CreateMap<UpdateReservationRequestModel, Reservation>();

            CreateMap<CreateTableRequestModel, Table>();
            CreateMap<Table, TableResponseModel>();
            CreateMap<UpdateTableRequestModel, Table>();
        }
    }
}
