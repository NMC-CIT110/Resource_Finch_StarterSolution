﻿using FinchAPI;
using System;

namespace Finch_Starter
{
    class Program
    {
        // *************************************************************
        // Application:     Finch Starter Solution
        // Author:          Velis, John E
        // Description:
        // Date Created:    5/20/2016
        // Date Revised:    9/22/2016
        // *************************************************************

        static void Main(string[] args)
        {
            //
            // create a new Finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //
            // call the connect method
            //
            myFinch.connect();
            
            //
            // begin your code
            //

            //
            //end of your code
            //

            //
            // call the disconnect method
            //
            myFinch.disConnect();
        }
    }
}
