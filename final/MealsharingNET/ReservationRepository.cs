using MealsharingNET.Models;
namespace MealsharingNET;

using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

public class ReservationRepository : IReservationRepository
{
    public async Task AddReservation(Reservation reservation)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.ExecuteAsync("INSERT INTO reservations (id, number_of_guests, meal_id, created_date, email, phone, name) VALUES ( @ID , @NoOfPersons, @MealID, @Date,   @Email, @Phone, @Name ) ", reservation);
    }

    public async Task<Reservation> FindReservationById(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservation = await connection.QueryFirstAsync<Reservation>("SELECT id, number_of_guests as NoOfPersons, meal_id, created_date, email, phone, name FROM reservations WHERE ID=@Id", id);
        return reservation;
    }



    public async Task<IEnumerable<Reservation>> ReservationList()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservation>("SELECT id, number_of_guests as NoOfPersons, meal_id, created_date, email, phone, name FROM reservations");
        return reservations;
    }


}