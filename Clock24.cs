using System;
using System.Text;
using CustomExceptions;
public class Clock24Hrs
{
    private int hours, minutes, seconds;

    public Clock24Hrs(int hh, int mm, int ss) 
    {
        if (hh < 0 || hh > 23 ){
            string str = String.Format("{0}: Invalid value of hours", hh);
            throw new ClockException(str);
        }
        if (mm < 0 || mm > 59)
        {
            string str = String.Format("{0}: Invalid value of minutes", mm);
            throw new ClockException(str);
        }
        if (ss < 0 || ss > 59)
        {
            string str = String.Format("{0}: Invalid value of seconds", ss);
            throw new ClockException(str);
        }
        this.hours = hh;
        this.minutes = mm;
        this.seconds = ss;
    }

    public override string ToString()
    {
        return(String.Format("hr:min:sec {0}:{1}:{2} ",
           hours, minutes, seconds));
     
    }

    public static void Main(string[] arg)
    {
        int[] hours = { 23, 10, 7, 0, -4, 12, 35 };
        int[] minutes = { 23, 0, 59, -88, 54, 65, 6 };
        int[] seconds = { 45, 14, 59, 32, 17, -59, 60 };

        int sz = hours.Length;
        List<Clock24Hrs> clocks = new List<Clock24Hrs>();

        for (int i = 0; i <= sz; i++)
        {
            try
            {
                Clock24Hrs clock = new Clock24Hrs(hours[i], minutes[i], seconds[i]);
                clocks.Add(clock);
            }
            catch (ClockException clkEx)
            {
                Console.WriteLine("Exception for index {0}: {1}",
                        i, clkEx.Message);
            }
            catch (Exception ex) //Chaining exceptions
            {
                Console.WriteLine("Exception for index {0}: {1}",
                        i, ex.Message);
            }
        }

        foreach (Clock24Hrs clk in clocks)
        {
            Console.WriteLine(clk);
        }

    }

}
