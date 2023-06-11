using System;
	public class Date
	{
		private int year;
		private int months;
		private int day;

		public Date(int year,int months,int day)
		{
			this.year = year;
			this.months = months;
			this.day = day;
		}
        public override string ToString()
        {
            return $"{GetMonthName(months)} {day}, {year}";
        }
		public void Add(int day)
		{
            day += day;
            Normalize();
        }
		public void Add (int moths,int days)
		{
            months += months;
            day += days;
            Normalize();
		}
        public void Add(Date other)
        {
            year += other.year;
            months += other.months;
            day += other.day;
            Normalize();
        }

        private void Normalize()
        {
            if (day > GetDaysInMonth(months))
            {
                day -= GetDaysInMonth(months);
                months++;
            }

            if (months > 12)
            {
                months -= 12;
                year++;
            }
        }

        private string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Invalid Month";
            }
        }

        private int GetDaysInMonth(int month)
        {
            switch (month)
            {
                case 2:
                    if (IsLeapYear())
                        return 29;
                    else
                        return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        private bool IsLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }



