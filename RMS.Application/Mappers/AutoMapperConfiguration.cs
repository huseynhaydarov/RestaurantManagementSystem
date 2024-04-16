using AutoMapper;
using RMS.Application.Requests.CustomerRequests;
using RMS.Application.Requests.MenuItemRequestModel;
using RMS.Application.Requests.OrderItemsRequests;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Requests.PaymentRequests;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Requests.TableRequests;
using RMS.Application.Responses.CustomerResponses;
using RMS.Application.Responses.MenuItemResponses;
using RMS.Application.Responses.OrderItemResponses;
using RMS.Application.Responses.OrderResponses;
using RMS.Application.Responses.PaymentResponses;
using RMS.Application.Responses.ReservationResponses;
using RMS.Application.Responses.TableResponses;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Mappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration() 
        {
            CreateMap<CreateCustomerRequestModel, Customer>();
            CreateMap<Customer, CustomerResponseModel>();
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
