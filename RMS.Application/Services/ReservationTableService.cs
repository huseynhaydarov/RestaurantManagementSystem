using AutoMapper;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Application.Common.Interfaces.Services;
using RMS.Application.Exceptions;
using RMS.Application.Requests.ReservationRequests;
using RMS.Application.Requests.TableRequests;
using RMS.Application.Responses.ReservationResponses;
using RMS.Application.Responses.TableResponses;
using RMS.Domain.Entities;

namespace RMS.Application.Services;

public class ReservationTableService(IReservationTableRepository reservationTableRepository, IMapper mapper) : IReservationTableService
{
    public async Task<ReservationTableResponse> CreateAsync(CreateTableRequestModel request,
        CancellationToken token = default)
    {
        var reservationTable = mapper.Map<Table>(request);
        var response = await reservationTableRepository.CreateAsync(reservationTable, token);
        return mapper.Map<ReservationTableResponse>(response);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var reservationTable = await reservationTableRepository.GetAsync(id, token);

        if (reservationTable is null)
        {
            throw new NotFoundException(nameof(reservationTable), id);
        }
        return await reservationTableRepository.DeleteAsync(reservationTable, token);
    }

    public async Task<List<ReservationTableResponse>> GetAllAsync(CancellationToken token = default)
    {
        var response = await reservationTableRepository.GetAllAsync(token);
        return mapper.Map<List<ReservationTableResponse>>(response);
    }

    public async Task<ReservationTableResponse?> GetAsync(int id, CancellationToken token = default)
    {
        var response = await reservationTableRepository.GetAsync(id, token);

        if (response is null)
        {
            throw new NotFoundException(nameof(Reservation), id);
        }

        return mapper.Map<ReservationTableResponse>(response);
    }

    public async Task<bool> UpdateAsync(UpdateTableRequestModel request, CancellationToken token = default)
    {
        var reservationTable = await reservationTableRepository.GetAsync(request.Id, token);

        if (reservationTable is null)
        {
            throw new NotFoundException(nameof(Table), request.Id);
        }

        reservationTable = mapper.Map<Table>(request);
        return await reservationTableRepository.UpdateAsync(reservationTable, token);
    }
}
