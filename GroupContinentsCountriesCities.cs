﻿using System;
using System.Collections.Generic;

namespace GroupContinentsCountriesCities
{
    public class GroupContinentsCountriesCities
    {
        public static void Main()
        {
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                    if (!continentsData[continent].ContainsKey(country))
                    {
                        continentsData[continent][country] = new SortedSet<string>();
                    }

                continentsData[continent][country].Add(city);
            }

            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;

                    Console.WriteLine(" {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}
