namespace myarealib
{
    public class myarea
    {
        public int area(int a, int b, int c)
        //площадь поверхности параллелепипеда

        {
            int s = -1;
            if ((a >= 0) && (b >= 0) && (c >= 0))
            {
                s = 2 * ((a * b) + (a * c) + (b * c));
            }
            return s;
        }
    }
}