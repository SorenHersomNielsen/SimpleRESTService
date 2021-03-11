﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRESTService.Model
{
    public class Beer
    {
        public Beer(int Id, string Name, int Price, int Abv)
        {
            CheckName(Name);
            CheckPrice(Price);
            CheckAbv(Abv);

            id = Id;
            name = Name;
            price = Price;
            abv = Abv;
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { CheckName(value); name = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { CheckPrice(value); price = value; }
        }

        private int abv;

        public int Abv
        {
            get { return abv; }
            set { abv = value; }
        }


        private static void CheckName(string Name)
        {
            if (Name.Length < 4)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static void CheckPrice(int Price)
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static void CheckAbv(int Abv)
        {
            if (Abv <= 0 || Abv >= 100)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}