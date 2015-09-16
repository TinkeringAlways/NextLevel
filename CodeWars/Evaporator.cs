namespace Deodorant_Evaporator
{
    public class Evaporator
    {

        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            int day = 0;
            double percent_left = 1;
            evap_per_day = (evap_per_day / 100);
            threshold = (threshold / 100);

            while (percent_left >= threshold)
            {
                percent_left = percent_left - (percent_left * evap_per_day);
                day++;
            }

            return day;
        }
    }
}