using System;
using System.IO;

namespace myApp{
	class WriteText{

		public WriteText(){

		}

		public void writeText(string[] text, string filePath){

			File.WriteAllLines(filePath,text);
		}
	}
}