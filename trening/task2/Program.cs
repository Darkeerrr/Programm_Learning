﻿Console.WriteLine("Вес гирек: ");
Random rnd = new Random();
int girka1 = rnd.Next(1, 100); Console.WriteLine(girka1);
int girka2 = rnd.Next(1, 100); Console.WriteLine(girka2);
int girka3 = rnd.Next(1, 100); Console.WriteLine(girka3);
int girka4 = rnd.Next(1, 100); Console.WriteLine(girka4);
int max = girka1;
if (girka1 > max) max = girka1;
if (girka4 > max) max = girka4;
if (girka3 > max) max = girka3;
if (girka2 > max) max = girka2;
Console.Write("Тяжелющая гирища: " + max);
