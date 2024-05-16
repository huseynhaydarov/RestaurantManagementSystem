using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.OrderRequests;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Responses.OrderResponses;
using RMS.Application.Responses.ReservationResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class ReservationService(IReservationRepository reservationRepository, IMapper mapper) : IReservationService
{
    public async Task<ReservationResponse> CreateAsync(CreateReservationRequestModel request,
        CancellationToken token = default)
    {
        var reservation = mapper.Map<Reservation>(request);
        var response = await reservationRepository.CreateAsync(reservation, token);
        return mapper.Map<ReservationResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservation = await reservationRepository.GetAsync(id, token);

        if (reservation is null)
        {
            throw new NotFoundException(nameof(reservation), id);
        }
        return await reservationRepository.DeleteAsync(reservation, token);
    }

    public async Task<List<ReservationResponse>> GetAllAsync(CancellationToken token = default)
    {
        var response = await reservationRepository.GetAllAsync(token);
        return mapper.Map<List<ReservationResponse>>(response);
    }

    public async Task<ReservationResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await reservationRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(Reservation), id);
        }

        return mapper.Map<ReservationResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateReservationRequestModel request, CancellationToken token = default)
    {
        var reservation = await reservationRepository.GetAsync(request.Id, token);

        if (reservation is null)
        {
            throw new NotFoundException(nameof(Reservation), request.Id);
        }

        reservation = mapper.Map<Reservation>(request);
        return await reservationRepository.UpdateAsync(reservation, token);
    }
}
