namespace MiladiToShamsi
{
    public static class Class1
    {
        public static string convertDate(this DateTime miladiDate)
        {
            string shamsiStart = "0001/01/01";
            string miladiStart = "0622/03/22";
            int days = 0;

            if (miladiDate >= Convert.ToDateTime(miladiStart))
            {
                days = (Convert.ToDateTime(miladiDate) - Convert.ToDateTime(miladiStart)).Days;
            }
            else
            {
                return "invalid date";
            }

            //year
            string YearShamsi = (days / 365).ToString();

            //decrease kabiseh days
            days -= 1096;
            days = (days % 1461) % 365;
            //add 11 days!
            days += 11;
            string MonthShamsi = "";
            int dayShamsi = 0;
            switch (days)
            {
                case 0:
                    MonthShamsi = "12";
                    dayShamsi = 29;
                    break;
                case 365:
                    MonthShamsi = "12";
                    dayShamsi = 30;
                    break;
                case >= 336:
                    MonthShamsi = "12";
                    dayShamsi = (days) - 335;
                    break;
                case >= 306:
                    MonthShamsi = "11";
                    dayShamsi = (days) - 305;
                    break;
                case >= 276:
                    MonthShamsi = "10";
                    dayShamsi = (days) - 275;
                    break;
                case >= 246:
                    MonthShamsi = "09";
                    dayShamsi = (days) - 245;
                    break;
                case >= 216:
                    MonthShamsi = "08";
                    dayShamsi = (days) - 215;
                    break;
                case >= 186:
                    MonthShamsi = "07";
                    dayShamsi = (days) - 185;
                    break;
                case >= 155:
                    MonthShamsi = "06";
                    dayShamsi = (days) - 154;
                    break;
                case >= 124:
                    MonthShamsi = "05";
                    dayShamsi = (days) - 123;
                    break;
                case >= 93:
                    MonthShamsi = "04";
                    dayShamsi = (days) - 92;
                    break;
                case >= 62:
                    MonthShamsi = "03";
                    dayShamsi = (days) - 61;
                    break;
                case >= 31:
                    MonthShamsi = "02";
                    dayShamsi = (days) - 30;
                    break;
                case >= 1:
                    MonthShamsi = "01";
                    dayShamsi = (days);
                    break;
                default:
                    break;
            }
            string shamsiDate = YearShamsi + "/" + MonthShamsi + "/" + dayShamsi.ToString();
            return shamsiDate;

        }
    }
}