package scannerpractices;
import java.util.Scanner;
public class Operators {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter number A: ");
		int a = sc.nextInt();
		System.out.print("Enter number B: ");
		int b = sc.nextInt();
		
		//Addition 
		System.out.println("Addition of A and B: "+ (a+b));
		//Sub
		System.out.println("Sub of A and B: "+ (a-b));
		//Multiplication
		System.out.println("Mult of A and B: "+ (a*b));
		//Div 
		System.out.println("Div of A and B: "+ (a/b));
		//Modulo 
		System.out.println("Modulo of A and B: "+(a%b));
	}

}
