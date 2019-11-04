using System;
using System.IO;

namespace myApp{

	class ReadText{

		string fileName = "default";

		public ReadText(string fileName){
			this.fileName = fileName;
		}
		
		public string[] readFile(){
			string[] lines = File.ReadAllLines(fileName);
			return lines;

		}

	}
}