if (n.ToString() == "")
                return false;
            else
            {
                for (int i = 0; i <= 99; i++)
                {
                    Console.WriteLine($"{Math.Pow(2, i)}");
                    double pow = Math.Pow(2, i);
                    if (pow == n)
                        return true;
                }
                return false;
            }