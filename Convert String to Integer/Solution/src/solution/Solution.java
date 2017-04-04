/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package solution;

import java.util.Scanner;

/**
 *
 * @author manis
 */
public class Solution {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    Scanner sc = new Scanner(System.in);
    
    String str = sc.nextLine();
	int i =0;
    int result =0;
    boolean  neg = false;
    if(str.charAt(0)=='-')
    {
      neg=true;
      i=1;
    }
	while(i<str.length())
    {
      result*=10;
      result += str.charAt(i++)-'0';
    }
  	result = (neg?-result:result);
	System.out.println(result);
    }
    
}
