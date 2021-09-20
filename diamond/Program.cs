using System;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = 7;
            //char Ch = 'A';
            //int row = 0;
            //int step = 1;

            int width = 7;
            char Ch = 'A';
            int row = 0;
            int step = 1;

            Console.WriteLine("-----------------FOR_TWO----------------");
            for (int i = 0; i < width; i++)
                write_mirror_for_two(width, 'A', i);
            for (int i = width - 2; i >= 0; i--)
                write_mirror_for_two(width, 'A', i);

            Console.WriteLine("-----------------FOR_ONE----------------");
            for (int i = 0; i < width; i++)
                write_mirror_for_one(width, 'A', i);
            for (int i = width - 2; i >= 0; i--)
                write_mirror_for_one(width, 'A', i);

            Console.WriteLine("----------------WHILE----------------");

            for (int i = 0; i < width; i++)
                write_mirror_while(width, 'A', i);
            for (int i = width - 2; i >= 0; i--)
                write_mirror_while(width, 'A', i);

            Console.WriteLine("----------------RECUR----------------");

            process_diamond(width, Ch, row, step);
        }

        static void process_diamond(int width, char c, int row, int rstep)
        {
            write_mirror_while(width, c, row);

            if (width - row - 1 > 0 && rstep == 1)
                process_diamond(width, c, row + rstep, 1);

            if (width - row - 1 == 0 && rstep == 1)
                process_diamond(width, c, row - 1, -1);

            if (width - row - 1 < width && rstep == -1)
                process_diamond(width, c, row - 1, -1);

            if (width - row - 1 == width && rstep == -1)
                return;

        }

        static void write_mirror_for_two(int width, char c, int row)
        {
            for (int i = 0; i < width; i++)
            {
                int sub = i - width + row;
                if ((c + sub) < c)
                    Console.Write(' ');
                else
                    Console.Write((char)(c + sub));
            }
            for (int i = width; i >= 0; i--)
            {
                int sub = i - width + row;
                if ((c + sub) < c)
                    Console.Write(' ');
                else
                    Console.Write((char)(c + sub));
            }

            Console.WriteLine();
        }

        static void write_mirror_for_one(int width, char c, int row)
        {
            int step = 1;
            for (int i = 0; i >= 0; i += step)
            {
                int sub = i - width + row;
                if ((c + sub) < c)
                    Console.Write(' ');
                else
                    Console.Write((char)(c + sub));

                if (i == width)
                    step = -1;
            }

            Console.WriteLine();
        }

        static void write_mirror_while(int width, char c, int row)
        {
            int k = 0;
            int step = 1;
            while (k >= 0)
            {
                int sub = k - width + row;
                if ((c + sub) < c)
                    Console.Write(' ');
                else
                    Console.Write((char)(c + sub));

                if (k == width)
                    step = -1;
                k += step;
            }

            Console.WriteLine();
        }
    }
}
