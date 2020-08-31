using System;
using System.Drawing;
using System.Text;

namespace Password_Generator
{
    class Program
    {
        class PasswordGenerator
        {
            private int _size;

            public PasswordGenerator(int size)
            {
                this._size = size;
            }

            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                var result = random.Next(min, max);

                return result;
            }
            public string RandomString ()
            {
                StringBuilder builder = new StringBuilder();
                Random random = new Random();

                char ch;
                for (int i = 0; i < this._size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                return builder.ToString();
            }

            public string Password ()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(this.RandomString());
                builder.Append(this.RandomNumber(1000, 9999));
                var result = builder.ToString().ToLower();
                return result;
            }
        }

        static void Main(string[] args)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator(10);

            Console.WriteLine("Your new password is: {0}", passwordGenerator.Password());
        }
    }
}
