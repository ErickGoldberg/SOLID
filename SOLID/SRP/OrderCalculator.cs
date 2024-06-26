﻿namespace SOLID.SRP
{
    public class OrderCalculator
    {
        public decimal CalculateTotal(Order order)
        {
            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.Quantity + item.Price;
            }

            return total;
        }
    }

}
