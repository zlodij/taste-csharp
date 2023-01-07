public class RomanConverter
{
    public String IntToRoman(int num)
    {
        String units = DigitToRoman(num, "I", "V", "X");
        num /= 10;
        String dozens = DigitToRoman(num, "X", "L", "C");
        num /= 10;
        String hundreds = DigitToRoman(num, "C", "D", "M");
        num /= 10;
        String thousands = DigitToRoman(num, "M", "M", "M");
        num /= 10;

        return thousands + hundreds + dozens + units;
    }

    private String DigitToRoman(int num, String min, String mid, String max)
    {
        int rest = num % 10;

        String roman = "";
        switch (rest)
        {
            case 1:
                roman = min;
                break;
            case 2:
                roman = min + min;
                break;
            case 3:
                roman = min + min + min;
                break;
            case 4:
                roman = min + mid;
                break;
            case 5:
                roman = mid;
                break;
            case 6:
                roman = mid + min;
                break;
            case 7:
                roman = mid + min + min;
                break;
            case 8:
                roman = mid + min + min + min;
                break;
            case 9:
                roman = min + max;
                break;
        }

        return roman;
    }
}