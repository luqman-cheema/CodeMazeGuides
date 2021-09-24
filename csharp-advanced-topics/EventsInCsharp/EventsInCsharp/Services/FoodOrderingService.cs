﻿using System;
using System.Threading;

namespace EventsInCsharp.Services
{
	public class FoodOrderingService
	{
		public event EventHandler<FoodPreparedEventArgs> FoodPrepared;

		public void PrepareOrder(Order order)
		{
			Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
			//Thread.Sleep(4000);

			OnFoodPrepared(order);
		}

		protected virtual void OnFoodPrepared(Order order)
		{
			FoodPrepared?.Invoke(this, new FoodPreparedEventArgs { Order = order });
		}
	}
}
