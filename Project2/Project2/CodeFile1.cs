static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");
    // Этот конструктор принимает год, месяц и день.
    DateTime dt = new DateTime(2011, 10, 17);
    // Какой это день месяца?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    // Сейчас месяц декабрь.
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
    // Этот конструктор принимает часы, минуты и секунды.
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);
    // Вычесть 15 минут иэ текущего TimeSpan и вывести результат.
    Console.WriteLine(ts.Subtract(newTimeSpan(0, 15, 0)));
}
