﻿using Nop.Plugin.Payments.PayPalExpressCheckout.Models;

namespace Nop.Plugin.Payments.PayPalExpressCheckout.Services
{
    public interface IPayPalExpressCheckoutPlaceOrderService
    {
        CheckoutPlaceOrderModel PlaceOrder();
    }
}