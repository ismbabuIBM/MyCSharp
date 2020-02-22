using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam_Retail
{
	class RetailReceiptClass
	{
		//setting up private variables
		private int receiptNumber;
		private DateTime dateofPurchase;
		private String customerNumber;
		private String customerName;
		private String customerAddress;
		private long cutomerPhoneno;
		private int itemNumber;
		private String itemDescription;
		private decimal unitPrice;
		private decimal quantityPurchased;

		//constructor with all arguments
		/*public RetailReceipt(int rno, DateTime date, String cusNo, String cusName, String cusAddress, long phone, int itemNo, String desc, decimal price, decimal quantity)
		{
			ReceiptNumber = rno;
			dateofPurchase = date;
			CustomerNumber = cusNo;
		    customerName = cusName;
		    customerAddress = cusAddress;
		    CutomerPhoneno = phone;
		    ItemNumber = itemNo;
		    itemDescription = desc;
		    UnitPrice = price;
		    QuantityPurchased = quantity;
		}*/

		//test constructor
		public RetailReceiptClass(int rno, DateTime date, String cusNo, decimal price)
		{
			ReceiptNumber = rno;
			dateofPurchase = date;
			CustomerNumber = cusNo;
			UnitPrice = price;
		}

		//setting up properties for private variables
		public int ReceiptNumber
		{
			get { return receiptNumber; }

			set {
					if(value > 0)
					{
						receiptNumber = value;
					}
					else
					{
					Assert.Fail("Invalid Receipt Number");
					}
				}
		}

		public String CustomerNumber
		{
			get { return customerNumber; }

			set
			{
				int length = value.Length;
				if(length == 5)
				{
					char valueStartsWith = Convert.ToChar(value.Substring(0, 1));
					if(valueStartsWith == 'C')
					{
						customerNumber = value;
					}
				}
				else
				{
					Assert.Fail("Invalid Customer Number. Valid Cus# Sample: C1799.");
				}
			}
		}

		public decimal UnitPrice
		{
			get { return unitPrice; }

			set
			{
				if(value > 0)
				{
					unitPrice = value;
				}
				else
				{
					Assert.Fail("Price cannnot be " + value.ToString("c"));
				}
			}
		}

		public override string ToString()
		{
			return "Receipt Number: " + ReceiptNumber +
				   "\nDate of Purchase: " + dateofPurchase +
				   "\nCustomer Number: " + CustomerNumber +
				   "\nUnit Price: " + UnitPrice.ToString("c");
		}
	}
}
