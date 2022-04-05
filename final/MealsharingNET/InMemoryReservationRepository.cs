//using MealsharingNET.Models;
//namespace MealsharingNET;

//public class InMemoryReservationRepository : IReservationRepository
//{
//   private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
//      new Reservation(){ ID = 1, MealID = 2, Name = "Shan", Email = "shan@gmail.com", Date = "12/5/2022", NoOfPersons = 5},
//      new Reservation(){ID = 2, MealID = 1, Name = "Haider", Email = "haider@gmail.com", Date = "15/4/2022", NoOfPersons = 20},
//     new Reservation(){ ID = 3, MealID = 3, Name = "Jon", Email = "jon@gmail.com", Date = "25/6/2022", NoOfPersons = 10},
// };

//    public IEnumerable<Reservation> ReservationList()
//  {
//    return Reservations;
// }

//    public void AddReservation(Reservation resrvstion)
//  {
//    Reservations.Add(resrvstion);
//}

//    public Reservation FindReservationById(int id)
//  {
//    return Reservations.SingleOrDefault(r => r.ID == id);
//}

//    public IEnumerable<Reservation> FindResrvationByMealId(int mealId)
//  {
//    return Reservations.Where(r => r.MealID == mealId);
// }

//    Task<IEnumerable<Reservation>> IReservationRepository.ReservationList()
//  {
//     throw new NotImplementedException();
// }

//    Task IReservationRepository.AddReservation(Reservation reservation)
//  {
//     throw new NotImplementedException();
// }

// Task<Reservation> IReservationRepository.FindReservationById(int id)
// {
//     throw new NotImplementedException();
// }
//}