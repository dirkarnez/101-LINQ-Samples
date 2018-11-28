﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace ProjectionOperators
{
    public partial class LinqSamplesProjectionOperators
    {
        //Projection Operators
        //This sample uses select to return a sequence of just the names of a list of products.
        public void DataSetLinq7()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var productNames =
                       from p in products
                       select p.Field<string>("ProductName");

                Console.WriteLine("Product Names:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                } 

            #endregion
        }

        // Linq with expression
        public void DataSetLinq7A()
        {
            var products = testDS.Tables["Products"].AsEnumerable();

            #region  Make Sure to try yourself before looking at the code

                var productNames = products.Select(name => name.Field<string>("ProductName"));

                Console.WriteLine("************************************************");
                Console.WriteLine("Product Names:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }

            #endregion
        }
    }
}
