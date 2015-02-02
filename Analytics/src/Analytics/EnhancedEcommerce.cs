using System.ComponentModel;

namespace Analytics
{
	[Description("Enhanced Ecommerce - The enhanced ecommerce plug-in for analytics.js enables the measurement of user interactions with products on ecommerce websites across the user's shopping experience, including: product impressions, product clicks, viewing product details, adding a product to a shopping cart, initiating the checkout process, transactions, and refunds.")]
	public class EnhancedEcommerce :Require
	{
		public override string Js()
		{
			return "ga('require', 'ec');";
		}
	}
}