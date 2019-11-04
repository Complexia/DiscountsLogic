using System;

namespace myApp{

	class Modify{

		public Modify(){

		}
		public string[] modify(string[] products, decimal discountClothing, decimal discountOther, decimal retailClothing){
			string[] modifiedProducts = new string[products.Length-1];
			int modIndex = 0;
			for(int i=1;i<products.Length;i++){
				string[] words = products[i].Split("	");

				if(!words[1].Equals("Discontinued")){
					if(words[1].Equals("Discounted") && words[2].Equals("Clothing")){
						decimal price = decimal.Parse(words[4]);
						price = price - (price/100 * discountClothing);
						price = Math.Ceiling (price * 100)/100;
						words[4] = price.ToString();
					}
					else if(words[1].Equals("Discounted") && !words[2].Equals("Clothing")){
						decimal price = decimal.Parse(words[4]);
						price = price - (price/100 * discountOther);
						price = Math.Ceiling (price * 100)/100;
						words[4] = price.ToString();
					}
					else if(!words[1].Equals("Discounted") && words[2].Equals("Clothing")){
						decimal price = decimal.Parse(words[4]);
						price = price - (price/100 * retailClothing);
						price = Math.Ceiling (price * 100)/100;
						words[4] = price.ToString();
					}
					string newLine = string.Join(", ", words);
					
					modifiedProducts[modIndex] = newLine;
					modIndex++;
				} //Discountinued
				
			} //loop
			return modifiedProducts;
		} // modify
	} // class
}