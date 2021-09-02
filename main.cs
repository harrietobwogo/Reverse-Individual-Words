using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine (reverseWords("Hello World"));
  }
	public static string reverseWords(string str){
		if(string.IsNullOrEmpty(str)){
			throw new Exception("String is null");
		}
		string res="";
		Stack<char>st=new Stack<char>();
		for(int i=0; i<str.Length;i++){
			if(str[i]!=' '){
				st.Push(str[i]);
			}else{
				while(st.Count>0){
           res+=st.Pop();
				}
				res+=" ";
			}
		}
		while(st.Count>0){
			res+=st.Pop();
		}
		return res;
	}
}