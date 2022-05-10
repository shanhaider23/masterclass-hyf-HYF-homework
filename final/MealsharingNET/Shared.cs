
public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ?
   "Server=localhost;Database=meal_application;Uid=root;Pwd=sadia572;Convert Zero Datetime=True" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}