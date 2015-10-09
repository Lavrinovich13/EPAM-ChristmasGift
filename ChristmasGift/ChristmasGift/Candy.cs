﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum CandyTypes 
    { 
        Fondant, 
        Fruit, 
        Jelly, 
        Marzipan,
        Pralines, 
        Roasting,
        Cream,
        Liqueur }


    class Candy : Sweetness
    {
        private bool isCoveredWithChocolate;
        private CandyTypes candyType;
        private WrapperTypes wrapperType;
    }
}
