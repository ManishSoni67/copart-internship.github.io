
import java.lang.Math; // headers MUST be above the first class

// one class needs to have a main() method
public class HelloWorld
{
  // arguments are passed using the text field below this editor
  public static void main(String[] args)
  {
    String str = "1234";
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